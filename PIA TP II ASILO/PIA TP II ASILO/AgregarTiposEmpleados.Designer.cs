namespace PIA_TP_II_ASILO
{
    partial class AgregarTiposEmpleados
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
            this.picboxTipoEmpleado = new System.Windows.Forms.PictureBox();
            this.panelNombreL = new System.Windows.Forms.Panel();
            this.panelIDActividaDL = new System.Windows.Forms.Panel();
            this.txtTipoEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdTipoEmpleado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTipoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelImagen.Controls.Add(this.picboxTipoEmpleado);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(297, 320);
            this.panelImagen.TabIndex = 0;
            // 
            // picboxTipoEmpleado
            // 
            this.picboxTipoEmpleado.Image = global::PIA_TP_II_ASILO.Properties.Resources.employees;
            this.picboxTipoEmpleado.Location = new System.Drawing.Point(20, 32);
            this.picboxTipoEmpleado.Name = "picboxTipoEmpleado";
            this.picboxTipoEmpleado.Size = new System.Drawing.Size(256, 256);
            this.picboxTipoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxTipoEmpleado.TabIndex = 0;
            this.picboxTipoEmpleado.TabStop = false;
            // 
            // panelNombreL
            // 
            this.panelNombreL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelNombreL.Location = new System.Drawing.Point(322, 151);
            this.panelNombreL.Name = "panelNombreL";
            this.panelNombreL.Size = new System.Drawing.Size(365, 2);
            this.panelNombreL.TabIndex = 8;
            // 
            // panelIDActividaDL
            // 
            this.panelIDActividaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelIDActividaDL.Location = new System.Drawing.Point(322, 91);
            this.panelIDActividaDL.Name = "panelIDActividaDL";
            this.panelIDActividaDL.Size = new System.Drawing.Size(365, 2);
            this.panelIDActividaDL.TabIndex = 9;
            // 
            // txtTipoEmpleado
            // 
            this.txtTipoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtTipoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtTipoEmpleado.Location = new System.Drawing.Point(322, 131);
            this.txtTipoEmpleado.MaxLength = 20;
            this.txtTipoEmpleado.Name = "txtTipoEmpleado";
            this.txtTipoEmpleado.Size = new System.Drawing.Size(365, 20);
            this.txtTipoEmpleado.TabIndex = 6;
            this.txtTipoEmpleado.Text = "TIPO DE EMPLEADO";
            this.txtTipoEmpleado.Enter += new System.EventHandler(this.txtTipoEmpleado_Enter);
            this.txtTipoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoEmpleado_KeyPress);
            this.txtTipoEmpleado.Leave += new System.EventHandler(this.txtTipoEmpleado_Leave);
            // 
            // txtIdTipoEmpleado
            // 
            this.txtIdTipoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtIdTipoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdTipoEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdTipoEmpleado.Location = new System.Drawing.Point(322, 71);
            this.txtIdTipoEmpleado.MaxLength = 6;
            this.txtIdTipoEmpleado.Name = "txtIdTipoEmpleado";
            this.txtIdTipoEmpleado.Size = new System.Drawing.Size(365, 20);
            this.txtIdTipoEmpleado.TabIndex = 7;
            this.txtIdTipoEmpleado.Text = "ID TIPO DE EMPLEADO";
            this.txtIdTipoEmpleado.Enter += new System.EventHandler(this.txtIdTipoEmpleado_Enter);
            this.txtIdTipoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTipoEmpleado_KeyPress);
            this.txtIdTipoEmpleado.Leave += new System.EventHandler(this.txtIdTipoEmpleado_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::PIA_TP_II_ASILO.Properties.Resources.forbidden;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(536, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 35);
            this.btnCancelar.TabIndex = 12;
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
            this.btnGuardar.Location = new System.Drawing.Point(361, 253);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 11;
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
            this.BtnCerrar.Location = new System.Drawing.Point(696, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // AgregarTiposEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(720, 320);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.panelNombreL);
            this.Controls.Add(this.panelIDActividaDL);
            this.Controls.Add(this.txtTipoEmpleado);
            this.Controls.Add(this.txtIdTipoEmpleado);
            this.Controls.Add(this.panelImagen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AgregarTiposEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarTiposEmpleados";
            this.Load += new System.EventHandler(this.AgregarTiposEmpleados_Load);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTipoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox picboxTipoEmpleado;
        private System.Windows.Forms.Panel panelNombreL;
        private System.Windows.Forms.Panel panelIDActividaDL;
        public System.Windows.Forms.TextBox txtTipoEmpleado;
        public System.Windows.Forms.TextBox txtIdTipoEmpleado;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button BtnCerrar;
    }
}