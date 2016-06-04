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

        private void cmdBuscarVis_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad searchVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.BusquedaVisibilidad();
            searchVisibilidad.Show();
            this.Hide();
        }

        private void ABMVisibilidad_Load(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1.f1.Show();
            this.Hide();
        }
    }
}
