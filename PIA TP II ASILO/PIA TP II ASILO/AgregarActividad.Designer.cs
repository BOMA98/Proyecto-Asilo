namespace PIA_TP_II_ASILO
{
    partial class AgregarActividad
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
            this.picboxActividad = new System.Windows.Forms.PictureBox();
            this.txtIdActividad = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelIDActividaDL = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelNombreL = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelDescripcionL = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelImagen.Controls.Add(this.picboxActividad);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(300, 325);
            this.panelImagen.TabIndex = 0;
            // 
            // picboxActividad
            // 
            this.picboxActividad.Image = global::PIA_TP_II_ASILO.Properties.Resources.jigsaw;
            this.picboxActividad.Location = new System.Drawing.Point(22, 26);
            this.picboxActividad.Name = "picboxActividad";
            this.picboxActividad.Size = new System.Drawing.Size(256, 256);
            this.picboxActividad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxActividad.TabIndex = 0;
            this.picboxActividad.TabStop = false;
            // 
            // txtIdActividad
            // 
            this.txtIdActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtIdActividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdActividad.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdActividad.Location = new System.Drawing.Point(319, 56);
            this.txtIdActividad.MaxLength = 6;
            this.txtIdActividad.Name = "txtIdActividad";
            this.txtIdActividad.Size = new System.Drawing.Size(365, 20);
            this.txtIdActividad.TabIndex = 1;
            this.txtIdActividad.Text = "ID ACTIVIDAD";
            this.txtIdActividad.Enter += new System.EventHandler(this.txtIdActividad_Enter);
            this.txtIdActividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdActividad_KeyPress);
            this.txtIdActividad.Leave += new System.EventHandler(this.txtIdActividad_Leave);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::PIA_TP_II_ASILO.Properties.Resources.x;
            this.BtnCerrar.Location = new System.Drawing.Point(685, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelIDActividaDL
            // 
            this.panelIDActividaDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelIDActividaDL.Location = new System.Drawing.Point(319, 76);
            this.panelIDActividaDL.Name = "panelIDActividaDL";
            this.panelIDActividaDL.Size = new System.Drawing.Size(365, 2);
            this.panelIDActividaDL.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(319, 116);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(365, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panelNombreL
            // 
            this.panelNombreL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelNombreL.Location = new System.Drawing.Point(319, 136);
            this.panelNombreL.Name = "panelNombreL";
            this.panelNombreL.Size = new System.Drawing.Size(365, 2);
            this.panelNombreL.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(319, 176);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(365, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "DESCRIPCION";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // panelDescripcionL
            // 
            this.panelDescripcionL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelDescripcionL.Location = new System.Drawing.Point(319, 196);
            this.panelDescripcionL.Name = "panelDescripcionL";
            this.panelDescripcionL.Size = new System.Drawing.Size(365, 2);
            this.panelDescripcionL.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::PIA_TP_II_ASILO.Properties.Resources.forbidden;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(532, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 35);
            this.btnCancelar.TabIndex = 7;
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
            this.btnGuardar.Location = new System.Drawing.Point(357, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(710, 325);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelDescripcionL);
            this.Controls.Add(this.panelNombreL);
            this.Controls.Add(this.panelIDActividaDL);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdActividad);
            this.Controls.Add(this.panelImagen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AgregarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarActividad";
            this.Load += new System.EventHandler(this.AgregarActividad_Load);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox picboxActividad;
        public System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panelIDActividaDL;
        private System.Windows.Forms.Panel panelNombreL;
        private System.Windows.Forms.Panel panelDescripcionL;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtIdActividad;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDescripcion;
    }
}