using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class EstadoPublicacion : Form
    {
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        public string user;
        public static EstadoPublicacion estado;

        public EstadoPublicacion()
        {
            InitializeComponent();
            EstadoPublicacion.estado = this;
            db = DataBase.GetInstance();
            cargarEstados();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Buscar_Publicacion_Estado", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", SqlDbType.NVarChar).Value = user;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = tbDescripcion.Text;
            cmd.Parameters.AddWithValue("@Estado", SqlDbType.NVarChar).Value = cboEstados.SelectedValue.ToString();            

            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Publicacion");
            adapter.Fill(dt);
            this.dgPublis.DataSource = dt;
            
            dgPublis.Visible = true;
        }

        private void cargarEstados() {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.lista_Estados", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Estado");
            adapter.Fill(dt);
            this.cboEstados.DataSource = dt;
            this.cboEstados.DisplayMember = "Descripcion";

            cboEstados.ValueMember = cboEstados.DisplayMember;
            cboEstados.SelectedIndex = -1;
            cboEstados.Text = "Seleccione un estado";
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgPublis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPublis.CurrentRow.Index != -1)
            { 
                int fila = dgPublis.CurrentRow.Index;
                if (dgPublis[3, fila].Value.ToString() == "Activa")
                {
                    cmdActivar.Visible = false;                    
                    cmdPausar.Visible = true;
                    cmdFinalizar.Visible = true;
                }
                if (dgPublis[3, fila].Value.ToString() == "Pausada")
                {
                    cmdActivar.Visible = true;
                    cmdPausar.Visible = false;
                    cmdFinalizar.Visible = true;
                }
                if (dgPublis[3, fila].Value.ToString() == "Finalizada")
                {
                    cmdActivar.Visible = false;
                    cmdPausar.Visible = false;
                    cmdFinalizar.Visible = false;
                }
                if (dgPublis[3, fila].Value.ToString() == "Borrador")
                {
                    cmdActivar.Visible = true;
                    cmdPausar.Visible = false;
                    cmdFinalizar.Visible = false;
                }
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Show();
            this.Close();
        }
    }
}
