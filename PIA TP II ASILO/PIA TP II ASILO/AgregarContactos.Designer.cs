namespace PIA_TP_II_ASILO
{
    partial class AgregarContactos
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
            this.picboxContactos = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboParentesco = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxContactos)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelImagen.Controls.Add(this.picboxContactos);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(290, 485);
            this.panelImagen.TabIndex = 0;
            // 
            // picboxContactos
            // 
            this.picboxContactos.Image = global::PIA_TP_II_ASILO.Properties.Resources.contacts;
            this.picboxContactos.Location = new System.Drawing.Point(17, 114);
            this.picboxContactos.Name = "picboxContactos";
            this.picboxContactos.Size = new System.Drawing.Size(256, 256);
            this.picboxContactos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxContactos.TabIndex = 0;
            this.picboxContactos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(324, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 2);
            this.panel1.TabIndex = 7;
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtIdContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdContacto.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdContacto.Location = new System.Drawing.Point(324, 54);
            this.txtIdContacto.MaxLength = 5;
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(365, 20);
            this.txtIdContacto.TabIndex = 6;
            this.txtIdContacto.Text = "ID CONTACTO";
            this.txtIdContacto.Enter += new System.EventHandler(this.txtIdContacto_Enter);
            this.txtIdContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdContacto_KeyPress);
            this.txtIdContacto.Leave += new System.EventHandler(this.txtIdContacto_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(324, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 2);
            this.panel2.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(324, 98);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(365, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(324, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 2);
            this.panel3.TabIndex = 11;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoP.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoP.Location = new System.Drawing.Point(324, 141);
            this.txtApellidoP.MaxLength = 20;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(365, 20);
            this.txtApellidoP.TabIndex = 10;
            this.txtApellidoP.Text = "APELLIDO PATERNO";
            this.txtApellidoP.Enter += new System.EventHandler(this.txtApellidoP_Enter);
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            this.txtApellidoP.Leave += new System.EventHandler(this.txtApellidoP_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(324, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 2);
            this.panel4.TabIndex = 13;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoM.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoM.Location = new System.Drawing.Point(324, 183);
            this.txtApellidoM.MaxLength = 20;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(365, 20);
            this.txtApellidoM.TabIndex = 12;
            this.txtApellidoM.Text = "APELLIDO MATERNO";
            this.txtApellidoM.Enter += new System.EventHandler(this.txtApellidoM_Enter);
            this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoM_KeyPress);
            this.txtApellidoM.Leave += new System.EventHandler(this.txtApellidoM_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel5.Location = new System.Drawing.Point(324, 248);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 2);
            this.panel5.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(324, 228);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(365, 20);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.Text = "TELEFONO";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rdFemenino);
            this.groupBoxSexo.Controls.Add(this.rdMasculino);
            this.groupBoxSexo.ForeColor = System.Drawing.Color.White;
            this.groupBoxSexo.Location = new System.Drawing.Point(324, 272);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(365, 63);
            this.groupBoxSexo.TabIndex = 16;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "SEXO";
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Location = new System.Drawing.Point(212, 24);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(112, 25);
            this.rdFemenino.TabIndex = 0;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "FEMENINO";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(40, 24);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(126, 25);
            this.rdMasculino.TabIndex = 0;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "MASCULINO";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "PARENTESCO:";
            // 
            // comboParentesco
            // 
            this.comboParentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParentesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboParentesco.ForeColor = System.Drawing.Color.White;
            this.comboParentesco.FormattingEnabled = true;
            this.comboParentesco.Location = new System.Drawing.Point(324, 375);
            this.comboParentesco.Name = "comboParentesco";
            this.comboParentesco.Size = new System.Drawing.Size(365, 29);
            this.comboParentesco.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::PIA_TP_II_ASILO.Properties.Resources.forbidden;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(536, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 35);
            this.btnCancelar.TabIndex = 20;
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
            this.btnGuardar.Location = new System.Drawing.Point(361, 428);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 21;
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
            this.BtnCerrar.Location = new System.Drawing.Point(700, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // AgregarContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(725, 485);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboParentesco);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.panelImagen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AgregarContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarContactos";
            this.Load += new System.EventHandler(this.AgregarContactos_Load);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxContactos)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox picboxContactos;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        public System.Windows.Forms.RadioButton rdFemenino;
        public System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboParentesco;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button BtnCerrar;
    }
}