namespace WindowsFormsApplication1.Calificar
{
    partial class CalificarVendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelCalificaciones = new System.Windows.Forms.Panel();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCalificar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.dgPublis = new System.Windows.Forms.DataGridView();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.taDetalle = new System.Windows.Forms.RichTextBox();
            this.panelCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPublis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la publicación que desea calificar:";
            // 
            // panelCalificaciones
            // 
            this.panelCalificaciones.Controls.Add(this.rb5);
            this.panelCalificaciones.Controls.Add(this.rb4);
            this.panelCalificaciones.Controls.Add(this.rb3);
            this.panelCalificaciones.Controls.Add(this.rb2);
            this.panelCalificaciones.Controls.Add(this.rb1);
            this.panelCalificaciones.Controls.Add(this.label2);
            this.panelCalificaciones.Location = new System.Drawing.Point(24, 176);
            this.panelCalificaciones.Name = "panelCalificaciones";
            this.panelCalificaciones.Size = new System.Drawing.Size(157, 145);
            this.panelCalificaciones.TabIndex = 2;
            this.panelCalificaciones.Visible = false;
            this.panelCalificaciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCalificaciones_Paint);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(7, 117);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(93, 17);
            this.rb5.TabIndex = 5;
            this.rb5.TabStop = true;
            this.rb5.Text = "Cinco estrellas";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(7, 93);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(97, 17);
            this.rb4.TabIndex = 4;
            this.rb4.TabStop = true;
            this.rb4.Text = "Cuatro estrellas";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(7, 69);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(87, 17);
            this.rb3.TabIndex = 3;
            this.rb3.TabStop = true;
            this.rb3.Text = "Tres estrellas";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(7, 45);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(85, 17);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "Dos estrellas";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(7, 21);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(81, 17);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "Una estrella";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elija el valor de la calificación:";
            // 
            // cmdCalificar
            // 
            this.cmdCalificar.Location = new System.Drawing.Point(211, 298);
            this.cmdCalificar.Name = "cmdCalificar";
            this.cmdCalificar.Size = new System.Drawing.Size(75, 23);
            this.cmdCalificar.TabIndex = 6;
            this.cmdCalificar.Text = "Calificar";
            this.cmdCalificar.UseVisualStyleBackColor = true;
            this.cmdCalificar.Visible = false;
            this.cmdCalificar.Click += new System.EventHandler(this.cmdCalificar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(337, 298);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 7;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // dgPublis
            // 
            this.dgPublis.AllowUserToAddRows = false;
            this.dgPublis.AllowUserToDeleteRows = false;
            this.dgPublis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPublis.Location = new System.Drawing.Point(24, 38);
            this.dgPublis.Name = "dgPublis";
            this.dgPublis.ReadOnly = true;
            this.dgPublis.Size = new System.Drawing.Size(388, 120);
            this.dgPublis.TabIndex = 8;
            this.dgPublis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPublis_CellContentClick);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(208, 176);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(192, 13);
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Agregar un detalle sobre la calificación:";
            this.lblDetalle.Visible = false;
            // 
            // taDetalle
            // 
            this.taDetalle.Location = new System.Drawing.Point(211, 197);
            this.taDetalle.Name = "taDetalle";
            this.taDetalle.Size = new System.Drawing.Size(201, 89);
            this.taDetalle.TabIndex = 10;
            this.taDetalle.Text = "";
            this.taDetalle.Visible = false;
            // 
            // CalificarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 334);
            this.Controls.Add(this.taDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.dgPublis);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdCalificar);
            this.Controls.Add(this.panelCalificaciones);
            this.Controls.Add(this.label1);
            this.Name = "CalificarVendedor";
            this.Text = "CalificarVendedor";
            this.panelCalificaciones.ResumeLayout(false);
            this.panelCalificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPublis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCalificaciones;
        private System.Windows.Forms.Button cmdCalificar;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.DataGridView dgPublis;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.RichTextBox taDetalle;
    }
}