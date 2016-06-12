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

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class Facturar : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader sdr;
        private DataBase db;
        public static Facturar fact;
        public int factId;

        public Facturar()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            Facturar.fact = this;
            cargarDatos();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            
        }

        public void cargarDatos() 
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Buscar_Factura", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FactId", SqlDbType.Int).Value = factId;

            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lblFactNro.Text = sdr["FactNro"].ToString();
                lblFecha.Text = sdr["Fecha"].ToString();
                lblNombre.Text = sdr["Nombres"].ToString();
            }
            sdr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            dataGridView1[0, 1].Value = "Comisión por productos vendidos";
            dataGridView1[1, 1].Value = "Comisión por envío";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Facturas.ConsultaFacturas.cf.Show();
            this.Close();
        }
    }
}
