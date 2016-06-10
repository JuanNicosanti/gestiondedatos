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
        private int indexTrimestreSeleccionado;

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
        }

        private void cmdAnio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                MessageBox.Show("Ingrese un año", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
               
            }
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
            lblTopp.Visible = true;
            cmdTop1.Visible = true;
            cmdTop2.Visible = true;
            cmdTop3.Visible = true;
            cmdTop4.Visible = true;
        }
    }
}
