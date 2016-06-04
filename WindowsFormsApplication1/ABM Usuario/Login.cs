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
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Login : Form
    {
        public int intentos_fallidos;
        public bool necesita_logueo;
        public SHA256 mySHA256 = SHA256Managed.Create();
      
        public static Login lg;
        public Login()
        {

            InitializeComponent();
            intentos_fallidos=0;
            Login.lg = this;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Hide();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtContrasenia.Clear();
            txtUsuario.Clear();
            this.timer1.Stop();
            this.toolStripProgressBar1.Value = 0;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string cadenaDeErrores = "Debe completar los siguientes campos: \r";
            int huboError = 0;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                cadenaDeErrores += " Usuario \r";
                huboError++;
            }
            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                cadenaDeErrores += " Contrasenia \r";
                huboError++;
            }

            if (huboError != 0)
            {
                MessageBox.Show(cadenaDeErrores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            string hash = this.encriptacion(txtContrasenia.Text);
            UsuarioDOA doa = new UsuarioDOA();
            Usuario user = doa.Login(txtUsuario.Text, hash);
            if (user == null)
            {
                MessageBox.Show("Datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
              

                return;
            }
            else if (!user.Habilitado)
            {
                MessageBox.Show("Usuario bloqueado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
                //doa.Bloquear(txtUsuario.Text);
            }
           
               // Program.UsuarioLogueado = user;
               // Program.UsuarioLogueado.EsAdmin = necesita_logueo;

                this.timer1.Start();              
//            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Increment(1);
        
            if (this.toolStripProgressBar1.Value == toolStripProgressBar1.Maximum )
            {
                this.toolStripProgressBar1.Value = 0;

                Form1.f1.lblUsuario.Text = this.txtUsuario.Text;
                Form1.f1.Show();
                this.timer1.Stop();
                
                this.Hide();
                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
        }

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            altaUsuario.esAltaUsuario = 1;
            altaUsuario.Show();
            this.Hide();
            
        }

        private void cmdCambiarContrasenia_Click(object sender, EventArgs e)
        {
            CambiarContrasenia cambioContrasenia = new CambiarContrasenia();
            cambioContrasenia.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        public string encriptacion(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

    }
}
