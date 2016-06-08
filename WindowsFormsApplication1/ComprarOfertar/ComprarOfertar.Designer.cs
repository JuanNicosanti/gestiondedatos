namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class ComprarOfertar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdPrimera = new System.Windows.Forms.Button();
            this.cmdProxima = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdUltima = new System.Windows.Forms.Button();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.lblTotalPagina = new System.Windows.Forms.Label();
            this.lstRubros = new System.Windows.Forms.ListBox();
            this.cmdSeleccionarRubro = new System.Windows.Forms.Button();
            this.lstRubrosElegidos = new System.Windows.Forms.ListBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdBorrarFiltro = new System.Windows.Forms.Button();
            this.cmdComprarOfertar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 350);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar publicaciones";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 231);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rubro";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(35, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 68);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(35, 402);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(210, 23);
            this.cmdBuscar.TabIndex = 5;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click_1);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(326, 402);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(210, 23);
            this.cmdLimpiar.TabIndex = 6;
            this.cmdLimpiar.Text = "Limpiar Busqueda";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(628, 402);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(210, 23);
            this.cmdVolver.TabIndex = 7;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 279);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(340, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(519, 68);
            this.label4.TabIndex = 13;
            // 
            // cmdPrimera
            // 
            this.cmdPrimera.Location = new System.Drawing.Point(371, 328);
            this.cmdPrimera.Name = "cmdPrimera";
            this.cmdPrimera.Size = new System.Drawing.Size(99, 23);
            this.cmdPrimera.TabIndex = 14;
            this.cmdPrimera.Text = "Primera pagina";
            this.cmdPrimera.UseVisualStyleBackColor = true;
            this.cmdPrimera.Click += new System.EventHandler(this.cmdPrimera_Click_1);
            // 
            // cmdProxima
            // 
            this.cmdProxima.Location = new System.Drawing.Point(618, 328);
            this.cmdProxima.Name = "cmdProxima";
            this.cmdProxima.Size = new System.Drawing.Size(99, 23);
            this.cmdProxima.TabIndex = 15;
            this.cmdProxima.Text = "Proxima pagina";
            this.cmdProxima.UseVisualStyleBackColor = true;
            this.cmdProxima.Click += new System.EventHandler(this.cmdProxima_Click_1);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(497, 328);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(99, 23);
            this.cmdAnterior.TabIndex = 16;
            this.cmdAnterior.Text = "Pagina anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click_1);
            // 
            // cmdUltima
            // 
            this.cmdUltima.Location = new System.Drawing.Point(739, 328);
            this.cmdUltima.Name = "cmdUltima";
            this.cmdUltima.Size = new System.Drawing.Size(99, 23);
            this.cmdUltima.TabIndex = 17;
            this.cmdUltima.Text = "Ultima pagina";
            this.cmdUltima.UseVisualStyleBackColor = true;
            this.cmdUltima.Click += new System.EventHandler(this.cmdUltima_Click_1);
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.BackColor = System.Drawing.Color.LightGray;
            this.lblCantidadTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTotal.Location = new System.Drawing.Point(665, 367);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadTotal.TabIndex = 18;
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.BackColor = System.Drawing.Color.LightGray;
            this.lblPaginaActual.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaActual.Location = new System.Drawing.Point(574, 359);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(0, 16);
            this.lblPaginaActual.TabIndex = 19;
            // 
            // lblTotalPagina
            // 
            this.lblTotalPagina.AutoSize = true;
            this.lblTotalPagina.BackColor = System.Drawing.Color.LightGray;
            this.lblTotalPagina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagina.Location = new System.Drawing.Point(611, 359);
            this.lblTotalPagina.Name = "lblTotalPagina";
            this.lblTotalPagina.Size = new System.Drawing.Size(0, 16);
            this.lblTotalPagina.TabIndex = 20;
            // 
            // lstRubros
            // 
            this.lstRubros.FormattingEnabled = true;
            this.lstRubros.Location = new System.Drawing.Point(32, 77);
            this.lstRubros.Name = "lstRubros";
            this.lstRubros.Size = new System.Drawing.Size(213, 69);
            this.lstRubros.TabIndex = 21;
            // 
            // cmdSeleccionarRubro
            // 
            this.cmdSeleccionarRubro.Location = new System.Drawing.Point(96, 152);
            this.cmdSeleccionarRubro.Name = "cmdSeleccionarRubro";
            this.cmdSeleccionarRubro.Size = new System.Drawing.Size(75, 23);
            this.cmdSeleccionarRubro.TabIndex = 22;
            this.cmdSeleccionarRubro.Text = "Seleccionar";
            this.cmdSeleccionarRubro.UseVisualStyleBackColor = true;
            this.cmdSeleccionarRubro.Click += new System.EventHandler(this.cmdSeleccionarRubro_Click);
            // 
            // lstRubrosElegidos
            // 
            this.lstRubrosElegidos.FormattingEnabled = true;
            this.lstRubrosElegidos.Location = new System.Drawing.Point(32, 181);
            this.lstRubrosElegidos.Name = "lstRubrosElegidos";
            this.lstRubrosElegidos.Size = new System.Drawing.Size(213, 69);
            this.lstRubrosElegidos.TabIndex = 23;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(62, 329);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "/";
            // 
            // cmdBorrarFiltro
            // 
            this.cmdBorrarFiltro.Location = new System.Drawing.Point(96, 256);
            this.cmdBorrarFiltro.Name = "cmdBorrarFiltro";
            this.cmdBorrarFiltro.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrarFiltro.TabIndex = 26;
            this.cmdBorrarFiltro.Text = "Borrar filtro";
            this.cmdBorrarFiltro.UseVisualStyleBackColor = true;
            this.cmdBorrarFiltro.Click += new System.EventHandler(this.cmdBorrarFiltro_Click);
            // 
            // cmdComprarOfertar
            // 
            this.cmdComprarOfertar.Location = new System.Drawing.Point(340, 445);
            this.cmdComprarOfertar.Name = "cmdComprarOfertar";
            this.cmdComprarOfertar.Size = new System.Drawing.Size(519, 23);
            this.cmdComprarOfertar.TabIndex = 27;
            this.cmdComprarOfertar.Text = "COMPRAR/OFERTAR";
            this.cmdComprarOfertar.UseVisualStyleBackColor = true;
            this.cmdComprarOfertar.Click += new System.EventHandler(this.cmdComprarOfertar_Click);
            // 
            // ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(881, 502);
            this.Controls.Add(this.cmdComprarOfertar);
            this.Controls.Add(this.cmdBorrarFiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lstRubrosElegidos);
            this.Controls.Add(this.cmdSeleccionarRubro);
            this.Controls.Add(this.lstRubros);
            this.Controls.Add(this.lblTotalPagina);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.cmdUltima);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.cmdProxima);
            this.Controls.Add(this.cmdPrimera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ComprarOfertar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ComprarOfertar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdPrimera;
        private System.Windows.Forms.Button cmdProxima;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdUltima;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Label lblTotalPagina;
        private System.Windows.Forms.ListBox lstRubros;
        private System.Windows.Forms.Button cmdSeleccionarRubro;
        private System.Windows.Forms.ListBox lstRubrosElegidos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdBorrarFiltro;
        private System.Windows.Forms.Button cmdComprarOfertar;
    }
}