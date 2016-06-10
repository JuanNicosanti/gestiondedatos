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

namespace WindowsFormsApplication1.Calificar
{
    public partial class HistorialCalificaciones : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader sdr;
        private DataBase db;
        public string user;

        public HistorialCalificaciones()
        {
            user = WindowsFormsApplication1.Form1.f1.user;
            db = DataBase.GetInstance();
            InitializeComponent();
            cargarTabla();
            cargarLabels();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Calificar.MenuCalificaciones.menuCalif.Show();
            this.Close();
        }

        public void cargarLabels() {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Comisiones_Valores", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Visibilidad", SqlDbType.NVarChar).Value = cboTipoVis.SelectedValue.ToString();

            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //textBoxTipo.Text = sdr["ComiFija"].ToString();
                //textBoxProd.Text = sdr["ComiVariable"].ToString();
                //textBoxEnvio.Text = sdr["ComiEnvio"].ToString();
            }
            sdr.Close();
        }

        public void cargarTabla() {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Ultimas_Cinco_Transacciones_Calificadas", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", SqlDbType.NVarChar).Value = user;           

            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Transaccion");
            adapter.Fill(dt);
            this.dgComprasCalif.DataSource = dt;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Close();
        }

        private void dgComprasCalif_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
