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

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ModificacionUsuario : Form
    {
        int visibilidadCmdModificar = 0;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        public ModificacionUsuario()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void ModificacionUsuario_Load(object sender, EventArgs e)
        {

            txtRazonSocial.Visible = false;
            txtEmailE.Visible = false;
            txtCUIT.Visible = false;
            lblCUIT.Visible = false;
            lblEmailE.Visible = false;
            lblRazonSocial.Visible = false;

            txtApellido.Visible = false;
            txtEmailC.Visible = false;
            txtDNI.Visible = false;
            txtNombre.Visible = false;
            lblApellido.Visible = false;
            lblDNI.Visible = false;
            lblEmailC.Visible = false;
            lblNombre.Visible = false;


             
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            //FALTA EL FILTRADO
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            
            this.Hide();
            
        }

        private void cboSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSeleccion.SelectedItem.ToString() == "Cliente")
            {
                txtApellido.Visible = true;
                txtEmailC.Visible = true;
                txtDNI.Visible = true;
                txtNombre.Visible = true;
                lblApellido.Visible = true;
                lblDNI.Visible = true;
                lblEmailC.Visible = true;
                lblNombre.Visible = true;


                txtRazonSocial.Visible = false;
                txtEmailE.Visible = false;
                txtCUIT.Visible = false;
                lblCUIT.Visible = false;
                lblEmailE.Visible = false;
                lblRazonSocial.Visible = false;
                txtRazonSocial.Text = "";
                txtEmailE.Text = "";
                txtCUIT.Text = "";
              
            }
            if (cboSeleccion.SelectedItem.ToString() == "Empresa")
            {
                txtRazonSocial.Visible = true;
                txtEmailE.Visible = true;
                txtCUIT.Visible = true;
                lblCUIT.Visible = true;
                lblEmailE.Visible = true;
                lblRazonSocial.Visible = true;

                txtApellido.Visible = false;
                txtEmailC.Visible = false;
                txtDNI.Visible = false;
                txtNombre.Visible = false;
                lblApellido.Visible = false;
                lblDNI.Visible = false;
                lblEmailC.Visible = false;
                lblNombre.Visible = false;
                txtApellido.Text = "";
                txtEmailC.Text = "";
                txtDNI.Text = "";
                txtNombre.Text = "";


            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBusqueda_Click(object sender, EventArgs e)
        {
           
            string cadenaDeErrorTipo = "Debe seleccionar un tipo de filtro de busqueda";
            if (cboSeleccion.SelectedIndex == -1)
            {
                MessageBox.Show(cadenaDeErrorTipo, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (cboSeleccion.SelectedItem.ToString() == "Cliente")
            {
               
                
                if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text) && string.IsNullOrEmpty(txtDNI.Text) && string.IsNullOrEmpty(txtEmailC.Text))
                {
                    MessageBox.Show(cadenaDeErrorTipo, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                cmd = new SqlCommand("ROAD_TO_PROYECTO.Buscar_Cliente", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;


                if (string.IsNullOrEmpty(txtEmailC.Text))
                {
                    cmd.Parameters.AddWithValue("@Mail", SqlDbType.NVarChar).Value = "";
                }
                else {
                    cmd.Parameters.AddWithValue("@Mail", SqlDbType.NVarChar).Value = txtEmailC.Text;
                }

                
                if (string.IsNullOrEmpty(txtDNI.Text))
                {
                    cmd.Parameters.AddWithValue("@NroDocumento", DBNull.Value);
                }
                else {
                    cmd.Parameters.AddWithValue("@NroDocumento", SqlDbType.Int).Value = int.Parse(txtDNI.Text);
                }

               
               
                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    cmd.Parameters.AddWithValue("@Apellido", SqlDbType.Int).Value = "";
                }
                else {
                    cmd.Parameters.AddWithValue("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text;
                }


                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    cmd.Parameters.AddWithValue("@Nombres", SqlDbType.Int).Value = "";
                }
                else {
                    cmd.Parameters.AddWithValue("@Nombres", SqlDbType.NVarChar).Value = txtNombre.Text;
                }

                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ROAD_TO_PROYECTO.Cliente");
                adapter.Fill(dt);
                this.dataGridView1.DataSource = dt;

       

               
            }
            if (cboSeleccion.SelectedItem.ToString() == "Empresa")
            {
                if (string.IsNullOrEmpty(txtRazonSocial.Text) && string.IsNullOrEmpty(txtCUIT.Text) && string.IsNullOrEmpty(txtEmailE.Text))
                {
                    MessageBox.Show(cadenaDeErrorTipo, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                /*cmd = new SqlCommand("ROAD_TO_PROYECTO.Buscar_Cliente", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mail", SqlDbType.NVarChar).Value = txtEmailC.Text;
                cmd.Parameters.AddWithValue("@NroDocumento", SqlDbType.Int).Value = txtDNI.Text;
                cmd.Parameters.AddWithValue("@Apellido", SqlDbType.Int).Value = txtApellido.Text;
                cmd.Parameters.AddWithValue("@Nombres", SqlDbType.Int).Value = txtNombre.Text;
                cmd.ExecuteNonQuery();*/
             


            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {

                MessageBox.Show("Debe seleccionar un usuario a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (cboSeleccion.SelectedItem.ToString() == "Cliente")
            {
                AltaUsuario.aus.esAltaUsuario = 0;
                AltaUsuario.aus.rbCliente.Checked = true;
//                AltaUsuario.aus.txtUsuario.Text =
//                AltaUsuario.aus.txtPassword.Text =
//                AltaUsuario.aus.txtTelCliente.Text =
//                AltaUsuario.aus.txtDpto.Text =
//                AltaUsuario.aus.txtCalle.Text =
//                AltaUsuario.aus.txtPiso.Text =
//                AltaUsuario.aus.txtLocalidad.Text =
//                AltaUsuario.aus.txtApellidoCliente.Text =
//                AltaUsuario.aus.txtNombreCliente.Text =
//                AltaUsuario.aus.txtDNICliente.Text =
//                AltaUsuario.aus.cboTipoCliente.SelectedItem = 
//                AltaUsuario.aus.txtMail.Text =
//                AltaUsuario.aus.txtCodPos.Text =
//                AltaUsuario.aus.dtpCreacion.Value =


            }
            if (cboSeleccion.SelectedItem.ToString() == "Empresa")
            {
                AltaUsuario.aus.esAltaUsuario = 0;
                AltaUsuario.aus.rbEmpresa.Checked = true;
//                AltaUsuario.aus.txtUsuario.Text =
//                AltaUsuario.aus.txtPassword.Text =
//                AltaUsuario.aus.txtTelCliente.Text =
//                AltaUsuario.aus.txtDpto.Text =
//                AltaUsuario.aus.txtCalle.Text =
//                AltaUsuario.aus.txtPiso.Text =
//                AltaUsuario.aus.txtLocalidad.Text =
//                AltaUsuario.aus.txtRazonEmpresa.Text =
//                AltaUsuario.aus.txtMail.Text =
//                AltaUsuario.aus.txtTelEmpresa.Text =
//                AltaUsuario.aus.txtCodPos.Text =
//                AltaUsuario.aus.txtCiudadEmpresa.Text =
//                AltaUsuario.aus.txtCUITEmpresa.Text =
//                AltaUsuario.aus.txtNombreContEmpresa.Text =
//                AltaUsuario.aus.lblRubroSel.Text =
            }
            visibilidadCmdModificar = 0;
            cmdModificar.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (visibilidadCmdModificar == 0)
            {
                cmdModificar.Visible = true;
            }
            visibilidadCmdModificar = 1;
            
        }
    }
}
