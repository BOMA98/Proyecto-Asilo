namespace PIA_TP_II_ASILO
{
    partial class OtorgarApoyos
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
            this.picboxOtorgarApoyo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAdulto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboApoyo = new System.Windows.Forms.ComboBox();
            this.panelIDActividaDL = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtVerificar = new System.Windows.Forms.TextBox();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOtorgarApoyo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelImagen.Controls.Add(this.picboxOtorgarApoyo);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(295, 325);
            this.panelImagen.TabIndex = 0;
            // 
            // picboxOtorgarApoyo
            // 
            this.picboxOtorgarApoyo.Image = global::PIA_TP_II_ASILO.Properties.Resources.solidarity;
            this.picboxOtorgarApoyo.Location = new System.Drawing.Point(19, 34);
            this.picboxOtorgarApoyo.Name = "picboxOtorgarApoyo";
            this.picboxOtorgarApoyo.Size = new System.Drawing.Size(256, 256);
            this.picboxOtorgarApoyo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxOtorgarApoyo.TabIndex = 0;
            this.picboxOtorgarApoyo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ADULTO:";
            // 
            // comboAdulto
            // 
            this.comboAdulto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboAdulto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAdulto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAdulto.ForeColor = System.Drawing.Color.White;
            this.comboAdulto.FormattingEnabled = true;
            this.comboAdulto.Location = new System.Drawing.Point(321, 83);
            this.comboAdulto.Name = "comboAdulto";
            this.comboAdulto.Size = new System.Drawing.Size(365, 29);
            this.comboAdulto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "APOYO:";
            // 
            // comboApoyo
            // 
            this.comboApoyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboApoyo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboApoyo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboApoyo.ForeColor = System.Drawing.Color.White;
            this.comboApoyo.FormattingEnabled = true;
            this.comboApoyo.Location = new System.Drawing.Point(321, 150);
            this.comboApoyo.Name = "comboApoyo";
            this.comboApoyo.Size = new System.Drawing.Size(365, 29);
            this.comboApoyo.TabIndex = 17;
            // 
            // panelIDActividaDL
            // 
            this.panelIDActividaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelIDActividaDL.Location = new System.Drawing.Point(321, 227);
            this.panelIDActividaDL.Name = "panelIDActividaDL";
            this.panelIDActividaDL.Size = new System.Drawing.Size(365, 2);
            this.panelIDActividaDL.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(321, 207);
            this.txtDescripcion.MaxLength = 5;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(365, 20);
            this.txtDescripcion.TabIndex = 19;
            this.txtDescripcion.Text = "DESCRIPCION";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::PIA_TP_II_ASILO.Properties.Resources.x;
            this.BtnCerrar.Location = new System.Drawing.Point(690, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 22;
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
            this.btnCancelar.Location = new System.Drawing.Point(537, 266);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 35);
            this.btnCancelar.TabIndex = 24;
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
            this.btnGuardar.Location = new System.Drawing.Point(347, 266);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtVerificar
            // 
            this.txtVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtVerificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerificar.ForeColor = System.Drawing.Color.DimGray;
            this.txtVerificar.Location = new System.Drawing.Point(321, 230);
            this.txtVerificar.MaxLength = 5;
            this.txtVerificar.Name = "txtVerificar";
            this.txtVerificar.Size = new System.Drawing.Size(365, 20);
            this.txtVerificar.TabIndex = 19;
            this.txtVerificar.Visible = false;
            // 
            // OtorgarApoyos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(715, 325);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.panelIDActividaDL);
            this.Controls.Add(this.txtVerificar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboApoyo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAdulto);
            this.Controls.Add(this.panelImagen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OtorgarApoyos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtorgarApoyos";
            this.Load += new System.EventHandler(this.OtorgarApoyos_Load);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOtorgarApoyo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox picboxOtorgarApoyo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboAdulto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboApoyo;
        private System.Windows.Forms.Panel panelIDActividaDL;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtVerificar;
    }
}