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
        public int esAltaRol = 1;
        public AltaRol()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        public void cargarFuncionalidadesElegidasDeDeterminadoRol(int idRol)
        {
            cmd = new SqlCommand("ROAD_TO_PROYECTO.FuncionesDeUnRol", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Rol", SqlDbType.Int).Value = idRol;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lstFuncElegidas.Items.Add(sdr["Descripcion"].ToString());
            }
            lstFuncElegidas.ValueMember = lstFuncElegidas.DisplayMember;
         
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
            if (esAltaRol == 1)
            {
                lstFuncElegidas.Items.Clear();
            }
            

            timer1.Start();
           

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
            if (lstFuncElegidas.Items.Count == 0)
            {
                MessageBox.Show("Debe elegir al menos una funcionalidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (esAltaRol == 1)
            {
                SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.AltaRol", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = txtNuevoRol.Text;
                cmd.ExecuteNonQuery();
                txtNuevoRol.Text = "";

                for (int i = 0; i < lstFuncElegidas.Items.Count; i++)
                {
                    string unaFunc = lstFuncElegidas.Items[i].ToString();
                    SqlCommand cmd2 = new SqlCommand("ROAD_TO_PROYECTO.AsignarFuncionARol", db.Connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@Rol", SqlDbType.NVarChar).Value = nuevoRol;
                    cmd2.Parameters.AddWithValue("@Funcion", SqlDbType.NVarChar).Value = unaFunc;
                    cmd2.ExecuteNonQuery();
                }
            }
            if (esAltaRol == 0)
            {
            }

            
            lstFuncElegidas.Items.Clear();
            


        }

        private void lstFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            lstFuncElegidas.Items.Clear();
            txtNuevoRol.Text = "";
        }

        private void cmdVolver_Click_1(object sender, EventArgs e)
        {
            if (esAltaRol == 1) {
                Form1.f1.Show();
                this.Hide();
            }
            if (esAltaRol == 0) {
                ModificacionRol mRol = new ModificacionRol();
                mRol.Show();
                this.Hide();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void lstFuncElegidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdBorrarUnaFunc_Click(object sender, EventArgs e)
        {
            lstFuncElegidas.Items.RemoveAt(lstFuncElegidas.SelectedIndex);
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstFuncElegidas.Items.Count; i++)
            {
                if (lstFuncElegidas.Items[i].ToString().Equals(lstFuncionalidades.SelectedValue.ToString()))
                {
                    MessageBox.Show("Ya ha seleccionado esa funcionalidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }                
            }
           
             lstFuncElegidas.Items.Add(lstFuncionalidades.SelectedValue.ToString());     
        }

      
     
    }
}
