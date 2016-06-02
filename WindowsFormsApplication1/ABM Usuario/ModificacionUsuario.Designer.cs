namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class ModificacionUsuario
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSeleccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.chkRazonSocial = new System.Windows.Forms.CheckBox();
            this.chkCUITEmpresa = new System.Windows.Forms.CheckBox();
            this.chkEmailCliente = new System.Windows.Forms.CheckBox();
            this.chkEmailEmpresa = new System.Windows.Forms.CheckBox();
            this.chkApellido = new System.Windows.Forms.CheckBox();
            this.chkNombreC = new System.Windows.Forms.CheckBox();
            this.chkMailCl = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 137);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Usuario";
            // 
            // cboSeleccion
            // 
            this.cboSeleccion.FormattingEnabled = true;
            this.cboSeleccion.Items.AddRange(new object[] {
            "Cliente",
            "Empresa"});
            this.cboSeleccion.Location = new System.Drawing.Point(34, 59);
            this.cboSeleccion.Name = "cboSeleccion";
            this.cboSeleccion.Size = new System.Drawing.Size(171, 21);
            this.cboSeleccion.TabIndex = 2;
            this.cboSeleccion.Text = "Seleccione un Tipo de Usuario";
            this.cboSeleccion.SelectedIndexChanged += new System.EventHandler(this.cboSeleccion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 174);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por..";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(237, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 342);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultados";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(146, 397);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(186, 23);
            this.cmdVolver.TabIndex = 13;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // chkRazonSocial
            // 
            this.chkRazonSocial.AutoSize = true;
            this.chkRazonSocial.Location = new System.Drawing.Point(33, 224);
            this.chkRazonSocial.Name = "chkRazonSocial";
            this.chkRazonSocial.Size = new System.Drawing.Size(89, 17);
            this.chkRazonSocial.TabIndex = 16;
            this.chkRazonSocial.Text = "Razon Social";
            this.chkRazonSocial.UseVisualStyleBackColor = true;
            // 
            // chkCUITEmpresa
            // 
            this.chkCUITEmpresa.AutoSize = true;
            this.chkCUITEmpresa.Location = new System.Drawing.Point(34, 259);
            this.chkCUITEmpresa.Name = "chkCUITEmpresa";
            this.chkCUITEmpresa.Size = new System.Drawing.Size(51, 17);
            this.chkCUITEmpresa.TabIndex = 17;
            this.chkCUITEmpresa.Text = "CUIT";
            this.chkCUITEmpresa.UseVisualStyleBackColor = true;
            // 
            // chkEmailCliente
            // 
            this.chkEmailCliente.AutoSize = true;
            this.chkEmailCliente.Location = new System.Drawing.Point(34, 294);
            this.chkEmailCliente.Name = "chkEmailCliente";
            this.chkEmailCliente.Size = new System.Drawing.Size(45, 17);
            this.chkEmailCliente.TabIndex = 18;
            this.chkEmailCliente.Text = "DNI";
            this.chkEmailCliente.UseVisualStyleBackColor = true;
            // 
            // chkEmailEmpresa
            // 
            this.chkEmailEmpresa.AutoSize = true;
            this.chkEmailEmpresa.Location = new System.Drawing.Point(34, 294);
            this.chkEmailEmpresa.Name = "chkEmailEmpresa";
            this.chkEmailEmpresa.Size = new System.Drawing.Size(51, 17);
            this.chkEmailEmpresa.TabIndex = 19;
            this.chkEmailEmpresa.Text = "Email";
            this.chkEmailEmpresa.UseVisualStyleBackColor = true;
            // 
            // chkApellido
            // 
            this.chkApellido.AutoSize = true;
            this.chkApellido.Location = new System.Drawing.Point(34, 259);
            this.chkApellido.Name = "chkApellido";
            this.chkApellido.Size = new System.Drawing.Size(63, 17);
            this.chkApellido.TabIndex = 20;
            this.chkApellido.Text = "Apellido";
            this.chkApellido.UseVisualStyleBackColor = true;
            // 
            // chkNombreC
            // 
            this.chkNombreC.AutoSize = true;
            this.chkNombreC.Location = new System.Drawing.Point(34, 224);
            this.chkNombreC.Name = "chkNombreC";
            this.chkNombreC.Size = new System.Drawing.Size(63, 17);
            this.chkNombreC.TabIndex = 21;
            this.chkNombreC.Text = "Nombre";
            this.chkNombreC.UseVisualStyleBackColor = true;
            // 
            // chkMailCl
            // 
            this.chkMailCl.AutoSize = true;
            this.chkMailCl.Location = new System.Drawing.Point(34, 326);
            this.chkMailCl.Name = "chkMailCl";
            this.chkMailCl.Size = new System.Drawing.Size(51, 17);
            this.chkMailCl.TabIndex = 22;
            this.chkMailCl.Text = "Email";
            this.chkMailCl.UseVisualStyleBackColor = true;
            // 
            // ModificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(565, 461);
            this.Controls.Add(this.chkMailCl);
            this.Controls.Add(this.chkNombreC);
            this.Controls.Add(this.chkApellido);
            this.Controls.Add(this.chkEmailEmpresa);
            this.Controls.Add(this.chkEmailCliente);
            this.Controls.Add(this.chkCUITEmpresa);
            this.Controls.Add(this.chkRazonSocial);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSeleccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModificacionUsuario";
            this.Text = "ModificacionUsuario";
            this.Load += new System.EventHandler(this.ModificacionUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSeleccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox chkRazonSocial;
        private System.Windows.Forms.CheckBox chkCUITEmpresa;
        private System.Windows.Forms.CheckBox chkEmailCliente;
        private System.Windows.Forms.CheckBox chkEmailEmpresa;
        private System.Windows.Forms.CheckBox chkApellido;
        private System.Windows.Forms.CheckBox chkNombreC;
        private System.Windows.Forms.CheckBox chkMailCl;
    }
}