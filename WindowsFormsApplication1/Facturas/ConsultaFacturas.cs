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

namespace WindowsFormsApplication1.Facturas
{
    public partial class ConsultaFacturas : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        private DataBase db;

        public ConsultaFacturas()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void panelResultados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            tbFechaInicial.Text = "";
            tbFechaFinal.Text = "";
            tbImporteMinimo.Text = "";
            tbImporteMaximo.Text = "";
            tbContenido.Text = "";
            tbVendedor.Text = "";
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {            
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Consulta_Facturas_Vendedor", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FechaInicioIntervalo", SqlDbType.DateTime).Value = tbFechaInicial.Text;
            cmd.Parameters.AddWithValue("@FechaFinIntervalo", SqlDbType.DateTime).Value = tbFechaFinal.Text;
            cmd.Parameters.AddWithValue("@MontoInicioIntervalo", SqlDbType.Int).Value = int.Parse(tbImporteMinimo.Text);
            cmd.Parameters.AddWithValue("@MontoFinIntervalo", SqlDbType.Int).Value = int.Parse(tbImporteMaximo.Text);
            cmd.Parameters.AddWithValue("@Detalle", SqlDbType.NVarChar).Value = tbContenido.Text;
            cmd.Parameters.AddWithValue("@Usuario", SqlDbType.NVarChar).Value = tbVendedor.Text;

            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Facturas");
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

            panelResultados.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmdVerFactura_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ComprarOfertar.Facturar factura = new WindowsFormsApplication1.ComprarOfertar.Facturar();
            factura.Show();
            this.Hide();
        }
    }
}
