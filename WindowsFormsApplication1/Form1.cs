using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Form1 f1;
        public Form1()
        {
            InitializeComponent();
            Form1.f1 = this;
        }

          

        private void cmdModificarUsuario_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario mdUsuario = new WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario();
            mdUsuario.Show();
            this.Hide();
        }

        private void cmdPublicacion_Click(object sender, EventArgs e)
        {
            
            WindowsFormsApplication1.Generar_Publicación.AltaPublicacion aPub = new WindowsFormsApplication1.Generar_Publicación.AltaPublicacion();
            aPub.lblUsername.Text = lblUsuario.Text;
            aPub.Show();
            this.Hide();
        }

        private void ingreseUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Usuario.Login login = new WindowsFormsApplication1.ABM_Usuario.Login();
            login.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }

        private void desconectarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.ABMVisibilidad abmVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.ABMVisibilidad();
            abmVisibilidad.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rol.AltaRol aRol = new WindowsFormsApplication1.ABM_Rol.AltaRol();
            aRol.Show();
            this.Hide();
        }

        private void cmdBajaRol_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rol.BajaRol bRol = new WindowsFormsApplication1.ABM_Rol.BajaRol();
            bRol.Show();
            this.Hide();
        }

        private void cmdModificarRol_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rol.ModificacionRol mRol = new WindowsFormsApplication1.ABM_Rol.ModificacionRol();
            mRol.Show();
            this.Hide();
        }
    }
}
