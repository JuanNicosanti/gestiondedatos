namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class Form1
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
            this.panelComs = new System.Windows.Forms.Panel();
            this.cmdUpdateVis = new System.Windows.Forms.Button();
            this.panelEnvio = new System.Windows.Forms.Panel();
            this.comEnvio = new System.Windows.Forms.Label();
            this.textBoxEnvio = new System.Windows.Forms.TextBox();
            this.cbEnvio = new System.Windows.Forms.CheckBox();
            this.cmdAceptarComisiones = new System.Windows.Forms.Button();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.comProd = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.comTipo = new System.Windows.Forms.Label();
            this.cboTipoVis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdModVis = new System.Windows.Forms.Button();
            this.cmdEliminarVis = new System.Windows.Forms.Button();
            this.cmdCrearVis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelComs.SuspendLayout();
            this.panelEnvio.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelComs
            // 
            this.panelComs.Controls.Add(this.cmdUpdateVis);
            this.panelComs.Controls.Add(this.panelEnvio);
            this.panelComs.Controls.Add(this.cbEnvio);
            this.panelComs.Controls.Add(this.cmdAceptarComisiones);
            this.panelComs.Controls.Add(this.textBoxProd);
            this.panelComs.Controls.Add(this.comProd);
            this.panelComs.Controls.Add(this.textBoxTipo);
            this.panelComs.Controls.Add(this.comTipo);
            this.panelComs.Location = new System.Drawing.Point(13, 122);
            this.panelComs.Name = "panelComs";
            this.panelComs.Size = new System.Drawing.Size(190, 221);
            this.panelComs.TabIndex = 0;
            // 
            // cmdUpdateVis
            // 
            this.cmdUpdateVis.Location = new System.Drawing.Point(16, 186);
            this.cmdUpdateVis.Name = "cmdUpdateVis";
            this.cmdUpdateVis.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateVis.TabIndex = 3;
            this.cmdUpdateVis.Text = "Aceptar";
            this.cmdUpdateVis.UseVisualStyleBackColor = true;
            this.cmdUpdateVis.Visible = false;
            this.cmdUpdateVis.Click += new System.EventHandler(this.cmdUpdateVis_Click);
            // 
            // panelEnvio
            // 
            this.panelEnvio.Controls.Add(this.comEnvio);
            this.panelEnvio.Controls.Add(this.textBoxEnvio);
            this.panelEnvio.Location = new System.Drawing.Point(10, 133);
            this.panelEnvio.Name = "panelEnvio";
            this.panelEnvio.Size = new System.Drawing.Size(170, 47);
            this.panelEnvio.TabIndex = 3;
            // 
            // comEnvio
            // 
            this.comEnvio.AutoSize = true;
            this.comEnvio.Location = new System.Drawing.Point(3, 3);
            this.comEnvio.Name = "comEnvio";
            this.comEnvio.Size = new System.Drawing.Size(163, 13);
            this.comEnvio.TabIndex = 6;
            this.comEnvio.Text = "Comisión por envío del producto:";
            // 
            // textBoxEnvio
            // 
            this.textBoxEnvio.Location = new System.Drawing.Point(6, 19);
            this.textBoxEnvio.Name = "textBoxEnvio";
            this.textBoxEnvio.Size = new System.Drawing.Size(59, 20);
            this.textBoxEnvio.TabIndex = 7;
            // 
            // cbEnvio
            // 
            this.cbEnvio.AutoSize = true;
            this.cbEnvio.Location = new System.Drawing.Point(14, 104);
            this.cbEnvio.Name = "cbEnvio";
            this.cbEnvio.Size = new System.Drawing.Size(77, 17);
            this.cbEnvio.TabIndex = 9;
            this.cbEnvio.Text = "Con Envío";
            this.cbEnvio.UseVisualStyleBackColor = true;
            this.cbEnvio.CheckedChanged += new System.EventHandler(this.cbEnvio_CheckedChanged);
            // 
            // cmdAceptarComisiones
            // 
            this.cmdAceptarComisiones.Location = new System.Drawing.Point(98, 186);
            this.cmdAceptarComisiones.Name = "cmdAceptarComisiones";
            this.cmdAceptarComisiones.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptarComisiones.TabIndex = 8;
            this.cmdAceptarComisiones.Text = "Aceptar";
            this.cmdAceptarComisiones.UseVisualStyleBackColor = true;
            this.cmdAceptarComisiones.Click += new System.EventHandler(this.cmdAceptarComisiones_Click);
            // 
            // textBoxProd
            // 
            this.textBoxProd.Location = new System.Drawing.Point(14, 29);
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(59, 20);
            this.textBoxProd.TabIndex = 5;
            // 
            // comProd
            // 
            this.comProd.AutoSize = true;
            this.comProd.Location = new System.Drawing.Point(14, 13);
            this.comProd.Name = "comProd";
            this.comProd.Size = new System.Drawing.Size(156, 13);
            this.comProd.TabIndex = 4;
            this.comProd.Text = "Comisión por producto vendido:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(14, 77);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(59, 20);
            this.textBoxTipo.TabIndex = 3;
            // 
            // comTipo
            // 
            this.comTipo.AutoSize = true;
            this.comTipo.Location = new System.Drawing.Point(13, 61);
            this.comTipo.Name = "comTipo";
            this.comTipo.Size = new System.Drawing.Size(162, 13);
            this.comTipo.TabIndex = 2;
            this.comTipo.Text = "Comisión por tipo de publicación:";
            // 
            // cboTipoVis
            // 
            this.cboTipoVis.FormattingEnabled = true;
            this.cboTipoVis.Location = new System.Drawing.Point(9, 43);
            this.cboTipoVis.Name = "cboTipoVis";
            this.cboTipoVis.Size = new System.Drawing.Size(137, 21);
            this.cboTipoVis.TabIndex = 1;
            this.cboTipoVis.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el tipo de visibilidad que desea:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdModVis);
            this.panel2.Controls.Add(this.cmdEliminarVis);
            this.panel2.Controls.Add(this.cmdCrearVis);
            this.panel2.Location = new System.Drawing.Point(221, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 135);
            this.panel2.TabIndex = 1;
            // 
            // cmdModVis
            // 
            this.cmdModVis.Location = new System.Drawing.Point(39, 52);
            this.cmdModVis.Name = "cmdModVis";
            this.cmdModVis.Size = new System.Drawing.Size(131, 23);
            this.cmdModVis.TabIndex = 2;
            this.cmdModVis.Text = "Modificar Visibilidad";
            this.cmdModVis.UseVisualStyleBackColor = true;
            this.cmdModVis.Click += new System.EventHandler(this.cmdModVis_Click);
            // 
            // cmdEliminarVis
            // 
            this.cmdEliminarVis.Location = new System.Drawing.Point(39, 89);
            this.cmdEliminarVis.Name = "cmdEliminarVis";
            this.cmdEliminarVis.Size = new System.Drawing.Size(131, 23);
            this.cmdEliminarVis.TabIndex = 1;
            this.cmdEliminarVis.Text = "Eliminar Visibilidad";
            this.cmdEliminarVis.UseVisualStyleBackColor = true;
            this.cmdEliminarVis.Click += new System.EventHandler(this.eliminarVisibilidad_Click);
            // 
            // cmdCrearVis
            // 
            this.cmdCrearVis.Location = new System.Drawing.Point(39, 15);
            this.cmdCrearVis.Name = "cmdCrearVis";
            this.cmdCrearVis.Size = new System.Drawing.Size(131, 23);
            this.cmdCrearVis.TabIndex = 0;
            this.cmdCrearVis.Text = "Crear Visibilidad";
            this.cmdCrearVis.UseVisualStyleBackColor = true;
            this.cmdCrearVis.Click += new System.EventHandler(this.cmdCrearVis_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboTipoVis);
            this.panel3.Location = new System.Drawing.Point(14, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 96);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 347);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelComs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelComs.ResumeLayout(false);
            this.panelComs.PerformLayout();
            this.panelEnvio.ResumeLayout(false);
            this.panelEnvio.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelComs;
        private System.Windows.Forms.ComboBox cboTipoVis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdEliminarVis;
        private System.Windows.Forms.Button cmdCrearVis;
        private System.Windows.Forms.Button cmdAceptarComisiones;
        private System.Windows.Forms.TextBox textBoxEnvio;
        private System.Windows.Forms.Label comEnvio;
        private System.Windows.Forms.TextBox textBoxProd;
        private System.Windows.Forms.Label comProd;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label comTipo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbEnvio;
        private System.Windows.Forms.Panel panelEnvio;
        private System.Windows.Forms.Button cmdModVis;
        private System.Windows.Forms.Button cmdUpdateVis;
    }
}