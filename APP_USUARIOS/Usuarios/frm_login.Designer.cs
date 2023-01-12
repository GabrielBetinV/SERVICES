namespace Usuarios
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pb_usuario = new System.Windows.Forms.PictureBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.bt_registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_usuario
            // 
            this.pb_usuario.Image = ((System.Drawing.Image)(resources.GetObject("pb_usuario.Image")));
            this.pb_usuario.Location = new System.Drawing.Point(16, 22);
            this.pb_usuario.Name = "pb_usuario";
            this.pb_usuario.Size = new System.Drawing.Size(100, 118);
            this.pb_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_usuario.TabIndex = 0;
            this.pb_usuario.TabStop = false;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(214, 50);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(183, 23);
            this.tb_usuario.TabIndex = 1;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(214, 98);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '*';
            this.tb_contraseña.Size = new System.Drawing.Size(183, 23);
            this.tb_contraseña.TabIndex = 2;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(128, 55);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(50, 15);
            this.lb_usuario.TabIndex = 3;
            this.lb_usuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña:";
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.Location = new System.Drawing.Point(128, 134);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(122, 23);
            this.bt_ingresar.TabIndex = 5;
            this.bt_ingresar.Text = "INGRESAR";
            this.bt_ingresar.UseVisualStyleBackColor = true;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // bt_registrar
            // 
            this.bt_registrar.Location = new System.Drawing.Point(275, 134);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(122, 23);
            this.bt_registrar.TabIndex = 6;
            this.bt_registrar.Text = "REGISTRAR";
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 169);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.pb_usuario);
            this.Name = "frm_login";
            this.Text = "INICIO DE SESIÓN";
            ((System.ComponentModel.ISupportInitialize)(this.pb_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_usuario;
        private TextBox tb_usuario;
        private TextBox tb_contraseña;
        private Label lb_usuario;
        private Label label1;
        private Button bt_ingresar;
        private Button bt_registrar;
    }
}