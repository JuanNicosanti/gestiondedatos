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

        public Boolean estaHabilitado;
        
        private Boolean seleccionoUsuario = false;
        private Boolean seleccionoVisibilidad = false;
        private Boolean seleccionoRol = false;
        


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

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rol.AltaRol aRol = new WindowsFormsApplication1.ABM_Rol.AltaRol();
            aRol.esAltaRol = 1;
            aRol.Show();
            this.Hide();
        }

        private void cmdBajaRol_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rol.ModificacionRol bRol = new WindowsFormsApplication1.ABM_Rol.ModificacionRol();
            bRol.cmdEliminar.Visible = true;
            bRol.cmdModificarRol.Visible = false;
            bRol.Show();
            this.Hide();
        }

        private void cmdModificarRol_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rol.ModificacionRol mRol = new WindowsFormsApplication1.ABM_Rol.ModificacionRol();
            
            mRol.Show();
            this.Hide();
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

                if (estaHabilitado)
                {
                    while (sdr.Read())
                    {

                        ToolStripMenuItem unMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        String unaFuncion = sdr["Descripcion"].ToString();

                        unMenuToolStripMenuItem.Name = unaFuncion;
                        unMenuToolStripMenuItem.Text = unaFuncion;
                        unMenuToolStripMenuItem.Tag = unaFuncion;

                        if (unaFuncion == "ABM Rol" || unaFuncion == "ABM Usuario" || unaFuncion == "ABM Visibilidad")
                        {
                            cargarMiniMenuABM(unMenuToolStripMenuItem, unaFuncion);
                        }
                        unMenuToolStripMenuItem.Click += new EventHandler(funcionesPorRol_Click);


                        funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { unMenuToolStripMenuItem });
                    }
                }
                else
                {
                    while (sdr.Read())
                    {
                        ToolStripMenuItem unMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        String unaFuncion = sdr["Descripcion"].ToString();

                        unMenuToolStripMenuItem.Name = unaFuncion;
                        unMenuToolStripMenuItem.Text = unaFuncion;
                        unMenuToolStripMenuItem.Tag = unaFuncion;

                        if (unaFuncion == "ABM Rol" || unaFuncion == "ABM Usuario" || unaFuncion == "ABM Visibilidad")
                        {
                            cargarMiniMenuABM(unMenuToolStripMenuItem, unaFuncion);
                        }
                        unMenuToolStripMenuItem.Click += new EventHandler(funcionesPorRol_Click);

                        if (!unaFuncion.Equals("Comprar/Ofertar") && !unaFuncion.Equals("Generar Publicación"))
                        {
                            funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { unMenuToolStripMenuItem });
                        }
                        
                    }
                }
               
               
                hayUsuario = false;
            }
          

            
        }

        private void cargarMiniMenuABM(ToolStripMenuItem unMenuToolStripMenuItem,String unaFuncion){
            ToolStripMenuItem menuAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuAltaToolStripMenuItem.Name = "Alta";
            menuAltaToolStripMenuItem.Text = "Alta";
            menuAltaToolStripMenuItem.Tag = "Alta";
            menuAltaToolStripMenuItem.Click += new EventHandler(alta_Click);
            unMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuAltaToolStripMenuItem});

            ToolStripMenuItem menuBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuBajaToolStripMenuItem.Name = "Baja";
            menuBajaToolStripMenuItem.Text = "Baja";
            menuBajaToolStripMenuItem.Tag = "Baja";
            menuBajaToolStripMenuItem.Click += new EventHandler(baja_Click);
            unMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuBajaToolStripMenuItem });

            ToolStripMenuItem menuModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuModificarToolStripMenuItem.Name = "Modificar";
            menuModificarToolStripMenuItem.Text = "Modificar";
            menuModificarToolStripMenuItem.Tag = "Modificar";
            menuModificarToolStripMenuItem.Click += new EventHandler(modificar_Click);
            unMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuModificarToolStripMenuItem });
            if (unaFuncion.Equals("ABM Usuario"))
            {
                ToolStripMenuItem menuCambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                menuCambiarContraseñaToolStripMenuItem.Name = "Cambiar contraseña";
                menuCambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
                menuCambiarContraseñaToolStripMenuItem.Tag = "Cambiar contraseña";
                menuCambiarContraseñaToolStripMenuItem.Click += new EventHandler(cambiarContrasenia_Click);
                unMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuCambiarContraseñaToolStripMenuItem });
            }
        }

        private void cambiarContrasenia_Click(object sender, EventArgs e) {
            if (seleccionoUsuario)
            {
                WindowsFormsApplication1.ABM_Usuario.CambiarContrasenia cambiarContra = new WindowsFormsApplication1.ABM_Usuario.CambiarContrasenia();
                cambiarContra.soyAdmin = true;
                cambiarContra.Show();
                this.Hide();
            }
            
        }


        private void alta_Click(object sender, EventArgs e)
        {
            if (seleccionoRol)
            {
  
                WindowsFormsApplication1.ABM_Rol.AltaRol aRol = new WindowsFormsApplication1.ABM_Rol.AltaRol();
                aRol.esAltaRol = 1;
                aRol.Show();
                seleccionoRol = false;
                this.Hide();
                return;
            }
            if (seleccionoUsuario)
            {

                WindowsFormsApplication1.ABM_Usuario.AltaUsuario altaUsuario = new WindowsFormsApplication1.ABM_Usuario.AltaUsuario();
                altaUsuario.esAltaUsuario = 1;
                altaUsuario.irAlMenuPrincipal = 1;
                altaUsuario.Show();    
                seleccionoUsuario = false;
                this.Hide();
                return;
            }
            if (seleccionoVisibilidad)
            {
                WindowsFormsApplication1.ABM_Visibilidad.AgregarVisibilidad newVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.AgregarVisibilidad();
                newVisibilidad.Show();
                this.Hide();
                seleccionoVisibilidad= false;
                return;
            }
         
        }
        private void baja_Click(object sender, EventArgs e)
        {
            if (seleccionoRol)
            {

                WindowsFormsApplication1.ABM_Rol.ModificacionRol bRol = new WindowsFormsApplication1.ABM_Rol.ModificacionRol();
                bRol.cmdEliminar.Visible = true;
                bRol.cmdHabilitarRol.Visible = true;
                bRol.Show();
                bRol.cmdModificarRol.Visible = false;
                seleccionoRol = false;
                this.Hide();
                return;
            }
            if (seleccionoUsuario)
            {
                WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario mdUsuario = new WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario();
                mdUsuario.cmdModificar.Visible = false;
                mdUsuario.esModificar = false;
                mdUsuario.cmdEliminar.Visible = true;
                mdUsuario.Show();
                seleccionoUsuario = false;
                this.Hide();
                return;
            }
            if (seleccionoVisibilidad)
            {
                WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad bVis = new WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad();
                bVis.cmdModificar.Visible = false;
                bVis.cmdEliminar.Visible = true;
                bVis.Show();
                seleccionoVisibilidad = false;
                this.Hide();
                return;
            }
        
        }
        private void modificar_Click(object sender, EventArgs e)
        {
            if (seleccionoRol)
            {

                WindowsFormsApplication1.ABM_Rol.ModificacionRol mRol = new WindowsFormsApplication1.ABM_Rol.ModificacionRol();
                mRol.cmdModificarRol.Visible = true;
                mRol.Show();
                mRol.cmdEliminar.Visible = false;
                mRol.cmdHabilitarRol.Visible = false;
                seleccionoRol = false;
                this.Hide();
                return;
            }
            if (seleccionoUsuario)
            {
                WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario mdUsuario = new WindowsFormsApplication1.ABM_Usuario.ModificacionUsuario();
                mdUsuario.cmdModificar.Visible = true;
                mdUsuario.esModificar = true;
                mdUsuario.cmdEliminar.Visible = false;
                mdUsuario.Show();
                seleccionoUsuario = false;
                this.Hide();    
                return;
            }
            if (seleccionoVisibilidad)
            {
                WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad bVis = new WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad();
                bVis.cmdModificar.Visible = true;
                bVis.cmdEliminar.Visible = false;
                bVis.Show();
                seleccionoVisibilidad = false;
                this.Hide();
                return;
            }
      
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void funcionesPorRol_Click(object sender, EventArgs e)
        {
          
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            if ((string)clickedItem.Tag == "ABM Rol")
            {
                seleccionoRol = true;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
                
                  
                
            }

            if ((string)clickedItem.Tag == "ABM Usuario")
            {
                seleccionoRol = false;
                seleccionoUsuario = true;
                seleccionoVisibilidad = false;
                
            }

            if ((string)clickedItem.Tag == "ABM Visibilidad")
            {
                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = true;
                
            }

            if ((string)clickedItem.Tag == "ABM Rubro")
            {
                MessageBox.Show("No existe la ABM seleccionada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
                
            }

            if ((string)clickedItem.Tag == "Generar Publicación")
            {
                WindowsFormsApplication1.Generar_Publicación.AltaPublicacion aPub = new WindowsFormsApplication1.Generar_Publicación.AltaPublicacion();
                aPub.lblUsername.Text = user;
                aPub.Show();
                this.Hide();

                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
                
                
            }
            
            if ((string)clickedItem.Tag == "Comprar/Ofertar")
            {
                WindowsFormsApplication1.ComprarOfertar.ComprarOfertar.cO = new WindowsFormsApplication1.ComprarOfertar.ComprarOfertar();
                WindowsFormsApplication1.ComprarOfertar.ComprarOfertar.cO.compradorID = user;
               
              
                WindowsFormsApplication1.ComprarOfertar.ComprarOfertar.cO.Show();
                this.Hide();
                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
               
                
            }

            if ((string)clickedItem.Tag == "Historial de Cliente")
            {
                WindowsFormsApplication1.Historial_Cliente.Historial_Cliente.hc = new WindowsFormsApplication1.Historial_Cliente.Historial_Cliente();
                WindowsFormsApplication1.Historial_Cliente.Historial_Cliente.hc.username = user;
                WindowsFormsApplication1.Historial_Cliente.Historial_Cliente.hc.Show();
                this.Hide();
                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
                
            }

            if ((string)clickedItem.Tag == "Calificar al Vendedor")
            {
                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
              
            }

            if ((string)clickedItem.Tag == "Consulta de facturas realizadas al vendedor")
            {
                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
               
            }

            if ((string)clickedItem.Tag == "Listado Estadístico")
            {
                seleccionoRol = false;
                seleccionoUsuario = false;
                seleccionoVisibilidad = false;
                
            }
            

        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    


        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmdVerVisibilidad_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad bVis = new WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad();
            bVis.Show();
            this.Hide();
            return;
        }

        private void cmdCOmprar_Click(object sender, EventArgs e)
        {
            ComprarOfertar.ComprarOfertar cf = new ComprarOfertar.ComprarOfertar();
            cf.Show();
            this.Hide();
        }

        private void cmdHist_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Historial_Cliente.Historial_Cliente hC = new WindowsFormsApplication1.Historial_Cliente.Historial_Cliente();
            hC.Show();
            this.Hide();
        }

        private void cmdCalificar_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Calificar.CalificarVendedor calificarVendedor = new WindowsFormsApplication1.Calificar.CalificarVendedor();
            calificarVendedor.user = this.user;
            calificarVendedor.Show();
            this.Hide();
        }
    }
}
