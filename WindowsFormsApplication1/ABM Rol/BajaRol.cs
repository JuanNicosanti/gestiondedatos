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

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class BajaRol : Form
    {
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        public BajaRol()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void BajaRol_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.ListaRoles", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Rol");
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;             
          
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Hide();
        }

        private void cmdEliminarRol_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null){

                MessageBox.Show("Debe seleccionar un Rol", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
                        
            int fila = dataGridView1.CurrentRow.Index;
            int celdaIdRol = (int)dataGridView1[0,fila].Value;
            
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.BajaRol", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Rol", SqlDbType.Int).Value = celdaIdRol;
            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
           //dataGridView1[0,fila].
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
