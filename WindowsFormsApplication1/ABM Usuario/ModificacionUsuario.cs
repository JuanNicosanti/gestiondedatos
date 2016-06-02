using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class ModificacionUsuario : Form
    {
        public ModificacionUsuario()
        {
            InitializeComponent();
        }

        private void ModificacionUsuario_Load(object sender, EventArgs e)
        {

            chkApellido.Visible = false;
            chkEmailCliente.Visible = false;
            chkMailCl.Visible = false;
            chkNombreC.Visible = false;

            chkRazonSocial.Visible = false;
            chkEmailEmpresa.Visible = false;
            chkCUITEmpresa.Visible = false;
        
            
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
                chkApellido.Visible = true;
                chkEmailCliente.Visible = true;
                chkMailCl.Visible = true;
                chkNombreC.Visible = true;


                chkRazonSocial.Visible = false;
                chkEmailEmpresa.Visible = false;
                chkCUITEmpresa.Visible = false;
            }
            if (cboSeleccion.SelectedItem.ToString() == "Empresa")
            {
                chkRazonSocial.Visible = true;
                chkEmailEmpresa.Visible = true;
                chkCUITEmpresa.Visible = true;

                chkApellido.Visible = false;
                chkEmailCliente.Visible = false;
                chkMailCl.Visible = false;
                chkNombreC.Visible = false;

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
