using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class Facturar : Form
    {
        public int factId;
        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            
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
    }
}
