using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class AltaRol : Form
    {
       
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        public AltaRol()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.ListaFunciones", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Funcion");
            adapter.Fill(dt);
            this.lstFuncionalidades.DataSource = dt;
            this.lstFuncionalidades.DisplayMember = "Descripcion";
            
            lstFuncionalidades.ValueMember = lstFuncionalidades.DisplayMember;
            
            lstFuncElegidas.Items.Clear();

        }
        private void cmdVolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            String nuevoRol = txtNuevoRol.Text;
            if (string.IsNullOrEmpty(txtNuevoRol.Text))
            {
                MessageBox.Show("Debe completar el campo del nuevo Rol", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.AltaRol", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = txtNuevoRol.Text;
            cmd.ExecuteNonQuery();
            txtNuevoRol.Text = "";

            for (int i = 0; i < lstFuncElegidas.Items.Count - 1; i++)
            {
                string unaFunc = lstFuncElegidas.Items[i].ToString();
                SqlCommand cmd2 = new SqlCommand("ROAD_TO_PROYECTO.AsignarFuncionARol", db.Connection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@Rol", SqlDbType.NVarChar).Value = nuevoRol;
                cmd2.Parameters.AddWithValue("@Funcion", SqlDbType.NVarChar).Value = unaFunc;
                cmd2.ExecuteNonQuery();
            }
            


        }

        private void lstFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFuncElegidas.Items.Add(lstFuncionalidades.SelectedValue.ToString());
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            lstFuncElegidas.Items.Clear();
            txtNuevoRol.Text = "";
        }

        private void cmdVolver_Click_1(object sender, EventArgs e)
        {
            Form1.f1.Show();
            this.Hide();
        }

    }
}
