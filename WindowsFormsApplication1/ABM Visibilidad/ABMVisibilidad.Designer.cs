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
            this.cmdVolver = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdBuscarVis);
            this.panel2.Controls.Add(this.cmdCrearVis);
            this.panel2.Location = new System.Drawing.Point(20, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 116);
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
            this.cmdCrearVis.Location = new System.Drawing.Point(24, 70);
            this.cmdCrearVis.Name = "cmdCrearVis";
            this.cmdCrearVis.Size = new System.Drawing.Size(131, 23);
            this.cmdCrearVis.TabIndex = 0;
            this.cmdCrearVis.Text = "Crear Visibilidad";
            this.cmdCrearVis.UseVisualStyleBackColor = true;
            this.cmdCrearVis.Click += new System.EventHandler(this.cmdCrearVis_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(70, 171);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 3;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(215, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(215, 221);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ABMVisibilidad";
            this.Text = "ABMVisibilidad";
            this.Load += new System.EventHandler(this.ABMVisibilidad_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdBuscarVis;
        private System.Windows.Forms.Button cmdCrearVis;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}