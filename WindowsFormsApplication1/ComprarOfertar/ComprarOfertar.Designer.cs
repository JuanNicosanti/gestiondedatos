﻿namespace WindowsFormsApplication1.ComprarOfertar
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salirToolStripMenuItem.Text = "Salir";
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
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 79);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rubro";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(35, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 105);
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
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(326, 402);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(210, 23);
            this.cmdLimpiar.TabIndex = 6;
            this.cmdLimpiar.Text = "Limpiar Busqueda";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(628, 402);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(210, 23);
            this.cmdVolver.TabIndex = 7;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
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
            this.cmdPrimera.Location = new System.Drawing.Point(371, 341);
            this.cmdPrimera.Name = "cmdPrimera";
            this.cmdPrimera.Size = new System.Drawing.Size(99, 23);
            this.cmdPrimera.TabIndex = 14;
            this.cmdPrimera.Text = "Primera pagina";
            this.cmdPrimera.UseVisualStyleBackColor = true;
            // 
            // cmdProxima
            // 
            this.cmdProxima.Location = new System.Drawing.Point(618, 341);
            this.cmdProxima.Name = "cmdProxima";
            this.cmdProxima.Size = new System.Drawing.Size(99, 23);
            this.cmdProxima.TabIndex = 15;
            this.cmdProxima.Text = "Proxima pagina";
            this.cmdProxima.UseVisualStyleBackColor = true;
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(497, 341);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(99, 23);
            this.cmdAnterior.TabIndex = 16;
            this.cmdAnterior.Text = "Pagina anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            // 
            // cmdUltima
            // 
            this.cmdUltima.Location = new System.Drawing.Point(739, 341);
            this.cmdUltima.Name = "cmdUltima";
            this.cmdUltima.Size = new System.Drawing.Size(99, 23);
            this.cmdUltima.TabIndex = 17;
            this.cmdUltima.Text = "Ultima pagina";
            this.cmdUltima.UseVisualStyleBackColor = true;
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(889, 62);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(35, 13);
            this.lblCantidadTotal.TabIndex = 18;
            this.lblCantidadTotal.Text = "label5";
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Location = new System.Drawing.Point(892, 106);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(35, 13);
            this.lblPaginaActual.TabIndex = 19;
            this.lblPaginaActual.Text = "label6";
            // 
            // lblTotalPagina
            // 
            this.lblTotalPagina.AutoSize = true;
            this.lblTotalPagina.Location = new System.Drawing.Point(892, 159);
            this.lblTotalPagina.Name = "lblTotalPagina";
            this.lblTotalPagina.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPagina.TabIndex = 20;
            this.lblTotalPagina.Text = "label7";
            // 
            // ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(946, 471);
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
    }
}