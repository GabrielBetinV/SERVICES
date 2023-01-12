namespace Usuarios
{
    partial class frm_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_identificacion = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbx_estado = new System.Windows.Forms.CheckBox();
            this.pb_guardar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_guardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 73);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE USUARIOS";
            // 
            // tb_identificacion
            // 
            this.tb_identificacion.Location = new System.Drawing.Point(147, 119);
            this.tb_identificacion.Name = "tb_identificacion";
            this.tb_identificacion.Size = new System.Drawing.Size(211, 23);
            this.tb_identificacion.TabIndex = 1;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(147, 164);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(211, 23);
            this.tb_login.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(452, 164);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(248, 23);
            this.tb_password.TabIndex = 5;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(452, 119);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(248, 23);
            this.tb_nombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(147, 208);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(212, 23);
            this.dtp_fecha_nacimiento.TabIndex = 11;
            // 
            // cbx_estado
            // 
            this.cbx_estado.AutoSize = true;
            this.cbx_estado.Location = new System.Drawing.Point(369, 212);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(60, 19);
            this.cbx_estado.TabIndex = 12;
            this.cbx_estado.Text = "Activo";
            this.cbx_estado.UseVisualStyleBackColor = true;
            // 
            // pb_guardar
            // 
            this.pb_guardar.Image = ((System.Drawing.Image)(resources.GetObject("pb_guardar.Image")));
            this.pb_guardar.Location = new System.Drawing.Point(476, 193);
            this.pb_guardar.Name = "pb_guardar";
            this.pb_guardar.Size = new System.Drawing.Size(100, 50);
            this.pb_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_guardar.TabIndex = 13;
            this.pb_guardar.TabStop = false;
            this.pb_guardar.Click += new System.EventHandler(this.pb_guardar_Click);
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 252);
            this.Controls.Add(this.pb_guardar);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_identificacion);
            this.Controls.Add(this.panel1);
            this.Name = "frm_usuario";
            this.Text = "GESTION USUARIOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox tb_identificacion;
        private TextBox tb_login;
        private TextBox tb_password;
        private TextBox tb_nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtp_fecha_nacimiento;
        private CheckBox cbx_estado;
        private PictureBox pb_guardar;
        private PictureBox pictureBox1;
    }
}