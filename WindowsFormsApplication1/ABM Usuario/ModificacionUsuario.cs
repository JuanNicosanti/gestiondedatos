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
       
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        private Cliente unCliente;
        private Empresa unaEmpresa;
        private ClienteDOA doaCliente;
        private EmpresaDOA doaEmpresa;

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
                    cmd.Parameters.AddWithValue("@Apellido", SqlDbType.NVarChar).Value = "";
                }
                else {
                    cmd.Parameters.AddWithValue("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text;
                }


                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    cmd.Parameters.AddWithValue("@Nombres", SqlDbType.NVarChar).Value = "";
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
                cmd = new SqlCommand("ROAD_TO_PROYECTO.Buscar_Empresa", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;


                if (string.IsNullOrEmpty(txtEmailE.Text))
                {
                    cmd.Parameters.AddWithValue("@Mail", SqlDbType.NVarChar).Value = "";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Mail", SqlDbType.NVarChar).Value = txtEmailE.Text;
                }


                if (string.IsNullOrEmpty(txtCUIT.Text))
                {
                    cmd.Parameters.AddWithValue("@CUIT", SqlDbType.NVarChar).Value = "";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CUIT", SqlDbType.Int).Value = txtCUIT.Text;
                }



                if (string.IsNullOrEmpty(txtRazonSocial.Text))
                {
                    cmd.Parameters.AddWithValue("@RazonSocial", SqlDbType.NVarChar).Value = "";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@RazonSocial", SqlDbType.NVarChar).Value = txtRazonSocial.Text;
                }


                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ROAD_TO_PROYECTO.Empresa");
                adapter.Fill(dt);
                this.dataGridView1.DataSource = dt;

       
        


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
              

                int fila = dataGridView1.CurrentRow.Index;
            
                int celdaIdCliente = (int)dataGridView1[0, fila].Value;

                cargarUnClienteSeleccionado(celdaIdCliente);

                this.Hide();
                AltaUsuario.aus.Show();



            }
            if (cboSeleccion.SelectedItem.ToString() == "Empresa")
            {
               

                int fila = dataGridView1.CurrentRow.Index;

                int celdaIdEmpresa = (int)dataGridView1[0, fila].Value;

                cargarUnaEmpresaSeleccionada(celdaIdEmpresa);

                this.Hide();
                AltaUsuario.aus.Show();

            }
       
        }

        private void cargarUnaEmpresaSeleccionada(int idEmpresa)
        {
            unaEmpresa = doaEmpresa.crearUnaEmpresa(idEmpresa);

            AltaUsuario.aus.esAltaUsuario = 0;
            AltaUsuario.aus.rbEmpresa.Checked = true;
            AltaUsuario.aus.txtUsuario.Text = unaEmpresa.username;
            AltaUsuario.aus.txtPassword.Text = unaEmpresa.password;
            AltaUsuario.aus.txtTelEmpresa.Text = Convert.ToString(unaEmpresa.telefono);
          
            AltaUsuario.aus.txtDpto.Text = unaEmpresa.departamento;
            AltaUsuario.aus.txtCalle.Text = unaEmpresa.calle;
            AltaUsuario.aus.txtPiso.Text =Convert.ToString(unaEmpresa.piso);
            AltaUsuario.aus.txtLocalidad.Text =unaEmpresa.localidad;
            AltaUsuario.aus.txtRazonEmpresa.Text =unaEmpresa.razonSocial;
            AltaUsuario.aus.txtMail.Text =unaEmpresa.mail;
            AltaUsuario.aus.txtTelEmpresa.Text =Convert.ToString(unaEmpresa.telefono);
            AltaUsuario.aus.txtCodPos.Text =Convert.ToString(unaEmpresa.codPostal);
            AltaUsuario.aus.txtCiudadEmpresa.Text =unaEmpresa.ciudad;
            AltaUsuario.aus.txtCUITEmpresa.Text =Convert.ToString(unaEmpresa.cuit);
            AltaUsuario.aus.txtNombreContEmpresa.Text =unaEmpresa.nombreContacto;
            AltaUsuario.aus.lblRubroSel.Text = unaEmpresa.rubro;
        }
        private void cargarUnClienteSeleccionado(int idCliente)
        {
            unCliente = doaCliente.crearUnCliente(idCliente);

            AltaUsuario.aus.esAltaUsuario = 0;
            AltaUsuario.aus.rbCliente.Checked = true;

            AltaUsuario.aus.txtUsuario.Text = unCliente.username;
            AltaUsuario.aus.txtPassword.Text =unCliente.password;
            AltaUsuario.aus.txtTelCliente.Text =Convert.ToString(unCliente.telefono);
            AltaUsuario.aus.txtDpto.Text =unCliente.departamento;
            AltaUsuario.aus.txtCalle.Text =unCliente.calle;
            AltaUsuario.aus.txtPiso.Text =Convert.ToString(unCliente.piso);
            AltaUsuario.aus.txtLocalidad.Text =unCliente.localidad;
            AltaUsuario.aus.txtApellidoCliente.Text =unCliente.apellido;
            AltaUsuario.aus.txtNombreCliente.Text =unCliente.nombre;
            AltaUsuario.aus.txtDNICliente.Text =Convert.ToString(unCliente.dni);
            AltaUsuario.aus.cboTipoCliente.SelectedItem =unCliente.tipoDocumento; 
            AltaUsuario.aus.txtMail.Text =unCliente.mail;
            AltaUsuario.aus.txtCodPos.Text =Convert.ToString(unCliente.codPostal);
            AltaUsuario.aus.dtpCreacion.Value = unCliente.nacimiento;
            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            cboSeleccion.SelectedItem = "";
            //dataGridView1.Rows.Clear();
            //dataGridView1.Refresh();
            txtRazonSocial.Text = "";
            txtEmailE.Text = "";
            txtCUIT.Text = "";          
            txtApellido.Text = "";
            txtEmailC.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
        }
    }
}
