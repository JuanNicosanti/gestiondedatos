namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class ABMVisibilidad
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdBuscarVis = new System.Windows.Forms.Button();
            this.cmdCrearVis = new System.Windows.Forms.Button();
            this.cmdModVis = new System.Windows.Forms.Button();
            this.cmdEliminarVis = new System.Windows.Forms.Button();
            this.panelComs = new System.Windows.Forms.Panel();
            this.textBoxEnvio = new System.Windows.Forms.TextBox();
            this.comEnvio = new System.Windows.Forms.Label();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.comProd = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.comTipo = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.lblEleccion = new System.Windows.Forms.Label();
            this.cboTipoVis = new System.Windows.Forms.ComboBox();
            this.cmdUpdateVis = new System.Windows.Forms.Button();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cmdBuscarVisUnica = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelComs.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdBuscarVis);
            this.panel2.Controls.Add(this.cmdCrearVis);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 57);
            this.panel2.TabIndex = 2;
            // 
            // cmdBuscarVis
            // 
            this.cmdBuscarVis.Location = new System.Drawing.Point(24, 15);
            this.cmdBuscarVis.Name = "cmdBuscarVis";
            this.cmdBuscarVis.Size = new System.Drawing.Size(131, 23);
            this.cmdBuscarVis.TabIndex = 1;
            this.cmdBuscarVis.Text = "Buscar Visibilidad";
            this.cmdBuscarVis.UseVisualStyleBackColor = true;
            this.cmdBuscarVis.Click += new System.EventHandler(this.cmdBuscarVis_Click);
            // 
            // cmdCrearVis
            // 
            this.cmdCrearVis.Location = new System.Drawing.Point(192, 15);
            this.cmdCrearVis.Name = "cmdCrearVis";
            this.cmdCrearVis.Size = new System.Drawing.Size(131, 23);
            this.cmdCrearVis.TabIndex = 0;
            this.cmdCrearVis.Text = "Crear Visibilidad";
            this.cmdCrearVis.UseVisualStyleBackColor = true;
            this.cmdCrearVis.Click += new System.EventHandler(this.cmdCrearVis_Click);
            // 
            // cmdModVis
            // 
            this.cmdModVis.Location = new System.Drawing.Point(216, 160);
            this.cmdModVis.Name = "cmdModVis";
            this.cmdModVis.Size = new System.Drawing.Size(131, 23);
            this.cmdModVis.TabIndex = 2;
            this.cmdModVis.Text = "Modificar Visibilidad";
            this.cmdModVis.UseVisualStyleBackColor = true;
            this.cmdModVis.Visible = false;
            this.cmdModVis.Click += new System.EventHandler(this.cmdModVis_Click);
            // 
            // cmdEliminarVis
            // 
            this.cmdEliminarVis.Location = new System.Drawing.Point(216, 216);
            this.cmdEliminarVis.Name = "cmdEliminarVis";
            this.cmdEliminarVis.Size = new System.Drawing.Size(131, 23);
            this.cmdEliminarVis.TabIndex = 1;
            this.cmdEliminarVis.Text = "Eliminar Visibilidad";
            this.cmdEliminarVis.UseVisualStyleBackColor = true;
            this.cmdEliminarVis.Visible = false;
            this.cmdEliminarVis.Click += new System.EventHandler(this.cmdEliminarVis_Click);
            // 
            // panelComs
            // 
            this.panelComs.Controls.Add(this.textBoxEnvio);
            this.panelComs.Controls.Add(this.comEnvio);
            this.panelComs.Controls.Add(this.textBoxProd);
            this.panelComs.Controls.Add(this.comProd);
            this.panelComs.Controls.Add(this.textBoxTipo);
            this.panelComs.Controls.Add(this.comTipo);
            this.panelComs.Location = new System.Drawing.Point(12, 121);
            this.panelComs.Name = "panelComs";
            this.panelComs.Size = new System.Drawing.Size(198, 167);
            this.panelComs.TabIndex = 3;
            this.panelComs.Visible = false;
            // 
            // textBoxEnvio
            // 
            this.textBoxEnvio.Enabled = false;
            this.textBoxEnvio.Location = new System.Drawing.Point(17, 121);
            this.textBoxEnvio.Name = "textBoxEnvio";
            this.textBoxEnvio.Size = new System.Drawing.Size(59, 20);
            this.textBoxEnvio.TabIndex = 7;
            // 
            // comEnvio
            // 
            this.comEnvio.AutoSize = true;
            this.comEnvio.Location = new System.Drawing.Point(14, 105);
            this.comEnvio.Name = "comEnvio";
            this.comEnvio.Size = new System.Drawing.Size(163, 13);
            this.comEnvio.TabIndex = 6;
            this.comEnvio.Text = "Comisión por envío del producto:";
            // 
            // textBoxProd
            // 
            this.textBoxProd.Enabled = false;
            this.textBoxProd.Location = new System.Drawing.Point(17, 29);
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
            this.textBoxTipo.Enabled = false;
            this.textBoxTipo.Location = new System.Drawing.Point(17, 73);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(59, 20);
            this.textBoxTipo.TabIndex = 3;
            // 
            // comTipo
            // 
            this.comTipo.AutoSize = true;
            this.comTipo.Location = new System.Drawing.Point(14, 57);
            this.comTipo.Name = "comTipo";
            this.comTipo.Size = new System.Drawing.Size(162, 13);
            this.comTipo.TabIndex = 2;
            this.comTipo.Text = "Comisión por tipo de publicación:";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.lblEleccion);
            this.panelBusqueda.Controls.Add(this.cboTipoVis);
            this.panelBusqueda.Location = new System.Drawing.Point(12, 75);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(345, 42);
            this.panelBusqueda.TabIndex = 4;
            this.panelBusqueda.Visible = false;
            // 
            // lblEleccion
            // 
            this.lblEleccion.AutoSize = true;
            this.lblEleccion.Location = new System.Drawing.Point(6, 16);
            this.lblEleccion.Name = "lblEleccion";
            this.lblEleccion.Size = new System.Drawing.Size(176, 13);
            this.lblEleccion.TabIndex = 0;
            this.lblEleccion.Text = "Elija el tipo de visibilidad que desea:";
            // 
            // cboTipoVis
            // 
            this.cboTipoVis.FormattingEnabled = true;
            this.cboTipoVis.Location = new System.Drawing.Point(192, 13);
            this.cboTipoVis.Name = "cboTipoVis";
            this.cboTipoVis.Size = new System.Drawing.Size(137, 21);
            this.cboTipoVis.TabIndex = 1;
            this.cboTipoVis.SelectedIndexChanged += new System.EventHandler(this.cboTipoVis_SelectedIndexChanged);
            // 
            // cmdUpdateVis
            // 
            this.cmdUpdateVis.Location = new System.Drawing.Point(243, 245);
            this.cmdUpdateVis.Name = "cmdUpdateVis";
            this.cmdUpdateVis.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateVis.TabIndex = 5;
            this.cmdUpdateVis.Text = "Aceptar";
            this.cmdUpdateVis.UseVisualStyleBackColor = true;
            this.cmdUpdateVis.Visible = false;
            this.cmdUpdateVis.Click += new System.EventHandler(this.cmdUpdateVis_Click);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(13, 305);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(176, 20);
            this.tbBusqueda.TabIndex = 6;
            this.tbBusqueda.Visible = false;
            // 
            // cmdBuscarVisUnica
            // 
            this.cmdBuscarVisUnica.Location = new System.Drawing.Point(216, 305);
            this.cmdBuscarVisUnica.Name = "cmdBuscarVisUnica";
            this.cmdBuscarVisUnica.Size = new System.Drawing.Size(89, 23);
            this.cmdBuscarVisUnica.TabIndex = 7;
            this.cmdBuscarVisUnica.Text = "Buscar";
            this.cmdBuscarVisUnica.UseVisualStyleBackColor = true;
            this.cmdBuscarVisUnica.Visible = false;
            this.cmdBuscarVisUnica.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(13, 332);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(35, 13);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "label1";
            this.lblBusqueda.Visible = false;
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 350);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.cmdBuscarVisUnica);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.cmdUpdateVis);
            this.Controls.Add(this.cmdEliminarVis);
            this.Controls.Add(this.cmdModVis);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelComs);
            this.Controls.Add(this.panel2);
            this.Name = "ABMVisibilidad";
            this.Text = "ABMVisibilidad";
            this.Load += new System.EventHandler(this.ABMVisibilidad_Load);
            this.panel2.ResumeLayout(false);
            this.panelComs.ResumeLayout(false);
            this.panelComs.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdBuscarVis;
        private System.Windows.Forms.Button cmdCrearVis;
        private System.Windows.Forms.Button cmdModVis;
        private System.Windows.Forms.Button cmdEliminarVis;
        private System.Windows.Forms.Panel panelComs;
        private System.Windows.Forms.TextBox textBoxEnvio;
        private System.Windows.Forms.Label comEnvio;
        private System.Windows.Forms.TextBox textBoxProd;
        private System.Windows.Forms.Label comProd;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label comTipo;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label lblEleccion;
        private System.Windows.Forms.ComboBox cboTipoVis;
        private System.Windows.Forms.Button cmdUpdateVis;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button cmdBuscarVisUnica;
        private System.Windows.Forms.Label lblBusqueda;
    }
}