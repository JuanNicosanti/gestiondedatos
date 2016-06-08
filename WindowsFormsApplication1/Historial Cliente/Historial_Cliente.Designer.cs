namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class Historial_Cliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmdVerHistorial = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.cmdPrimera = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdUltima = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPagina = new System.Windows.Forms.Label();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 175);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 248);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(946, 197);
            this.dataGridView2.TabIndex = 3;
            // 
            // cmdVerHistorial
            // 
            this.cmdVerHistorial.Location = new System.Drawing.Point(52, 202);
            this.cmdVerHistorial.Name = "cmdVerHistorial";
            this.cmdVerHistorial.Size = new System.Drawing.Size(205, 43);
            this.cmdVerHistorial.TabIndex = 4;
            this.cmdVerHistorial.Text = "Ver historial del cliente seleccionado";
            this.cmdVerHistorial.UseVisualStyleBackColor = true;
            this.cmdVerHistorial.Click += new System.EventHandler(this.cmdVerHistorial_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(379, 204);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(205, 41);
            this.cmdLimpiar.TabIndex = 5;
            this.cmdLimpiar.Text = "Limpiar Busqueda";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(696, 203);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(205, 41);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AllowDrop = true;
            this.lblPaginaActual.BackColor = System.Drawing.Color.LightGray;
            this.lblPaginaActual.Location = new System.Drawing.Point(-3, 445);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(949, 62);
            this.lblPaginaActual.TabIndex = 7;
            // 
            // cmdPrimera
            // 
            this.cmdPrimera.Location = new System.Drawing.Point(184, 451);
            this.cmdPrimera.Name = "cmdPrimera";
            this.cmdPrimera.Size = new System.Drawing.Size(126, 23);
            this.cmdPrimera.TabIndex = 8;
            this.cmdPrimera.Text = "Primera pagina";
            this.cmdPrimera.UseVisualStyleBackColor = true;
            this.cmdPrimera.Click += new System.EventHandler(this.cmdPrimera_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(361, 451);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(131, 23);
            this.cmdAnterior.TabIndex = 9;
            this.cmdAnterior.Text = "Pagina anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(536, 451);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(131, 23);
            this.cmdSiguiente.TabIndex = 10;
            this.cmdSiguiente.Text = "Pagina siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdUltima
            // 
            this.cmdUltima.Location = new System.Drawing.Point(696, 451);
            this.cmdUltima.Name = "cmdUltima";
            this.cmdUltima.Size = new System.Drawing.Size(126, 23);
            this.cmdUltima.TabIndex = 11;
            this.cmdUltima.Text = "Ultima pagina";
            this.cmdUltima.UseVisualStyleBackColor = true;
            this.cmdUltima.Click += new System.EventHandler(this.cmdUltima_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "/";
            // 
            // lblTotalPagina
            // 
            this.lblTotalPagina.AutoSize = true;
            this.lblTotalPagina.BackColor = System.Drawing.Color.LightGray;
            this.lblTotalPagina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagina.Location = new System.Drawing.Point(458, 490);
            this.lblTotalPagina.Name = "lblTotalPagina";
            this.lblTotalPagina.Size = new System.Drawing.Size(46, 16);
            this.lblTotalPagina.TabIndex = 14;
            this.lblTotalPagina.Text = "label4";
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.BackColor = System.Drawing.Color.LightGray;
            this.lblCantidadTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTotal.Location = new System.Drawing.Point(721, 492);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(41, 13);
            this.lblCantidadTotal.TabIndex = 15;
            this.lblCantidadTotal.Text = "label5";
            // 
            // Historial_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(946, 531);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.lblTotalPagina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdUltima);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.cmdPrimera);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdVerHistorial);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Historial_Cliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Historial_Cliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button cmdVerHistorial;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Button cmdPrimera;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdUltima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPagina;
        private System.Windows.Forms.Label lblCantidadTotal;
    }
}