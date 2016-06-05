namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmdModificarUsuario = new System.Windows.Forms.Button();
            this.cmdPublicacion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingreseUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cmdVerVisibilidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdBajaRol = new System.Windows.Forms.Button();
            this.cmdModificarRol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(297, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(10, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = " ";
            // 
            // cmdModificarUsuario
            // 
            this.cmdModificarUsuario.Location = new System.Drawing.Point(228, 49);
            this.cmdModificarUsuario.Name = "cmdModificarUsuario";
            this.cmdModificarUsuario.Size = new System.Drawing.Size(111, 23);
            this.cmdModificarUsuario.TabIndex = 4;
            this.cmdModificarUsuario.Text = "Modificar Usuario";
            this.cmdModificarUsuario.UseVisualStyleBackColor = true;
            this.cmdModificarUsuario.Click += new System.EventHandler(this.cmdModificarUsuario_Click);
            // 
            // cmdPublicacion
            // 
            this.cmdPublicacion.Location = new System.Drawing.Point(228, 78);
            this.cmdPublicacion.Name = "cmdPublicacion";
            this.cmdPublicacion.Size = new System.Drawing.Size(111, 23);
            this.cmdPublicacion.TabIndex = 5;
            this.cmdPublicacion.Text = "Crear Publicacion";
            this.cmdPublicacion.UseVisualStyleBackColor = true;
            this.cmdPublicacion.Click += new System.EventHandler(this.cmdPublicacion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingreseUsuarioToolStripMenuItem,
            this.funcionesToolStripMenuItem,
            this.desconectarseToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // ingreseUsuarioToolStripMenuItem
            // 
            this.ingreseUsuarioToolStripMenuItem.Name = "ingreseUsuarioToolStripMenuItem";
            this.ingreseUsuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingreseUsuarioToolStripMenuItem.Text = "Ingrese usuario";
            this.ingreseUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ingreseUsuarioToolStripMenuItem_Click);
            // 
            // desconectarseToolStripMenuItem
            // 
            this.desconectarseToolStripMenuItem.Name = "desconectarseToolStripMenuItem";
            this.desconectarseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.desconectarseToolStripMenuItem.Text = "Desconectarse";
            this.desconectarseToolStripMenuItem.Click += new System.EventHandler(this.desconectarseToolStripMenuItem_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(352, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cmdVerVisibilidad
            // 
            this.cmdVerVisibilidad.Location = new System.Drawing.Point(228, 107);
            this.cmdVerVisibilidad.Name = "cmdVerVisibilidad";
            this.cmdVerVisibilidad.Size = new System.Drawing.Size(111, 23);
            this.cmdVerVisibilidad.TabIndex = 8;
            this.cmdVerVisibilidad.Text = "Ver visibilidad";
            this.cmdVerVisibilidad.UseVisualStyleBackColor = true;
            this.cmdVerVisibilidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Alta Rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdBajaRol
            // 
            this.cmdBajaRol.Location = new System.Drawing.Point(228, 166);
            this.cmdBajaRol.Name = "cmdBajaRol";
            this.cmdBajaRol.Size = new System.Drawing.Size(111, 23);
            this.cmdBajaRol.TabIndex = 11;
            this.cmdBajaRol.Text = "Baja Rol";
            this.cmdBajaRol.UseVisualStyleBackColor = true;
            this.cmdBajaRol.Click += new System.EventHandler(this.cmdBajaRol_Click);
            // 
            // cmdModificarRol
            // 
            this.cmdModificarRol.Location = new System.Drawing.Point(228, 193);
            this.cmdModificarRol.Name = "cmdModificarRol";
            this.cmdModificarRol.Size = new System.Drawing.Size(111, 23);
            this.cmdModificarRol.TabIndex = 12;
            this.cmdModificarRol.Text = "Modificar Rol";
            this.cmdModificarRol.UseVisualStyleBackColor = true;
            this.cmdModificarRol.Click += new System.EventHandler(this.cmdModificarRol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            this.funcionesToolStripMenuItem.Click += new System.EventHandler(this.funcionesToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(352, 241);
            this.Controls.Add(this.cmdModificarRol);
            this.Controls.Add(this.cmdBajaRol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdVerVisibilidad);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdPublicacion);
            this.Controls.Add(this.cmdModificarUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button cmdModificarUsuario;
        private System.Windows.Forms.Button cmdPublicacion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingreseUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem desconectarseToolStripMenuItem;
        private System.Windows.Forms.Button cmdVerVisibilidad;
//        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdBajaRol;
        private System.Windows.Forms.Button cmdModificarRol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

