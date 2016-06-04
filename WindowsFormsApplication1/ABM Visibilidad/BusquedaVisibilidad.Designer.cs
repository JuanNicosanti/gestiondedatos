namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class BusquedaVisibilidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbComiFija = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdLimpiarFiltros = new System.Windows.Forms.Button();
            this.panelFiltros.SuspendLayout();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.cmdLimpiarFiltros);
            this.panelFiltros.Controls.Add(this.cmdBuscar);
            this.panelFiltros.Controls.Add(this.tbComiFija);
            this.panelFiltros.Controls.Add(this.tbDescripcion);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Location = new System.Drawing.Point(12, 12);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(430, 88);
            this.panelFiltros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre de la visibilidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comisión por publicación menor a:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(177, 6);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 2;
            // 
            // tbComiFija
            // 
            this.tbComiFija.Location = new System.Drawing.Point(177, 38);
            this.tbComiFija.Name = "tbComiFija";
            this.tbComiFija.Size = new System.Drawing.Size(100, 20);
            this.tbComiFija.TabIndex = 3;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(321, 4);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // panelResultados
            // 
            this.panelResultados.Controls.Add(this.cmdEliminar);
            this.panelResultados.Controls.Add(this.cmdModificar);
            this.panelResultados.Controls.Add(this.dataGridView1);
            this.panelResultados.Location = new System.Drawing.Point(12, 123);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(450, 195);
            this.panelResultados.TabIndex = 5;
            this.panelResultados.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(431, 149);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(71, 165);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(124, 23);
            this.cmdModificar.TabIndex = 1;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(272, 165);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(124, 23);
            this.cmdEliminar.TabIndex = 2;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(367, 317);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdLimpiarFiltros
            // 
            this.cmdLimpiarFiltros.Location = new System.Drawing.Point(321, 36);
            this.cmdLimpiarFiltros.Name = "cmdLimpiarFiltros";
            this.cmdLimpiarFiltros.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiarFiltros.TabIndex = 5;
            this.cmdLimpiarFiltros.Text = "Limpiar";
            this.cmdLimpiarFiltros.UseVisualStyleBackColor = true;
            this.cmdLimpiarFiltros.Click += new System.EventHandler(this.cmdLimpiarFiltros_Click);
            // 
            // BusquedaVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 349);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.panelFiltros);
            this.Name = "BusquedaVisibilidad";
            this.Text = "BusquedaVisibilidad";
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox tbComiFija;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdLimpiarFiltros;

    }
}