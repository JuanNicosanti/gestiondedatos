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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdBuscarVis);
            this.panel2.Controls.Add(this.cmdCrearVis);
            this.panel2.Location = new System.Drawing.Point(12, 12);
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
            this.cmdVolver.Location = new System.Drawing.Point(119, 146);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 3;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 190);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.panel2);
            this.Name = "ABMVisibilidad";
            this.Text = "ABMVisibilidad";
            this.Load += new System.EventHandler(this.ABMVisibilidad_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdBuscarVis;
        private System.Windows.Forms.Button cmdCrearVis;
        private System.Windows.Forms.Button cmdVolver;
    }
}