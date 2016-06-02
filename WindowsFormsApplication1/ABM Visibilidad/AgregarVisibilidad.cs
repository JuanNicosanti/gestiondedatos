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

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class AgregarVisibilidad : Form
    {

        SqlCommand cmd;
        private DataBase db;

        public AgregarVisibilidad()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void cmdAceptarVis_Click(object sender, EventArgs e)
        {
            if (tbDescripcion.Text != "" && tbComiFija.Text != "" && tbComiVariable.Text != "" && tbEnvio.Text != "")
            {
                cmd = new SqlCommand("ROAD_TO_PROYECTO.Agregar_Visibilidad", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = tbDescripcion.Text;
                cmd.Parameters.AddWithValue("@ComiFija", SqlDbType.Int).Value = tbComiFija.Text;
                cmd.Parameters.AddWithValue("@ComiVariable", SqlDbType.Int).Value = tbComiVariable.Text;
                cmd.Parameters.AddWithValue("@ComiEnvio", SqlDbType.Int).Value = tbEnvio.Text;
                cmd.ExecuteNonQuery();

                Form1.visibilidad.Show();
                WindowsFormsApplication1.ABM_Visibilidad.Form1.visibilidad.cargarComboBox();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falta ingresar algún campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            tbDescripcion.Text = "";
            tbComiFija.Text = "";
            tbComiVariable.Text = "";
            tbEnvio.Text = "";
        }

        private void cmdVolverComs_Click(object sender, EventArgs e)
        {
            Form1.visibilidad.Show();
            this.Hide();
        }
    }
}
