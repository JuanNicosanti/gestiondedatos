﻿using System;
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
    public partial class BusquedaVisibilidad : Form
    {
        SqlCommand cmd;
        SqlDataReader sdr;
        SqlDataAdapter adapter;
        private DataBase db;
        public int fila;
        
        public BusquedaVisibilidad()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void BusquedaVisibilidad_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int comiFija;
            if (string.IsNullOrEmpty(tbComiFija.Text)) { 
                comiFija = int.MaxValue;
            } else {
                comiFija = int.Parse(tbComiFija.Text);
            }
            cmd = new SqlCommand("ROAD_TO_PROYECTO.Lista_Visibilidades", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = tbDescripcion.Text;
            cmd.Parameters.AddWithValue("@ComiFija", SqlDbType.Int).Value = comiFija;

            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ROAD_TO_PROYECTO.Visibilidad");
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

            panelResultados.Visible = true;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.ModificarVisibilidad modVisibilidad = new WindowsFormsApplication1.ABM_Visibilidad.ModificarVisibilidad();
            WindowsFormsApplication1.ABM_Visibilidad.ModificarVisibilidad.modVis.tbDescripcion.Text = dataGridView1[1, fila].Value.ToString();
            WindowsFormsApplication1.ABM_Visibilidad.ModificarVisibilidad.modVis.tbComiFija.Text = dataGridView1[2, fila].Value.ToString();
            WindowsFormsApplication1.ABM_Visibilidad.ModificarVisibilidad.modVis.tbComiVariable.Text = dataGridView1[3, fila].Value.ToString();
            WindowsFormsApplication1.ABM_Visibilidad.ModificarVisibilidad.modVis.tbEnvio.Text = dataGridView1[4, fila].Value.ToString();
            WindowsFormsApplication1.ABM_Visibilidad.ModificarVisibilidad.modVis.visiId = (int)dataGridView1[0, fila].Value;
            modVisibilidad.Show();
            this.Hide();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una Visibilidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            fila = dataGridView1.CurrentRow.Index;
            int celdaIdVis = (int)dataGridView1[0, fila].Value;

            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Eliminar_Visibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VisiId", SqlDbType.Int).Value = celdaIdVis;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Elemento borrado", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            panelResultados.Visible = false;
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Visibilidad.ABMVisibilidad.abmVis.Show();
            this.Close();
        }

        private void cmdLimpiarFiltros_Click(object sender, EventArgs e)
        {
            tbDescripcion.Text = "";
            tbComiFija.Text = "";
        }
    }
}
