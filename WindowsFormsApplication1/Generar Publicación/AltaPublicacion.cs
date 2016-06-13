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
    public partial class AltaPublicacion : Form
    {
        public static AltaPublicacion ap1;
        private int huboError = 0;
        public bool envioHabilitado;
        public int esModif;
        public int publiId;
        public int tipoPubli;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader sdr;
        private DataBase db;

        public AltaPublicacion()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
            AltaPublicacion.ap1 = this;
          
        }

        private void cargarDatos()
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Buscar_Publicacion", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PubliId", SqlDbType.Int).Value = publiId;

            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtDescripcion.Text = sdr["Descipcion"].ToString();
                txtPrecio.Text = sdr["Precio"].ToString();
                txtStockInmediata.Text = sdr["Stock"].ToString();
                txtValorSubasta.Text = sdr["Precio"].ToString();
                cboRubro.SelectedItem = sdr["DescripLarga"].ToString();
                dtpFin.Value = DateTime.Parse(sdr["FechaFin"].ToString());
                lblVisSel.Text = sdr["Descripcion"].ToString();
                tipoPubli = (int)sdr["Tipo"];
                envioHabilitado = (bool)sdr["EnvioHabilitado"];
            }
            sdr.Close();
        }

        private void lblValorSubasta_Click(object sender, EventArgs e)
        {
           
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == -1)
            {
                return;
            }
            if (cboTipo.SelectedItem.ToString() == "Subasta")
            {
                lblDescripcion.Visible = true;
                lblRubro.Visible = true;
               
                dtpFin.Visible = true;
                cboRubro.Visible = true;
                txtDescripcion.Visible = true;
                lblFin.Visible = true;

                lblValorSubasta.Visible = true;
                txtValorSubasta.Visible = true;

                lblStockInmediata.Visible = false;
                txtStockInmediata.Visible = false;

                lblPrecio.Visible = false;
                txtPrecio.Visible = false;
                
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
               
                label8.Visible = true;

                lblVisibilidad.Visible = true;
                lblVisSel.Visible = true;
                cmdSelVis.Visible = true;

            }

            if (cboTipo.SelectedItem.ToString() == "Compra inmediata")
            {
                lblDescripcion.Visible = true;
                lblRubro.Visible = true;
             
                dtpFin.Visible = true;
                cboRubro.Visible = true;
                txtDescripcion.Visible = true;
                lblFin.Visible = true;

                lblValorSubasta.Visible = false;
                txtValorSubasta.Visible = false;

                lblStockInmediata.Visible = true;
                txtStockInmediata.Visible = true;
                txtPrecio.Visible = true;
              
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lblPrecio.Visible = true;
                label8.Visible = true;

                lblVisibilidad.Visible = true;
                lblVisSel.Visible = true;
                cmdSelVis.Visible = true;
            }
            timer1.Start();
        }

        private void AltaPublicacion_Load(object sender, EventArgs e)
        {
            
            cargarComboBoxRubros();

            lblPrecio.Visible = false;
            txtPrecio.Visible = false;

            lblVisibilidad.Visible = false;
            lblVisSel.Visible = false;
            cmdSelVis.Visible = false;
            
            lblDescripcion.Visible = false;
            lblRubro.Visible = false;
           
            dtpFin.Visible = false;
            cboRubro.Visible = false;
            txtDescripcion.Visible = false;
            lblFin.Visible = false;

            lblValorSubasta.Visible = false;
            txtValorSubasta.Visible = false;

            lblStockInmediata.Visible = false;
            txtStockInmediata.Visible = false;
            label2.Visible = true;
            
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lblPrecio.Visible = false;
            label8.Visible = false;

            if (esModif == 1)
            {
                label1.Visible = false;
                lblTitulo.Visible = true;
                label2.Visible = false;
                cboTipo.Visible = false;
                cargarDatos();
                if (tipoPubli == 1)
                {
                    cboTipo.SelectedIndex = 1;
                }
                else
                {
                    cboTipo.SelectedIndex = 2;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string cadenaDeErrores = "Debe completar los siguientes campos: \r";
            string cadenaDeErrorTipo = "Debe seleccionar un tipo de publicacion";
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show(cadenaDeErrorTipo, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (cboTipo.SelectedItem.ToString() == "Compra inmediata")                                 
            {
                if(string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    cadenaDeErrores += " Descripcion \r";
                    huboError++;
                }

                if(string.IsNullOrEmpty(txtStockInmediata.Text))
                {
                    cadenaDeErrores += " Stock \r";
                    huboError++;
                }
                if (cboRubro.SelectedIndex == -1)
                {
                    cadenaDeErrores += " Rubro \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(lblVisSel.Text))
                {
                    cadenaDeErrores += "Visibilidad \r";
                    huboError++;
                }
                if (dtpFin.Value < DateTime.Today)
                {
                    MessageBox.Show("Debe ingresar una fecha igual o posterior a la de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    cadenaDeErrores += " Precio \r";
                    huboError++;
                }

                if (huboError != 0)
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    huboError = 0;
                    return;
                }
                PublicacionDOA doa = new PublicacionDOA();
             
                doa.crearPublicacion(txtDescripcion.Text, int.Parse(txtStockInmediata.Text), dtpFin.Value, txtPrecio.Text, lblVisSel.Text, cboRubro.SelectedValue.ToString(), cboTipo.SelectedItem.ToString(), lblUsername.Text, envioHabilitado);

               
                
            }
            if (cboTipo.SelectedItem.ToString() == "Subasta")
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    cadenaDeErrores += " Descripcion \r";
                    huboError++;
                }

                if (string.IsNullOrEmpty(txtValorSubasta.Text))
                {
                    cadenaDeErrores += " Valor Inicial de la subasta \r";
                    huboError++;
                }
                if (cboRubro.SelectedIndex == -1)
                {
                    cadenaDeErrores += " Rubro \r";
                    huboError++;
                }
                if (string.IsNullOrEmpty(lblVisSel.Text))
                {
                    cadenaDeErrores += "Visibilidad \r";
                    huboError++;
                }

                if (huboError != 0) 
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    huboError = 0;
                    return;
                }
                PublicacionDOA doa = new PublicacionDOA();
                
                doa.crearPublicacion(txtDescripcion.Text, 1,dtpFin.Value, txtValorSubasta.Text,lblVisSel.Text, cboRubro.SelectedValue.ToString(),cboTipo.SelectedItem.ToString(), lblUsername.Text, envioHabilitado);
            }     
            
            WindowsFormsApplication1.Form1.f1.Show();
            this.Hide();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            cboRubro.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtStockInmediata.Text = "";
            txtValorSubasta.Text = "";
            txtPrecio.Text = "";
            lblVisSel.Text = "";
            
            //cboTipo.SelectedIndex = -1;
            //cboTipo.Text = "Seleccione un tipo";
            //PARA MI NO HAY QUE CAMBIAR EL TIPO DE LA PUBLI PORQUE SINO HAY QUE RECALCULAR QUÉ CAMPOS VAN
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSelVis_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.Form1 setVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.Form1();
            setVisibilidad.user = lblUsername.Text;
            setVisibilidad.Show();
            this.Hide();
        }

        public void cargarComboBoxRubros()
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.ListaRubros", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Rubro");
            adapter.Fill(dt);
            this.cboRubro.DataSource = dt;
            this.cboRubro.DisplayMember = "DescripLarga";

            cboRubro.ValueMember = cboRubro.DisplayMember;
            if (esModif == 0)
            {
                cboRubro.SelectedIndex = -1;
                cboRubro.Text = "Seleccione un rubro";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string cadenaDeErrores = "Debe completar los siguientes campos: \r";                  

            if (cboTipo.SelectedItem.ToString() == "Compra inmediata")
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    cadenaDeErrores += " Descripcion \r";
                    huboError++;
                }

                if (string.IsNullOrEmpty(txtStockInmediata.Text))
                {
                    cadenaDeErrores += " Stock \r";
                    huboError++;
                }             
                if (string.IsNullOrEmpty(lblVisSel.Text))
                {
                    cadenaDeErrores += "Visibilidad \r";
                    huboError++;
                }
                if (dtpFin.Value < DateTime.Today)
                {
                    MessageBox.Show("Debe ingresar una fecha igual o posterior a la de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    cadenaDeErrores += " Precio \r";
                    huboError++;
                }

                if (huboError != 0)
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    huboError = 0;
                    return;
                }
                PublicacionDOA doa = new PublicacionDOA();

                doa.modificarPublicacion(publiId, txtDescripcion.Text, int.Parse(txtStockInmediata.Text), dtpFin.Value, txtPrecio.Text, lblVisSel.Text, cboRubro.SelectedValue.ToString(), cboTipo.SelectedItem.ToString(), lblUsername.Text, envioHabilitado);
            }
            if (cboTipo.SelectedItem.ToString() == "Subasta")
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    cadenaDeErrores += " Descripcion \r";
                    huboError++;
                }

                if (string.IsNullOrEmpty(txtValorSubasta.Text))
                {
                    cadenaDeErrores += " Valor Inicial de la subasta \r";
                    huboError++;
                }               
                if (string.IsNullOrEmpty(lblVisSel.Text))
                {
                    cadenaDeErrores += "Visibilidad \r";
                    huboError++;
                }

                if (huboError != 0)
                {
                    MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    huboError = 0;
                    return;
                }
                PublicacionDOA doa = new PublicacionDOA();

                doa.modificarPublicacion(publiId, txtDescripcion.Text, 1, dtpFin.Value, txtValorSubasta.Text, lblVisSel.Text, cboRubro.SelectedValue.ToString(), cboTipo.SelectedItem.ToString(), lblUsername.Text, envioHabilitado);
            }

            WindowsFormsApplication1.Generar_Publicación.EstadoPublicacion.estado.Show();
            this.Hide();
        }
    }
}
