namespace WindowsFormsApplication1.ABM_Rol
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
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Agregar.Location = new System.Drawing.Point(12, 251);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(78, 26);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Modificar.Location = new System.Drawing.Point(108, 251);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(78, 26);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Eliminar.Location = new System.Drawing.Point(206, 251);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(78, 26);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol,
            this.Nombre});
            this.dataGridView1.Location = new System.Drawing.Point(25, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 216);
            this.dataGridView1.TabIndex = 3;
            // 
            // Rol
            // 
            this.Rol.Frozen = true;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 346);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}