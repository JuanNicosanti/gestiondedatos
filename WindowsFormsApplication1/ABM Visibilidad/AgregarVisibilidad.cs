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

                ABMVisibilidad.abmVis.Show();
                this.Close();
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
            ABMVisibilidad.abmVis.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbEnvio_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbComiVariable_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbComiFija_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
