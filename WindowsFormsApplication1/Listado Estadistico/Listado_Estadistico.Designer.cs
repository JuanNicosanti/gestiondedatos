namespace WindowsFormsApplication1.Listado_Estadistico
{
    partial class Listado_Estadistico
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
            this.lblTopp = new System.Windows.Forms.Label();
            this.cmdTop1 = new System.Windows.Forms.Button();
            this.cmdTop2 = new System.Windows.Forms.Button();
            this.cmdTop3 = new System.Windows.Forms.Button();
            this.cmdTop4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cmdAnio = new System.Windows.Forms.Button();
            this.lblTrim = new System.Windows.Forms.Label();
            this.cmdTrimestre = new System.Windows.Forms.Button();
            this.cboTrim = new System.Windows.Forms.ComboBox();
            this.cmdVerOtro = new System.Windows.Forms.Button();
            this.lblRubro = new System.Windows.Forms.Label();
            this.cmdRubro = new System.Windows.Forms.Button();
            this.cboRubro = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTopp
            // 
            this.lblTopp.AllowDrop = true;
            this.lblTopp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopp.Location = new System.Drawing.Point(0, 182);
            this.lblTopp.Name = "lblTopp";
            this.lblTopp.Size = new System.Drawing.Size(282, 245);
            this.lblTopp.TabIndex = 2;
            this.lblTopp.Text = "Ver TOP5";
            // 
            // cmdTop1
            // 
            this.cmdTop1.Location = new System.Drawing.Point(11, 214);
            this.cmdTop1.Name = "cmdTop1";
            this.cmdTop1.Size = new System.Drawing.Size(261, 43);
            this.cmdTop1.TabIndex = 3;
            this.cmdTop1.Text = "Vendedores con mayor cantidad de productos no vendidos";
            this.cmdTop1.UseVisualStyleBackColor = true;
            this.cmdTop1.Click += new System.EventHandler(this.cmdTop1_Click);
            // 
            // cmdTop2
            // 
            this.cmdTop2.Location = new System.Drawing.Point(11, 263);
            this.cmdTop2.Name = "cmdTop2";
            this.cmdTop2.Size = new System.Drawing.Size(261, 43);
            this.cmdTop2.TabIndex = 4;
            this.cmdTop2.Text = " Clientes con mayor cantidad de productos comprados";
            this.cmdTop2.UseVisualStyleBackColor = true;
            this.cmdTop2.Click += new System.EventHandler(this.cmdTop2_Click);
            // 
            // cmdTop3
            // 
            this.cmdTop3.Location = new System.Drawing.Point(11, 312);
            this.cmdTop3.Name = "cmdTop3";
            this.cmdTop3.Size = new System.Drawing.Size(261, 43);
            this.cmdTop3.TabIndex = 5;
            this.cmdTop3.Text = "Vendedores con mayor cantidad de facturas";
            this.cmdTop3.UseVisualStyleBackColor = true;
            this.cmdTop3.Click += new System.EventHandler(this.cmdTop3_Click);
            // 
            // cmdTop4
            // 
            this.cmdTop4.Location = new System.Drawing.Point(11, 361);
            this.cmdTop4.Name = "cmdTop4";
            this.cmdTop4.Size = new System.Drawing.Size(261, 43);
            this.cmdTop4.TabIndex = 6;
            this.cmdTop4.Text = "Vendedores con mayor monto facturado";
            this.cmdTop4.UseVisualStyleBackColor = true;
            this.cmdTop4.Click += new System.EventHandler(this.cmdTop4_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 134);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese:";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(580, 260);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(237, 164);
            this.cmdVolver.TabIndex = 8;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 225);
            this.dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(61, 55);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 11;
            // 
            // cmdAnio
            // 
            this.cmdAnio.Location = new System.Drawing.Point(167, 53);
            this.cmdAnio.Name = "cmdAnio";
            this.cmdAnio.Size = new System.Drawing.Size(105, 23);
            this.cmdAnio.TabIndex = 12;
            this.cmdAnio.Text = "Aceptar";
            this.cmdAnio.UseVisualStyleBackColor = true;
            this.cmdAnio.Click += new System.EventHandler(this.cmdAnio_Click);
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(5, 85);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(50, 13);
            this.lblTrim.TabIndex = 13;
            this.lblTrim.Text = "Trimeste:";
            // 
            // cmdTrimestre
            // 
            this.cmdTrimestre.Location = new System.Drawing.Point(167, 83);
            this.cmdTrimestre.Name = "cmdTrimestre";
            this.cmdTrimestre.Size = new System.Drawing.Size(105, 23);
            this.cmdTrimestre.TabIndex = 14;
            this.cmdTrimestre.Text = "Aceptar";
            this.cmdTrimestre.UseVisualStyleBackColor = true;
            this.cmdTrimestre.Click += new System.EventHandler(this.cmdTrimestre_Click);
            // 
            // cboTrim
            // 
            this.cboTrim.FormattingEnabled = true;
            this.cboTrim.Items.AddRange(new object[] {
            "ENE-FEB-MAR",
            "ABR-MAY-JUN",
            "JUL-AGO-SEP",
            "OCT-NOV-DIC"});
            this.cboTrim.Location = new System.Drawing.Point(61, 82);
            this.cboTrim.Name = "cboTrim";
            this.cboTrim.Size = new System.Drawing.Size(100, 21);
            this.cboTrim.TabIndex = 15;
            // 
            // cmdVerOtro
            // 
            this.cmdVerOtro.Location = new System.Drawing.Point(296, 260);
            this.cmdVerOtro.Name = "cmdVerOtro";
            this.cmdVerOtro.Size = new System.Drawing.Size(268, 164);
            this.cmdVerOtro.TabIndex = 16;
            this.cmdVerOtro.Text = "Cambiar informacion de busqueda";
            this.cmdVerOtro.UseVisualStyleBackColor = true;
            this.cmdVerOtro.Click += new System.EventHandler(this.cmdVerOtro_Click);
            // 
            // lblRubro
            // 
            this.lblRubro.AllowDrop = true;
            this.lblRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRubro.Location = new System.Drawing.Point(12, 106);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(260, 51);
            this.lblRubro.TabIndex = 17;
            this.lblRubro.Text = "Rubro:";
            // 
            // cmdRubro
            // 
            this.cmdRubro.Location = new System.Drawing.Point(166, 122);
            this.cmdRubro.Name = "cmdRubro";
            this.cmdRubro.Size = new System.Drawing.Size(105, 23);
            this.cmdRubro.TabIndex = 18;
            this.cmdRubro.Text = "Aceptar";
            this.cmdRubro.UseVisualStyleBackColor = true;
            this.cmdRubro.Click += new System.EventHandler(this.cmdRubro_Click);
            // 
            // cboRubro
            // 
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.Location = new System.Drawing.Point(61, 124);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(100, 21);
            this.cboRubro.TabIndex = 19;
            // 
            // Listado_Estadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(827, 482);
            this.Controls.Add(this.cboRubro);
            this.Controls.Add(this.cmdRubro);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.cmdVerOtro);
            this.Controls.Add(this.cboTrim);
            this.Controls.Add(this.cmdTrimestre);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.cmdAnio);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdTop4);
            this.Controls.Add(this.cmdTop3);
            this.Controls.Add(this.cmdTop2);
            this.Controls.Add(this.cmdTop1);
            this.Controls.Add(this.lblTopp);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Listado_Estadistico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Listado_Estadistico_Load);
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
        private System.Windows.Forms.Label lblTopp;
        private System.Windows.Forms.Button cmdTop1;
        private System.Windows.Forms.Button cmdTop2;
        private System.Windows.Forms.Button cmdTop3;
        private System.Windows.Forms.Button cmdTop4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button cmdAnio;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Button cmdTrimestre;
        private System.Windows.Forms.ComboBox cboTrim;
        private System.Windows.Forms.Button cmdVerOtro;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Button cmdRubro;
        private System.Windows.Forms.ComboBox cboRubro;
    }
}