namespace PIA_TP_II_ASILO
{
    partial class Ayuda
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
            this.panelBarraMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAyuda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.panelBarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraMenu
            // 
            this.panelBarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelBarraMenu.Controls.Add(this.label3);
            this.panelBarraMenu.Controls.Add(this.BtnCerrar);
            this.panelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBarraMenu.Name = "panelBarraMenu";
            this.panelBarraMenu.Size = new System.Drawing.Size(480, 25);
            this.panelBarraMenu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "AYUDA";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::PIA_TP_II_ASILO.Properties.Resources.x;
            this.BtnCerrar.Location = new System.Drawing.Point(455, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 35;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "EN QUE PODEMOS AYUDARTE:";
            // 
            // comboAyuda
            // 
            this.comboAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.comboAyuda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAyuda.ForeColor = System.Drawing.Color.White;
            this.comboAyuda.FormattingEnabled = true;
            this.comboAyuda.Items.AddRange(new object[] {
            "SELECIONAR...",
            "COMO BUSCAR UN REGISTRO",
            "COMO AGREGAR UN REGISTRO",
            "COMO MODIFICAR UN REGISTRO",
            "COMO ELIMINAR UN REGISTRO",
            "COMO AGREGAR UN TIPO DE EMPLEADO",
            "COMO ASIGNAR ACTIVIDADES A UN CENTRO",
            "COMO OTORGAR APOYOS A UN HUSPED",
            "COMO ASIGNAR ACTIVIADES A UN HUESPED"});
            this.comboAyuda.Location = new System.Drawing.Point(60, 59);
            this.comboAyuda.Name = "comboAyuda";
            this.comboAyuda.Size = new System.Drawing.Size(365, 29);
            this.comboAyuda.TabIndex = 15;
            this.comboAyuda.SelectedIndexChanged += new System.EventHandler(this.comboAyuda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "MENSAJE:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.ForeColor = System.Drawing.Color.White;
            this.txtMensaje.Location = new System.Drawing.Point(12, 134);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(456, 244);
            this.txtMensaje.TabIndex = 18;
            this.txtMensaje.Text = "Seleccione una opcion para poder brindar informacion de ayuda";
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(480, 390);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAyuda);
            this.Controls.Add(this.panelBarraMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.panelBarraMenu.ResumeLayout(false);
            this.panelBarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraMenu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboAyuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensaje;
        public System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label3;
    }
}