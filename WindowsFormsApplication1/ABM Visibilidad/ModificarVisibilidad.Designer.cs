namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class ModificarVisibilidad
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
            this.tbEnvio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdVolverComs = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdAceptarVis = new System.Windows.Forms.Button();
            this.tbComiVariable = new System.Windows.Forms.TextBox();
            this.tbComiFija = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEnvio
            // 
            this.tbEnvio.Location = new System.Drawing.Point(21, 182);
            this.tbEnvio.Name = "tbEnvio";
            this.tbEnvio.Size = new System.Drawing.Size(74, 20);
            this.tbEnvio.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Comisión por envío";
            // 
            // cmdVolverComs
            // 
            this.cmdVolverComs.Location = new System.Drawing.Point(193, 225);
            this.cmdVolverComs.Name = "cmdVolverComs";
            this.cmdVolverComs.Size = new System.Drawing.Size(75, 23);
            this.cmdVolverComs.TabIndex = 21;
            this.cmdVolverComs.Text = "Volver";
            this.cmdVolverComs.UseVisualStyleBackColor = true;
            this.cmdVolverComs.Click += new System.EventHandler(this.cmdVolverComs_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(106, 225);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 20;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdAceptarVis
            // 
            this.cmdAceptarVis.Location = new System.Drawing.Point(21, 225);
            this.cmdAceptarVis.Name = "cmdAceptarVis";
            this.cmdAceptarVis.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptarVis.TabIndex = 19;
            this.cmdAceptarVis.Text = "Aceptar";
            this.cmdAceptarVis.UseVisualStyleBackColor = true;
            this.cmdAceptarVis.Click += new System.EventHandler(this.cmdAceptarVis_Click);
            // 
            // tbComiVariable
            // 
            this.tbComiVariable.Location = new System.Drawing.Point(21, 139);
            this.tbComiVariable.Name = "tbComiVariable";
            this.tbComiVariable.Size = new System.Drawing.Size(74, 20);
            this.tbComiVariable.TabIndex = 18;
            // 
            // tbComiFija
            // 
            this.tbComiFija.Location = new System.Drawing.Point(21, 96);
            this.tbComiFija.Name = "tbComiFija";
            this.tbComiFija.Size = new System.Drawing.Size(74, 20);
            this.tbComiFija.TabIndex = 17;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(21, 55);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(114, 20);
            this.tbDescripcion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Comisión por producto vendido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Comisión por tipo de publicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese los valores correspondientes";
            // 
            // ModificarVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 259);
            this.Controls.Add(this.tbEnvio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdVolverComs);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdAceptarVis);
            this.Controls.Add(this.tbComiVariable);
            this.Controls.Add(this.tbComiFija);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarVisibilidad";
            this.Text = "ModificarVisibilidad";
            this.Load += new System.EventHandler(this.ModificarVisibilidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdVolverComs;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdAceptarVis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbEnvio;
        public System.Windows.Forms.TextBox tbComiVariable;
        public System.Windows.Forms.TextBox tbComiFija;
        public System.Windows.Forms.TextBox tbDescripcion;
    }
}