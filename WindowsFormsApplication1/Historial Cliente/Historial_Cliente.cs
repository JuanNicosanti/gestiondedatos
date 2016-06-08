using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class Historial_Cliente : Form
    {
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private int contadorDeFilas;
        private int cantidadMaximaDeFilas;
        private DataBase db;

        int filasPagina = 10; // Definimos el numero de filas que deseamos ver por pagina
        int nroPagina = 1;//Esto define el numero de pagina actual en al que nos encontramos
        int ini = 0; //inicio del paginado
        int fin = 0;//fin del paginado

        int numeroRegistro;

        DataTable dtClientes = new DataTable();
        DataRow fila;

        public Historial_Cliente()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPrimera_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTotalPagina.Text) > 1)
            {
                this.nroPagina = 1;

                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblPaginaActual.Text) > 1)
            {
                this.nroPagina -= 1;


                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblPaginaActual.Text) < Convert.ToInt32(lblTotalPagina.Text))
            {
                this.nroPagina += 1;


                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void cmdUltima_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTotalPagina.Text) > 1)
            {
                this.nroPagina = Convert.ToInt32(lblTotalPagina.Text);

                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void paginar()
        {
            nroPagina = Convert.ToInt32(lblPaginaActual.Text);//Obtenemos el numero de paginaactual 
            if (dataGridView2.Rows.Count > filasPagina)
            {
                this.ini = nroPagina * filasPagina - filasPagina;
                this.fin = nroPagina * filasPagina;
                if (fin > dataGridView2.Rows.Count)
                    fin = dataGridView2.Rows.Count;
            }
            else
            {
                this.ini = 0;
                this.fin = dataGridView1.Rows.Count;
            }

            dataGridView1.Rows.Clear();
            int indiceInsertar;//
            numeroRegistro = this.ini;
            dataGridView2.ColumnCount = 9;
            dataGridView2.Columns[0].Name = "PublId";
            dataGridView2.Columns[1].Name = "Descripcion";
            dataGridView2.Columns[2].Name = "Stock";
            dataGridView2.Columns[3].Name = "FechaInicio";
            dataGridView2.Columns[4].Name = "FechaFin";
            dataGridView2.Columns[5].Name = "Precio";
            dataGridView2.Columns[6].Name = "Rubro";
            dataGridView2.Columns[7].Name = "Tipo";
            dataGridView2.Columns[8].Name = "UserId";

            contadorDeFilas = 0;
            for (int i = ini; i < filasPagina * nroPagina; i++)
            {

                fila = dtClientes.Rows[i];

                numeroRegistro = numeroRegistro + 1;
                dataGridView1.Rows.Add();

                indiceInsertar = i;
                dataGridView2.Rows[contadorDeFilas].Cells[0].Value = fila[0].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[1].Value = fila[1].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[2].Value = fila[2].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[3].Value = fila[3].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[4].Value = fila[4].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[5].Value = fila[5].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[6].Value = fila[6].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[7].Value = fila[7].ToString();
                dataGridView2.Rows[contadorDeFilas].Cells[8].Value = fila[8].ToString();

                contadorDeFilas++;

                if (numeroRegistro == cantidadMaximaDeFilas && nroPagina == int.Parse(lblTotalPagina.Text))
                {
                    i = filasPagina * nroPagina;

                }



            }
        }

        private void numPaginas()
        {
            if (dtClientes.Rows.Count % filasPagina == 0)
                lblTotalPagina.Text = (dtClientes.Rows.Count / filasPagina).ToString();
            else
            {
                double valor = dtClientes.Rows.Count / filasPagina;
                lblTotalPagina.Text = (Convert.ToInt32(valor) + 1).ToString();

            }

            lblPaginaActual.Text = "1";
        }

        private void cmdVerHistorial_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {

                MessageBox.Show("Debe seleccionar un cliente para revisar su historial de compras/subastas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            int fila = dataGridView1.CurrentRow.Index;
            int clienteID = (int)dataGridView1[0, fila].Value;
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Historial_Cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@ClienteId", SqlDbType.Int).Value = clienteID;
            
            adapter = new SqlDataAdapter(cmd);
            dtClientes = new DataTable("ROAD_TO_PROYECTO.Clientes");
            adapter.Fill(dtClientes);

            
            if (dtClientes.Rows.Count > 0)
            {
                this.numPaginas(); //Funcion para calcular el numero total de paginas que tendra nuestra vista
                this.paginar();//empezamos con la paginacion             
                lblCantidadTotal.Text = "Compras/Subastas Encontradas: " + dtClientes.Rows.Count.ToString();//Cantidad totoal de registros encontrados
                cantidadMaximaDeFilas = dtClientes.Rows.Count;
                dataGridView2.Select();
            }
            else
            {
                dataGridView2.Rows.Clear();//En el caso de que la busqueda no genere ningun registro limopiamos el datagridview

                lblCantidadTotal.Text = "Compras/Subastas Encontradas: 0";
                cantidadMaximaDeFilas = 0;
            }
           
        }

        private void Historial_Cliente_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.DatosCliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Cliente");
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Hide();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }
    }
}
