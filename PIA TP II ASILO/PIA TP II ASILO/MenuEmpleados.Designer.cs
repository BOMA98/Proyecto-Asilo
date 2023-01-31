namespace PIA_TP_II_ASILO
{
    partial class MenuEmpleados
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnEliminarTiposEmpleados = new System.Windows.Forms.Button();
            this.btnModificarTiposEmpleados = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnRegresarEmpleado = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.panelBarraMenu = new System.Windows.Forms.Panel();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelDetector = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panelBuscarL = new System.Windows.Forms.Panel();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.btnTipoEmpleado = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelBotones.SuspendLayout();
            this.panelBarraMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.dgvUsuarios);
            this.panelBotones.Controls.Add(this.btnEliminarTiposEmpleados);
            this.panelBotones.Controls.Add(this.btnModificarTiposEmpleados);
            this.panelBotones.Controls.Add(this.btnEliminarEmpleado);
            this.panelBotones.Controls.Add(this.btnModificarEmpleado);
            this.panelBotones.Controls.Add(this.btnRegresarEmpleado);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(448, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(175, 414);
            this.panelBotones.TabIndex = 0;
            // 
            // btnEliminarTiposEmpleados
            // 
            this.btnEliminarTiposEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnEliminarTiposEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEliminarTiposEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEliminarTiposEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTiposEmpleados.Image = global::PIA_TP_II_ASILO.Properties.Resources.garbage;
            this.btnEliminarTiposEmpleados.Location = new System.Drawing.Point(12, 137);
            this.btnEliminarTiposEmpleados.Name = "btnEliminarTiposEmpleados";
            this.btnEliminarTiposEmpleados.Size = new System.Drawing.Size(150, 35);
            this.btnEliminarTiposEmpleados.TabIndex = 7;
            this.btnEliminarTiposEmpleados.Text = "Eliminar        ";
            this.btnEliminarTiposEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarTiposEmpleados.UseVisualStyleBackColor = false;
            this.btnEliminarTiposEmpleados.Visible = false;
            this.btnEliminarTiposEmpleados.Click += new System.EventHandler(this.btnEliminarTiposEmpleados_Click);
            // 
            // btnModificarTiposEmpleados
            // 
            this.btnModificarTiposEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnModificarTiposEmpleados.FlatAppearance.BorderSize = 0;
            this.btnModificarTiposEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnModificarTiposEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTiposEmpleados.Image = global::PIA_TP_II_ASILO.Properties.Resources.edit;
            this.btnModificarTiposEmpleados.Location = new System.Drawing.Point(12, 88);
            this.btnModificarTiposEmpleados.Name = "btnModificarTiposEmpleados";
            this.btnModificarTiposEmpleados.Size = new System.Drawing.Size(150, 35);
            this.btnModificarTiposEmpleados.TabIndex = 6;
            this.btnModificarTiposEmpleados.Text = "Modificar    ";
            this.btnModificarTiposEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarTiposEmpleados.UseVisualStyleBackColor = false;
            this.btnModificarTiposEmpleados.Visible = false;
            this.btnModificarTiposEmpleados.Click += new System.EventHandler(this.btnModificarTiposEmpleados_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Image = global::PIA_TP_II_ASILO.Properties.Resources.garbage;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(12, 137);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(150, 35);
            this.btnEliminarEmpleado.TabIndex = 5;
            this.btnEliminarEmpleado.Text = "Eliminar        ";
            this.btnEliminarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Visible = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnModificarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnModificarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEmpleado.Image = global::PIA_TP_II_ASILO.Properties.Resources.edit;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(12, 88);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(150, 35);
            this.btnModificarEmpleado.TabIndex = 3;
            this.btnModificarEmpleado.Text = "Modificar    ";
            this.btnModificarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Visible = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnRegresarEmpleado
            // 
            this.btnRegresarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnRegresarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnRegresarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegresarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarEmpleado.Image = global::PIA_TP_II_ASILO.Properties.Resources.backspace_arrow;
            this.btnRegresarEmpleado.Location = new System.Drawing.Point(12, 364);
            this.btnRegresarEmpleado.Name = "btnRegresarEmpleado";
            this.btnRegresarEmpleado.Size = new System.Drawing.Size(150, 35);
            this.btnRegresarEmpleado.TabIndex = 4;
            this.btnRegresarEmpleado.Text = "Cancelar    ";
            this.btnRegresarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresarEmpleado.UseVisualStyleBackColor = false;
            this.btnRegresarEmpleado.Click += new System.EventHandler(this.btnRegresarEmpleado_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Location = new System.Drawing.Point(10, 351);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(109, 35);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Empleados";
            this.btnCambiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // panelBarraMenu
            // 
            this.panelBarraMenu.Controls.Add(this.lblEmpleados);
            this.panelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBarraMenu.Name = "panelBarraMenu";
            this.panelBarraMenu.Size = new System.Drawing.Size(448, 25);
            this.panelBarraMenu.TabIndex = 1;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(166, 1);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(125, 24);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Empleados";
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panelDetector);
            this.panelContenido.Controls.Add(this.dgvEmpleados);
            this.panelContenido.Controls.Add(this.panelBuscarL);
            this.panelContenido.Controls.Add(this.btnBuscarEmpleado);
            this.panelContenido.Controls.Add(this.txtBuscarEmpleado);
            this.panelContenido.Controls.Add(this.btnTipoEmpleado);
            this.panelContenido.Controls.Add(this.btnCambiar);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenido.Location = new System.Drawing.Point(0, 25);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(442, 389);
            this.panelContenido.TabIndex = 2;
            // 
            // panelDetector
            // 
            this.panelDetector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelDetector.Location = new System.Drawing.Point(10, 384);
            this.panelDetector.Name = "panelDetector";
            this.panelDetector.Size = new System.Drawing.Size(109, 5);
            this.panelDetector.TabIndex = 10;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeight = 30;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(10, 63);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(421, 282);
            this.dgvEmpleados.TabIndex = 9;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // panelBuscarL
            // 
            this.panelBuscarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelBuscarL.Location = new System.Drawing.Point(10, 46);
            this.panelBuscarL.Name = "panelBuscarL";
            this.panelBuscarL.Size = new System.Drawing.Size(420, 2);
            this.panelBuscarL.TabIndex = 8;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.Image = global::PIA_TP_II_ASILO.Properties.Resources.search;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(386, 11);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(44, 35);
            this.btnBuscarEmpleado.TabIndex = 6;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.txtBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(11, 25);
            this.txtBuscarEmpleado.MaxLength = 5;
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(370, 20);
            this.txtBuscarEmpleado.TabIndex = 7;
            this.txtBuscarEmpleado.Text = "BUSCAR";
            this.txtBuscarEmpleado.Enter += new System.EventHandler(this.txtBuscarEmpleado_Enter);
            this.txtBuscarEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarEmpleado_KeyPress);
            this.txtBuscarEmpleado.Leave += new System.EventHandler(this.txtBuscarEmpleado_Leave);
            // 
            // btnTipoEmpleado
            // 
            this.btnTipoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnTipoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnTipoEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTipoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoEmpleado.Location = new System.Drawing.Point(125, 351);
            this.btnTipoEmpleado.Name = "btnTipoEmpleado";
            this.btnTipoEmpleado.Size = new System.Drawing.Size(162, 35);
            this.btnTipoEmpleado.TabIndex = 4;
            this.btnTipoEmpleado.Text = "Tipo de emplados";
            this.btnTipoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTipoEmpleado.UseVisualStyleBackColor = false;
            this.btnTipoEmpleado.Click += new System.EventHandler(this.btnTipoEmpleado_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(150, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(22, 22);
            this.dgvUsuarios.TabIndex = 11;
            this.dgvUsuarios.Visible = false;
            // 
            // MenuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarraMenu);
            this.Controls.Add(this.panelBotones);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MenuEmpleados";
            this.Size = new System.Drawing.Size(623, 414);
            this.panelBotones.ResumeLayout(false);
            this.panelBarraMenu.ResumeLayout(false);
            this.panelBarraMenu.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelBarraMenu;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblEmpleados;
        public System.Windows.Forms.Button btnEliminarEmpleado;
        public System.Windows.Forms.Button btnModificarEmpleado;
        public System.Windows.Forms.Button btnRegresarEmpleado;
        private System.Windows.Forms.Panel panelBuscarL;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        public System.Windows.Forms.Button btnCambiar;
        public System.Windows.Forms.Button btnEliminarTiposEmpleados;
        public System.Windows.Forms.Button btnModificarTiposEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.Panel panelDetector;
        public System.Windows.Forms.Button btnTipoEmpleado;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
