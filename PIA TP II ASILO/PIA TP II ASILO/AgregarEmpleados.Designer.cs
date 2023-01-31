namespace PIA_TP_II_ASILO
{
    partial class AgregarEmpleados
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
            this.picboxEmpleado = new System.Windows.Forms.PictureBox();
            this.panelTipoEmpleado = new System.Windows.Forms.Panel();
            this.panelIDL = new System.Windows.Forms.Panel();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelnOMBREl = new System.Windows.Forms.Panel();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.panelApellidoPL = new System.Windows.Forms.Panel();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.panelApellidoML = new System.Windows.Forms.Panel();
            this.comboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.comboNacionalidad = new System.Windows.Forms.ComboBox();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.comboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.panelDomicilioL = new System.Windows.Forms.Panel();
            this.comboCentro = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpleado)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelImagen.Controls.Add(this.picboxEmpleado);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(295, 485);
            this.panelImagen.TabIndex = 0;
            // 
            // picboxEmpleado
            // 
            this.picboxEmpleado.Image = global::PIA_TP_II_ASILO.Properties.Resources.man__3_;
            this.picboxEmpleado.Location = new System.Drawing.Point(19, 114);
            this.picboxEmpleado.Name = "picboxEmpleado";
            this.picboxEmpleado.Size = new System.Drawing.Size(256, 256);
            this.picboxEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxEmpleado.TabIndex = 0;
            this.picboxEmpleado.TabStop = false;
            // 
            // panelTipoEmpleado
            // 
            this.panelTipoEmpleado.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTipoEmpleado.Location = new System.Drawing.Point(1135, 0);
            this.panelTipoEmpleado.Name = "panelTipoEmpleado";
            this.panelTipoEmpleado.Size = new System.Drawing.Size(0, 485);
            this.panelTipoEmpleado.TabIndex = 1;
            // 
            // panelIDL
            // 
            this.panelIDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelIDL.Location = new System.Drawing.Point(323, 80);
            this.panelIDL.Name = "panelIDL";
            this.panelIDL.Size = new System.Drawing.Size(365, 2);
            this.panelIDL.TabIndex = 9;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdEmpleado.Location = new System.Drawing.Point(323, 60);
            this.txtIdEmpleado.MaxLength = 5;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(365, 20);
            this.txtIdEmpleado.TabIndex = 8;
            this.txtIdEmpleado.Text = "ID EMPLEADO";
            this.txtIdEmpleado.Enter += new System.EventHandler(this.txtIdEmpleado_Enter);
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEmpleado_KeyPress);
            this.txtIdEmpleado.Leave += new System.EventHandler(this.txtIdEmpleado_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(323, 112);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(365, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panelnOMBREl
            // 
            this.panelnOMBREl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelnOMBREl.Location = new System.Drawing.Point(323, 132);
            this.panelnOMBREl.Name = "panelnOMBREl";
            this.panelnOMBREl.Size = new System.Drawing.Size(365, 2);
            this.panelnOMBREl.TabIndex = 9;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(323, 165);
            this.txtApellidoPaterno.MaxLength = 20;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(365, 20);
            this.txtApellidoPaterno.TabIndex = 8;
            this.txtApellidoPaterno.Text = "APELLIDO PATERNO";
            this.txtApellidoPaterno.Enter += new System.EventHandler(this.txtApellidoPaterno_Enter);
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            this.txtApellidoPaterno.Leave += new System.EventHandler(this.txtApellidoPaterno_Leave);
            // 
            // panelApellidoPL
            // 
            this.panelApellidoPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelApellidoPL.Location = new System.Drawing.Point(323, 185);
            this.panelApellidoPL.Name = "panelApellidoPL";
            this.panelApellidoPL.Size = new System.Drawing.Size(365, 2);
            this.panelApellidoPL.TabIndex = 9;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(323, 221);
            this.txtApellidoMaterno.MaxLength = 20;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(365, 20);
            this.txtApellidoMaterno.TabIndex = 8;
            this.txtApellidoMaterno.Text = "APELLIDO MATERNO";
            this.txtApellidoMaterno.Enter += new System.EventHandler(this.txtApellidoMaterno_Enter);
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            this.txtApellidoMaterno.Leave += new System.EventHandler(this.txtApellidoMaterno_Leave);
            // 
            // panelApellidoML
            // 
            this.panelApellidoML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelApellidoML.Location = new System.Drawing.Point(323, 241);
            this.panelApellidoML.Name = "panelApellidoML";
            this.panelApellidoML.Size = new System.Drawing.Size(365, 2);
            this.panelApellidoML.TabIndex = 9;
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEstadoCivil.ForeColor = System.Drawing.Color.White;
            this.comboEstadoCivil.FormattingEnabled = true;
            this.comboEstadoCivil.Location = new System.Drawing.Point(721, 63);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.Size = new System.Drawing.Size(365, 29);
            this.comboEstadoCivil.TabIndex = 10;
            // 
            // comboNacionalidad
            // 
            this.comboNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboNacionalidad.ForeColor = System.Drawing.Color.White;
            this.comboNacionalidad.FormattingEnabled = true;
            this.comboNacionalidad.Location = new System.Drawing.Point(721, 125);
            this.comboNacionalidad.Name = "comboNacionalidad";
            this.comboNacionalidad.Size = new System.Drawing.Size(365, 29);
            this.comboNacionalidad.TabIndex = 10;
            // 
            // comboTurno
            // 
            this.comboTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTurno.ForeColor = System.Drawing.Color.White;
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(721, 187);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(365, 29);
            this.comboTurno.TabIndex = 10;
            // 
            // comboTipoEmpleado
            // 
            this.comboTipoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipoEmpleado.ForeColor = System.Drawing.Color.White;
            this.comboTipoEmpleado.FormattingEnabled = true;
            this.comboTipoEmpleado.Location = new System.Drawing.Point(721, 249);
            this.comboTipoEmpleado.Name = "comboTipoEmpleado";
            this.comboTipoEmpleado.Size = new System.Drawing.Size(365, 29);
            this.comboTipoEmpleado.TabIndex = 10;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.ForeColor = System.Drawing.Color.DimGray;
            this.txtDomicilio.Location = new System.Drawing.Point(323, 274);
            this.txtDomicilio.MaxLength = 30;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(365, 20);
            this.txtDomicilio.TabIndex = 8;
            this.txtDomicilio.Text = "DOMICILIO";
            this.txtDomicilio.Enter += new System.EventHandler(this.txtDomicilio_Enter);
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            this.txtDomicilio.Leave += new System.EventHandler(this.txtDomicilio_Leave);
            // 
            // panelDomicilioL
            // 
            this.panelDomicilioL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelDomicilioL.Location = new System.Drawing.Point(323, 294);
            this.panelDomicilioL.Name = "panelDomicilioL";
            this.panelDomicilioL.Size = new System.Drawing.Size(365, 2);
            this.panelDomicilioL.TabIndex = 9;
            // 
            // comboCentro
            // 
            this.comboCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCentro.ForeColor = System.Drawing.Color.White;
            this.comboCentro.FormattingEnabled = true;
            this.comboCentro.Location = new System.Drawing.Point(721, 311);
            this.comboCentro.Name = "comboCentro";
            this.comboCentro.Size = new System.Drawing.Size(365, 29);
            this.comboCentro.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::PIA_TP_II_ASILO.Properties.Resources.forbidden;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(737, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 35);
            this.btnCancelar.TabIndex = 13;
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
            this.btnGuardar.Location = new System.Drawing.Point(547, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 12;
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
            this.BtnCerrar.Location = new System.Drawing.Point(1111, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "ESTADO CIVIL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "NACIONALIDAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "TURNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "TIPO DE EMPLEADO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "CENTRO:";
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rdFemenino);
            this.groupBoxSexo.Controls.Add(this.rdMasculino);
            this.groupBoxSexo.ForeColor = System.Drawing.Color.White;
            this.groupBoxSexo.Location = new System.Drawing.Point(323, 322);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(365, 63);
            this.groupBoxSexo.TabIndex = 15;
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
            // AgregarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1135, 485);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboEstadoCivil);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.comboCentro);
            this.Controls.Add(this.comboTipoEmpleado);
            this.Controls.Add(this.comboTurno);
            this.Controls.Add(this.comboNacionalidad);
            this.Controls.Add(this.panelDomicilioL);
            this.Controls.Add(this.panelApellidoML);
            this.Controls.Add(this.panelApellidoPL);
            this.Controls.Add(this.panelnOMBREl);
            this.Controls.Add(this.panelIDL);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.panelTipoEmpleado);
            this.Controls.Add(this.panelImagen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AgregarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEmpleados";
            this.Load += new System.EventHandler(this.AgregarEmpleados_Load);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpleado)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox picboxEmpleado;
        private System.Windows.Forms.Panel panelTipoEmpleado;
        private System.Windows.Forms.Panel panelIDL;
        public System.Windows.Forms.TextBox txtIdEmpleado;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panelnOMBREl;
        public System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Panel panelApellidoPL;
        public System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Panel panelApellidoML;
        public System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Panel panelDomicilioL;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.ComboBox comboEstadoCivil;
        public System.Windows.Forms.ComboBox comboNacionalidad;
        public System.Windows.Forms.ComboBox comboTurno;
        public System.Windows.Forms.ComboBox comboTipoEmpleado;
        public System.Windows.Forms.ComboBox comboCentro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        public System.Windows.Forms.RadioButton rdFemenino;
        public System.Windows.Forms.RadioButton rdMasculino;
    }
}