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

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class ModificarVisibilidad : Form
    {
        SqlCommand cmd;
        private DataBase db;
        public static ModificarVisibilidad modVis;
        public int visiId;

        public ModificarVisibilidad()
        {
            InitializeComponent();
            ModificarVisibilidad.modVis = this;
            db = DataBase.GetInstance();
        }

        private void ModificarVisibilidad_Load(object sender, EventArgs e)
        {

        }

        private void cmdVolverComs_Click(object sender, EventArgs e)
        {
            ABMVisibilidad.abmVis.Show();
            this.Hide();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            tbDescripcion.Text = "";
            tbComiFija.Text = "";
            tbComiVariable.Text = "";
            tbEnvio.Text = "";
        }

        private void cmdAceptarVis_Click(object sender, EventArgs e)
        {
            if (tbDescripcion.Text != "" && tbComiFija.Text != "" && tbComiVariable.Text != "" && tbEnvio.Text != "")
            {
                cmd = new SqlCommand("ROAD_TO_PROYECTO.Modificacion_Visibilidad", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VisiId", SqlDbType.Int).Value = visiId;                
                cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = tbDescripcion.Text;
                cmd.Parameters.AddWithValue("@ComiFija", SqlDbType.Int).Value = tbComiFija.Text;
                cmd.Parameters.AddWithValue("@ComiVariable", SqlDbType.Int).Value = tbComiVariable.Text;
                cmd.Parameters.AddWithValue("@ComiEnvio", SqlDbType.Int).Value = tbEnvio.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elemento modificado", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                
                WindowsFormsApplication1.ABM_Visibilidad.ABMVisibilidad.abmVis.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Falta ingresar algún campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
