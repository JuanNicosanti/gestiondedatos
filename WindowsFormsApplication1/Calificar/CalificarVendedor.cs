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
    public partial class CalificarVendedor : Form
    {
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        public string user;
        public int calificacion;
        public int transId;
        public static CalificarVendedor calif;

        public CalificarVendedor()
        {
            InitializeComponent();
        }

        private void CalificarVendedor_Load(object sender, EventArgs e)
        {           
            cargarComboBox();
        }

        public void cargarComboBox() //Traigo las publicaciones que puede calificar
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Transacciones_Sin_Calificar", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@UserId", SqlDbType.NVarChar).Value = user;

            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Publicacion");
            adapter.Fill(dt);
            this.cboCalif.DataSource = dt;
            this.cboCalif.DisplayMember = "Descripcion";

            cboCalif.ValueMember = cboCalif.DisplayMember;
            cboCalif.SelectedIndex = -1;
            cboCalif.Text = "Seleccione una publicación";

            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                transId = (int)sdr["TranId"];
            }
            sdr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCalif.SelectedIndex != -1)
            {
                panelCalificaciones.Visible = true;
            }
        }

        private void cmdCalificar_Click(object sender, EventArgs e)
        {
            if (rb1.Checked) calificacion = 1;
            else if (rb2.Checked) calificacion = 2;
            else if (rb3.Checked) calificacion = 3;
            else if (rb4.Checked) calificacion = 4;
            else if (rb5.Checked) calificacion = 5;
            else {
                MessageBox.Show("Debe ingresar una calificación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            cmd = new SqlCommand("ROAD_TO_PROYECTO.Calificar_Transaccion", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TranId", SqlDbType.Int).Value = transId;
            cmd.Parameters.AddWithValue("@CantidadEstrellas", SqlDbType.Int).Value = calificacion;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = cboCalif.SelectedValue.ToString();
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Publicación calificada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void panelCalificaciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
