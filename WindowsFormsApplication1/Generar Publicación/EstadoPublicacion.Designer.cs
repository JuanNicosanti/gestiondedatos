﻿namespace WindowsFormsApplication1.Generar_Publicación
{
    partial class EstadoPublicacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPublis = new System.Windows.Forms.DataGridView();
            this.cmdActivar = new System.Windows.Forms.Button();
            this.cmdPausar = new System.Windows.Forms.Button();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPublis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdBuscar);
            this.panel1.Controls.Add(this.cboEstados);
            this.panel1.Controls.Add(this.tbDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 78);
            this.panel1.TabIndex = 0;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(295, 50);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(139, 29);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(127, 21);
            this.cboEstados.TabIndex = 3;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(159, 1);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(211, 20);
            this.tbDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado de la publicación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción de la publicación:";
            // 
            // dgPublis
            // 
            this.dgPublis.AllowUserToAddRows = false;
            this.dgPublis.AllowUserToDeleteRows = false;
            this.dgPublis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPublis.Location = new System.Drawing.Point(20, 123);
            this.dgPublis.Name = "dgPublis";
            this.dgPublis.ReadOnly = true;
            this.dgPublis.Size = new System.Drawing.Size(445, 150);
            this.dgPublis.TabIndex = 1;
            this.dgPublis.Visible = false;
            this.dgPublis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPublis_CellContentClick);
            // 
            // cmdActivar
            // 
            this.cmdActivar.Location = new System.Drawing.Point(20, 292);
            this.cmdActivar.Name = "cmdActivar";
            this.cmdActivar.Size = new System.Drawing.Size(116, 23);
            this.cmdActivar.TabIndex = 2;
            this.cmdActivar.Text = "Activar publicación";
            this.cmdActivar.UseVisualStyleBackColor = true;
            this.cmdActivar.Visible = false;
            // 
            // cmdPausar
            // 
            this.cmdPausar.Location = new System.Drawing.Point(193, 292);
            this.cmdPausar.Name = "cmdPausar";
            this.cmdPausar.Size = new System.Drawing.Size(105, 23);
            this.cmdPausar.TabIndex = 3;
            this.cmdPausar.Text = "Pausar publicación";
            this.cmdPausar.UseVisualStyleBackColor = true;
            this.cmdPausar.Visible = false;
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.Location = new System.Drawing.Point(353, 292);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(112, 23);
            this.cmdFinalizar.TabIndex = 4;
            this.cmdFinalizar.Text = "Finalizar publicación";
            this.cmdFinalizar.UseVisualStyleBackColor = true;
            this.cmdFinalizar.Visible = false;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(387, 332);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 5;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // EstadoPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 367);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdFinalizar);
            this.Controls.Add(this.cmdPausar);
            this.Controls.Add(this.cmdActivar);
            this.Controls.Add(this.dgPublis);
            this.Controls.Add(this.panel1);
            this.Name = "EstadoPublicacion";
            this.Text = "EstadoPublicacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPublis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPublis;
        private System.Windows.Forms.Button cmdActivar;
        private System.Windows.Forms.Button cmdPausar;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.Button cmdVolver;
    }
}