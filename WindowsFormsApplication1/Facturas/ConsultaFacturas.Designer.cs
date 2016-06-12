namespace WindowsFormsApplication1.Facturas
{
    partial class ConsultaFacturas
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
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFechaInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFechaFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbImporteMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImporteMaximo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbContenido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdVerFactura = new System.Windows.Forms.Button();
            this.panelBusqueda.SuspendLayout();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.label7);
            this.panelBusqueda.Controls.Add(this.cmdLimpiar);
            this.panelBusqueda.Controls.Add(this.cmdBuscar);
            this.panelBusqueda.Controls.Add(this.tbVendedor);
            this.panelBusqueda.Controls.Add(this.label6);
            this.panelBusqueda.Controls.Add(this.tbContenido);
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Controls.Add(this.tbImporteMaximo);
            this.panelBusqueda.Controls.Add(this.label4);
            this.panelBusqueda.Controls.Add(this.tbImporteMinimo);
            this.panelBusqueda.Controls.Add(this.label3);
            this.panelBusqueda.Controls.Add(this.tbFechaFinal);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Controls.Add(this.tbFechaInicial);
            this.panelBusqueda.Controls.Add(this.label1);
            this.panelBusqueda.Location = new System.Drawing.Point(13, 13);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(472, 111);
            this.panelBusqueda.TabIndex = 0;
            // 
            // panelResultados
            // 
            this.panelResultados.Controls.Add(this.dataGridView1);
            this.panelResultados.Location = new System.Drawing.Point(13, 130);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(472, 177);
            this.panelResultados.TabIndex = 1;
            this.panelResultados.Visible = false;
            this.panelResultados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultados_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha entre";
            // 
            // tbFechaInicial
            // 
            this.tbFechaInicial.Location = new System.Drawing.Point(85, 1);
            this.tbFechaInicial.Name = "tbFechaInicial";
            this.tbFechaInicial.Size = new System.Drawing.Size(100, 20);
            this.tbFechaInicial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "y";
            // 
            // tbFechaFinal
            // 
            this.tbFechaFinal.Location = new System.Drawing.Point(210, 1);
            this.tbFechaFinal.Name = "tbFechaFinal";
            this.tbFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.tbFechaFinal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Importe entre";
            // 
            // tbImporteMinimo
            // 
            this.tbImporteMinimo.Location = new System.Drawing.Point(85, 29);
            this.tbImporteMinimo.Name = "tbImporteMinimo";
            this.tbImporteMinimo.Size = new System.Drawing.Size(100, 20);
            this.tbImporteMinimo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "y";
            // 
            // tbImporteMaximo
            // 
            this.tbImporteMaximo.Location = new System.Drawing.Point(210, 29);
            this.tbImporteMaximo.Name = "tbImporteMaximo";
            this.tbImporteMaximo.Size = new System.Drawing.Size(100, 20);
            this.tbImporteMaximo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contenido de la factura";
            // 
            // tbContenido
            // 
            this.tbContenido.Location = new System.Drawing.Point(138, 57);
            this.tbContenido.Name = "tbContenido";
            this.tbContenido.Size = new System.Drawing.Size(172, 20);
            this.tbContenido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vendedor";
            // 
            // tbVendedor
            // 
            this.tbVendedor.Location = new System.Drawing.Point(74, 82);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(130, 20);
            this.tbVendedor.TabIndex = 11;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(369, 67);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 12;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(369, 29);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 13;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(466, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "(AAAA-MM-DD)";
            // 
            // cmdVerFactura
            // 
            this.cmdVerFactura.Location = new System.Drawing.Point(208, 313);
            this.cmdVerFactura.Name = "cmdVerFactura";
            this.cmdVerFactura.Size = new System.Drawing.Size(75, 23);
            this.cmdVerFactura.TabIndex = 2;
            this.cmdVerFactura.Text = "Ver factura";
            this.cmdVerFactura.UseVisualStyleBackColor = true;
            this.cmdVerFactura.Click += new System.EventHandler(this.cmdVerFactura_Click);
            // 
            // ConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 348);
            this.Controls.Add(this.cmdVerFactura);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.panelBusqueda);
            this.Name = "ConsultaFacturas";
            this.Text = "ConsultaFacturas";
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox tbContenido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImporteMaximo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbImporteMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdVerFactura;
    }
}