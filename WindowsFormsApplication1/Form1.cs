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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public String user;
        public Boolean hayUsuario = false;
        private List<int> idRoles = new List<int>();
        private DataBase db;

        public static Form1 f1;
        
        public String rol;
        public int idRol;
        private int tag = 0;


        public Form1()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
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
            aPub.lblUsername.Text = user;
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
            timer1.Start();
            funcionesToolStripMenuItem.Enabled = false;
            desconectarseToolStripMenuItem.Enabled = false;

            
                
     

            
            
        }

        private void desconectarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "";
            hayUsuario = false;

            funcionesToolStripMenuItem.DropDownItems.Clear();
           
            
            funcionesToolStripMenuItem.Enabled = false;
            desconectarseToolStripMenuItem.Enabled = false;
            ingreseUsuarioToolStripMenuItem.Enabled = true;

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
            aRol.esAltaRol = 1;
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

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hayUsuario)
            {
                lblUsuario.Text = user;
                funcionesToolStripMenuItem.Enabled = true;
                desconectarseToolStripMenuItem.Enabled = true;
                ingreseUsuarioToolStripMenuItem.Enabled = false;
                
                SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.FuncionesDeUnRol", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Rol", SqlDbType.Int).Value = idRol;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {               
                    ToolStripMenuItem unMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                    
                    unMenuToolStripMenuItem.Name = sdr["Descripcion"].ToString();
                    unMenuToolStripMenuItem.Text = sdr["Descripcion"].ToString();
                    
                    funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {unMenuToolStripMenuItem});        
                }
                hayUsuario = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
