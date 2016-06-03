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
    public partial class ABMVisibilidad : Form
    {
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        public static ABMVisibilidad abmVis;
        //public int visiId;

        public ABMVisibilidad()
        {
            InitializeComponent();
            ABMVisibilidad.abmVis = this;
            db = DataBase.GetInstance();
        }

        private void cmdCrearVis_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.AgregarVisibilidad newVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.AgregarVisibilidad();
            newVisibilidad.Show();
            this.Hide();
        }

        private void cmdModVis_Click(object sender, EventArgs e)
        {
            cmdEliminarVis.Visible = false;
            textBoxEnvio.Enabled = true;
            textBoxProd.Enabled = true;
            textBoxTipo.Enabled = true;
            cmdUpdateVis.Visible = true;
        }

        private void cmdEliminarVis_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Eliminar_Visibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = cboTipoVis.SelectedValue.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Elemento borrado", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            cargarComboBox();

            panelComs.Visible = false;
        }

        private void cmdBuscarVis_Click(object sender, EventArgs e)
        {
            cargarComboBox();
            //tbBusqueda.Visible = true;
            //cmdBuscarVisUnica.Visible = true;
            panelBusqueda.Visible = true;
        }

        private void cboTipoVis_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelComs.Visible = false;
            cmdModVis.Visible = false;
            cmdEliminarVis.Visible = false;
            if (cboTipoVis.SelectedIndex != -1)
            {
                cmdModVis.Visible = true;
                cmdEliminarVis.Visible = true;
                panelComs.Visible = true;

                cmd = new SqlCommand("ROAD_TO_PROYECTO.Comisiones_Valores", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Visibilidad", SqlDbType.NVarChar).Value = cboTipoVis.SelectedValue.ToString();

                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    textBoxTipo.Text = sdr["ComiFija"].ToString();
                    textBoxProd.Text = sdr["ComiVariable"].ToString();
                    textBoxEnvio.Text = sdr["ComiEnvio"].ToString();
                }
                sdr.Close();
            }
        }

        public void cargarComboBox() //Vuelvo a traer los valores de Visibilidad para actualizar el ComboBox
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Comisiones_Visibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Visibilidad");
            adapter.Fill(dt);
            this.cboTipoVis.DataSource = dt;
            this.cboTipoVis.DisplayMember = "Descripcion";

            cboTipoVis.ValueMember = cboTipoVis.DisplayMember;
            cboTipoVis.SelectedIndex = -1;
            cboTipoVis.Text = "Seleccione un tipo de visibilidad";
        }

        private void cmdUpdateVis_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Update_Visibilidad", db.Connection);
            //cmd = new SqlCommand("ROAD_TO_PROYECTO.Modificacion_Visibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@VisiId", SqlDbType.Int).Value = visiId;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = cboTipoVis.SelectedValue.ToString();
            //cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = tbBusqueda.Text;
            cmd.Parameters.AddWithValue("@ComiFija", SqlDbType.Int).Value = textBoxTipo.Text;
            cmd.Parameters.AddWithValue("@ComiVariable", SqlDbType.Int).Value = textBoxProd.Text;
            cmd.Parameters.AddWithValue("@ComiEnvio", SqlDbType.Int).Value = textBoxEnvio.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Elemento modificado", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            cargarComboBox();

            panelComs.Visible = false;
            cmdModVis.Visible = false;
            cmdEliminarVis.Visible = false;
            cmdUpdateVis.Visible = false;
            //tbBusqueda.Visible = false;
            //cmdBuscarVisUnica.Visible = false;
        }

        private void ABMVisibilidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdModVis.Visible = true;
            cmdEliminarVis.Visible = true;
            panelComs.Visible = true;

            cmd = new SqlCommand("ROAD_TO_PROYECTO.Buscar_Visibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = tbBusqueda.Text;
            
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                //visiId = int.Parse(sdr["VisiId"].ToString());
                lblBusqueda.Text = sdr["Descripcion"].ToString();
                textBoxTipo.Text = sdr["ComiFija"].ToString();
                textBoxProd.Text = sdr["ComiVariable"].ToString();
                textBoxEnvio.Text = sdr["ComiEnvio"].ToString();
            }
            sdr.Close();
            
        }
    }
}
