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

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class Listado_Estadistico : Form
    {
        public static Listado_Estadistico lE;
        private DataBase db;
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;

        private int indexTrimestreSeleccionado;
        private int anio;
        private String rubroElegido;

        public Listado_Estadistico()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            Listado_Estadistico.lE = this;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Hide();
        }

        private void Listado_Estadistico_Load(object sender, EventArgs e)
        {
            lblTrim.Visible = false;
            cmdTrimestre.Visible = false;
            cboTrim.Visible = false;
            
            lblTopp.Visible = false;
            cmdTop1.Visible = false;
            cmdTop2.Visible = false;
            cmdTop3.Visible = false;
            cmdTop4.Visible = false;

            lblRubro.Visible = false;
            cmdRubro.Visible = false;
            cboRubro.Visible = false;

        }

        private void cmdAnio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                MessageBox.Show("Ingrese un año", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
               
            }
            txtAnio.Enabled = false;
            anio = int.Parse(txtAnio.Text.ToString());
            lblTrim.Visible = true;
            cmdTrimestre.Visible = true;
            cboTrim.Visible = true;
        }

        private void cmdTrimestre_Click(object sender, EventArgs e)
        {
            if (cboTrim.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un trimestre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;

            }
            indexTrimestreSeleccionado = cboTrim.SelectedIndex;
            cboTrim.Enabled = false;
            lblTopp.Visible = true;
            cmdTop1.Visible = true;
            cmdTop2.Visible = true;
            cmdTop3.Visible = true;
            cmdTop4.Visible = true;
        }

        private void cmdTop1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Vendedores_Productos_No_Vendidos", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Usuario");
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

            lblRubro.Visible = false;
            cmdRubro.Visible = false;
            cboRubro.Visible = false;
            cboRubro.Enabled = true;
        }

        private void cmdTop3_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("ROAD_TO_PROYECTO.Cantidad_Facturas_Vendedores", db.Connection);
            cmd.Parameters.AddWithValue("@Trimestre", SqlDbType.Int).Value = (indexTrimestreSeleccionado+1);
            cmd.Parameters.AddWithValue("@Año", SqlDbType.Int).Value = anio;
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Usuario");
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

            lblRubro.Visible = false;
            cmdRubro.Visible = false;
            cboRubro.Visible = false;
            cboRubro.Enabled = true;
        }

        private void cmdVerOtro_Click(object sender, EventArgs e)
        {
          
            txtAnio.Enabled = true;
            txtAnio.Text = "";

            cboTrim.Enabled = true;
            cboTrim.SelectedIndex = -1;
            cboTrim.Visible = false;
            cmdTrimestre.Visible = false;
            lblTrim.Visible = false;

            lblTopp.Visible = false;
            cmdTop1.Visible = false;
            cmdTop2.Visible = false;
            cmdTop3.Visible = false;
            cmdTop4.Visible = false;

            lblRubro.Visible = false;
            cmdRubro.Visible = false;
            cboRubro.Visible = false;
            cboRubro.Enabled = true;

            
        }

        private void cmdTop4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Monto_Facturado_Vendedor", db.Connection);
            cmd.Parameters.AddWithValue("@Trimestre", SqlDbType.Int).Value = (indexTrimestreSeleccionado+1);
            cmd.Parameters.AddWithValue("@Año", SqlDbType.Int).Value = anio;
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Usuario");
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

            lblRubro.Visible = false;
            cmdRubro.Visible = false;
            cboRubro.Visible = false;
            cboRubro.Enabled = true;
        }

        private void cmdTop2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un Rubro", "Sr.Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            lblRubro.Visible = true;
            cmdRubro.Visible = true;
            cboRubro.Visible = true;

            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.ListaRubros", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                cboRubro.Items.Add(sdr["DescripLarga"].ToString());
            }

            cboRubro.ValueMember = cboRubro.DisplayMember;
        }

        private void cmdRubro_Click(object sender, EventArgs e)
        {
            rubroElegido = cboRubro.SelectedItem.ToString();
            cboRubro.Enabled = false;

            cmd = new SqlCommand("ROAD_TO_PROYECTO.Clientes_Productos_Comprados", db.Connection);
            cmd.Parameters.AddWithValue("@Trimestre", SqlDbType.Int).Value = (indexTrimestreSeleccionado + 1);
            cmd.Parameters.AddWithValue("@Año", SqlDbType.Int).Value = anio;
            cmd.Parameters.AddWithValue("@RubroDesc", SqlDbType.NVarChar).Value = rubroElegido;
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Usuario");
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
    }
}
