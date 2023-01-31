namespace PIA_TP_II_ASILO
{
    partial class AgregarUsuarios
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
            this.panelImagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelIDActividaDL = new System.Windows.Forms.Panel();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.panelPasswordL = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.btnVerContraseña = new System.Windows.Forms.Button();
            this.groupBoxTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rdEmpleado = new System.Windows.Forms.RadioButton();
            this.rdAdministrativo = new System.Windows.Forms.RadioButton();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTipoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelImagen.Controls.Add(this.pictureBox1);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(280, 360);
            this.panelImagen.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIA_TP_II_ASILO.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelIDActividaDL
            // 
            this.panelIDActividaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelIDActividaDL.Location = new System.Drawing.Point(304, 63);
            this.panelIDActividaDL.Name = "panelIDActividaDL";
            this.panelIDActividaDL.Size = new System.Drawing.Size(365, 2);
            this.panelIDActividaDL.TabIndex = 7;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdUsuario.Location = new System.Drawing.Point(304, 43);
            this.txtIdUsuario.MaxLength = 6;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(365, 20);
            this.txtIdUsuario.TabIndex = 6;
            this.txtIdUsuario.Text = "ID USUARIO";
            this.txtIdUsuario.Enter += new System.EventHandler(this.txtIdUsuario_Enter);
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            this.txtIdUsuario.Leave += new System.EventHandler(this.txtIdUsuario_Leave);
            // 
            // panelPasswordL
            // 
            this.panelPasswordL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelPasswordL.Location = new System.Drawing.Point(304, 109);
            this.panelPasswordL.Name = "panelPasswordL";
            this.panelPasswordL.Size = new System.Drawing.Size(365, 2);
            this.panelPasswordL.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(304, 89);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(365, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "CONTRASEÑA";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(300, 133);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(102, 21);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "EMPLEADO:";
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmpleado.ForeColor = System.Drawing.Color.White;
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(304, 154);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(365, 29);
            this.comboEmpleado.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::PIA_TP_II_ASILO.Properties.Resources.forbidden;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(522, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 35);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::PIA_TP_II_ASILO.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(336, 299);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::PIA_TP_II_ASILO.Properties.Resources.x;
            this.BtnCerrar.Location = new System.Drawing.Point(676, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnVerContraseña
            // 
            this.btnVerContraseña.FlatAppearance.BorderSize = 0;
            this.btnVerContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContraseña.Image = global::PIA_TP_II_ASILO.Properties.Resources.hide;
            this.btnVerContraseña.Location = new System.Drawing.Point(639, 77);
            this.btnVerContraseña.Name = "btnVerContraseña";
            this.btnVerContraseña.Size = new System.Drawing.Size(30, 30);
            this.btnVerContraseña.TabIndex = 22;
            this.btnVerContraseña.UseVisualStyleBackColor = true;
            this.btnVerContraseña.Click += new System.EventHandler(this.btnVerContraseña_Click);
            // 
            // groupBoxTipoUsuario
            // 
            this.groupBoxTipoUsuario.Controls.Add(this.rdEmpleado);
            this.groupBoxTipoUsuario.Controls.Add(this.rdAdministrativo);
            this.groupBoxTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.groupBoxTipoUsuario.Location = new System.Drawing.Point(304, 205);
            this.groupBoxTipoUsuario.Name = "groupBoxTipoUsuario";
            this.groupBoxTipoUsuario.Size = new System.Drawing.Size(365, 63);
            this.groupBoxTipoUsuario.TabIndex = 23;
            this.groupBoxTipoUsuario.TabStop = false;
            this.groupBoxTipoUsuario.Text = "TIPO DE USUARIO";
            // 
            // rdEmpleado
            // 
            this.rdEmpleado.AutoSize = true;
            this.rdEmpleado.Location = new System.Drawing.Point(218, 26);
            this.rdEmpleado.Name = "rdEmpleado";
            this.rdEmpleado.Size = new System.Drawing.Size(116, 25);
            this.rdEmpleado.TabIndex = 0;
            this.rdEmpleado.TabStop = true;
            this.rdEmpleado.Text = "EMPLEADO";
            this.rdEmpleado.UseVisualStyleBackColor = true;
            // 
            // rdAdministrativo
            // 
            this.rdAdministrativo.AutoSize = true;
            this.rdAdministrativo.Location = new System.Drawing.Point(30, 26);
            this.rdAdministrativo.Name = "rdAdministrativo";
            this.rdAdministrativo.Size = new System.Drawing.Size(167, 25);
            this.rdAdministrativo.TabIndex = 0;
            this.rdAdministrativo.TabStop = true;
            this.rdAdministrativo.Text = "ADMINISTRATIVO";
            this.rdAdministrativo.UseVisualStyleBackColor = true;
            // 
            // AgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBoxTipoUsuario);
            this.Controls.Add(this.btnVerContraseña);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.comboEmpleado);
            this.Controls.Add(this.panelPasswordL);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panelIDActividaDL);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.panelImagen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AgregarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuarios";
            this.Load += new System.EventHandler(this.AgregarUsuarios_Load);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTipoUsuario.ResumeLayout(false);
            this.groupBoxTipoUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelIDActividaDL;
        public System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Panel panelPasswordL;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmpleado;
        public System.Windows.Forms.ComboBox comboEmpleado;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button btnVerContraseña;
        private System.Windows.Forms.GroupBox groupBoxTipoUsuario;
        public System.Windows.Forms.RadioButton rdEmpleado;
        public System.Windows.Forms.RadioButton rdAdministrativo;
    }
}