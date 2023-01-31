namespace PIA_TP_II_ASILO
{
    partial class AgregarAdultos
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
            this.txtIdAdulto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCentro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboContacto = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelImagen.Controls.Add(this.pictureBox1);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(301, 542);
            this.panelImagen.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIA_TP_II_ASILO.Properties.Resources.grandparents;
            this.pictureBox1.Location = new System.Drawing.Point(22, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelIDActividaDL
            // 
            this.panelIDActividaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelIDActividaDL.Location = new System.Drawing.Point(329, 68);
            this.panelIDActividaDL.Name = "panelIDActividaDL";
            this.panelIDActividaDL.Size = new System.Drawing.Size(365, 2);
            this.panelIDActividaDL.TabIndex = 7;
            // 
            // txtIdAdulto
            // 
            this.txtIdAdulto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtIdAdulto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdAdulto.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdAdulto.Location = new System.Drawing.Point(329, 48);
            this.txtIdAdulto.MaxLength = 5;
            this.txtIdAdulto.Name = "txtIdAdulto";
            this.txtIdAdulto.Size = new System.Drawing.Size(365, 20);
            this.txtIdAdulto.TabIndex = 6;
            this.txtIdAdulto.Text = "ID ADULTO";
            this.txtIdAdulto.Enter += new System.EventHandler(this.txtIdAdulto_Enter);
            this.txtIdAdulto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdAdulto_KeyPress);
            this.txtIdAdulto.Leave += new System.EventHandler(this.txtIdAdulto_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(329, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 2);
            this.panel2.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(329, 92);
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
            this.panel3.Location = new System.Drawing.Point(329, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 2);
            this.panel3.TabIndex = 9;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoP.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoP.Location = new System.Drawing.Point(329, 136);
            this.txtApellidoP.MaxLength = 20;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(365, 20);
            this.txtApellidoP.TabIndex = 8;
            this.txtApellidoP.Text = "APELLIDO PATERNO";
            this.txtApellidoP.Enter += new System.EventHandler(this.txtApellidoP_Enter);
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            this.txtApellidoP.Leave += new System.EventHandler(this.txtApellidoP_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel4.Location = new System.Drawing.Point(329, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 2);
            this.panel4.TabIndex = 9;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoM.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoM.Location = new System.Drawing.Point(329, 180);
            this.txtApellidoM.MaxLength = 20;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(365, 20);
            this.txtApellidoM.TabIndex = 8;
            this.txtApellidoM.Text = "APELLIDO MATERNO";
            this.txtApellidoM.Enter += new System.EventHandler(this.txtApellidoM_Enter);
            this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoM_KeyPress);
            this.txtApellidoM.Leave += new System.EventHandler(this.txtApellidoM_Leave);
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rdFemenino);
            this.groupBoxSexo.Controls.Add(this.rdMasculino);
            this.groupBoxSexo.ForeColor = System.Drawing.Color.White;
            this.groupBoxSexo.Location = new System.Drawing.Point(329, 268);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "CENTRO:";
            // 
            // comboCentro
            // 
            this.comboCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCentro.ForeColor = System.Drawing.Color.White;
            this.comboCentro.FormattingEnabled = true;
            this.comboCentro.Location = new System.Drawing.Point(329, 434);
            this.comboCentro.Name = "comboCentro";
            this.comboCentro.Size = new System.Drawing.Size(365, 29);
            this.comboCentro.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "CONTACTO:";
            // 
            // comboContacto
            // 
            this.comboContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboContacto.ForeColor = System.Drawing.Color.White;
            this.comboContacto.FormattingEnabled = true;
            this.comboContacto.Location = new System.Drawing.Point(329, 364);
            this.comboContacto.Name = "comboContacto";
            this.comboContacto.Size = new System.Drawing.Size(365, 29);
            this.comboContacto.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel5.Location = new System.Drawing.Point(329, 246);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 2);
            this.panel5.TabIndex = 11;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.Location = new System.Drawing.Point(329, 226);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(365, 20);
            this.txtEdad.TabIndex = 10;
            this.txtEdad.Text = "EDAD";
            this.txtEdad.Enter += new System.EventHandler(this.txtEdad_Enter);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
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
            this.BtnCerrar.TabIndex = 21;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::PIA_TP_II_ASILO.Properties.Resources.forbidden;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(541, 489);
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
            this.btnGuardar.Location = new System.Drawing.Point(351, 489);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarAdultos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(725, 542);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCentro);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panelIDActividaDL);
            this.Controls.Add(this.txtIdAdulto);
            this.Controls.Add(this.panelImagen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AgregarAdultos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarAdultos";
            this.Load += new System.EventHandler(this.AgregarAdultos_Load);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelIDActividaDL;
        public System.Windows.Forms.TextBox txtIdAdulto;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        public System.Windows.Forms.RadioButton rdFemenino;
        public System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboCentro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboContacto;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtEdad;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button BtnCerrar;
    }
}