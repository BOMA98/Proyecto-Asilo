namespace PIA_TP_II_ASILO
{
    partial class MenuCentros
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
            this.panelBarraMenu = new System.Windows.Forms.Panel();
            this.lblCentro = new System.Windows.Forms.Label();
            this.panelcontenidoBotones = new System.Windows.Forms.Panel();
            this.btnEliminarActividad = new System.Windows.Forms.Button();
            this.btnEliminarCentro = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnModificarActividad = new System.Windows.Forms.Button();
            this.btnModificarCentro = new System.Windows.Forms.Button();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.txtBuscarCentro = new System.Windows.Forms.TextBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelDetector = new System.Windows.Forms.Panel();
            this.btnAsignarActividad = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.dgvCentros = new System.Windows.Forms.DataGridView();
            this.panelBuscarL = new System.Windows.Forms.Panel();
            this.btnBuscarCentro = new System.Windows.Forms.Button();
            this.dgvCentroActividades = new System.Windows.Forms.DataGridView();
            this.panelBarraMenu.SuspendLayout();
            this.panelcontenidoBotones.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraMenu
            // 
            this.panelBarraMenu.Controls.Add(this.lblCentro);
            this.panelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBarraMenu.Name = "panelBarraMenu";
            this.panelBarraMenu.Size = new System.Drawing.Size(448, 25);
            this.panelBarraMenu.TabIndex = 0;
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentro.Location = new System.Drawing.Point(180, 0);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(89, 24);
            this.lblCentro.TabIndex = 2;
            this.lblCentro.Text = "Centros";
            // 
            // panelcontenidoBotones
            // 
            this.panelcontenidoBotones.Controls.Add(this.dgvCentroActividades);
            this.panelcontenidoBotones.Controls.Add(this.btnEliminarActividad);
            this.panelcontenidoBotones.Controls.Add(this.btnEliminarCentro);
            this.panelcontenidoBotones.Controls.Add(this.btnAsignar);
            this.panelcontenidoBotones.Controls.Add(this.btnModificarActividad);
            this.panelcontenidoBotones.Controls.Add(this.btnModificarCentro);
            this.panelcontenidoBotones.Controls.Add(this.btnRegresarMenu);
            this.panelcontenidoBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelcontenidoBotones.Location = new System.Drawing.Point(448, 0);
            this.panelcontenidoBotones.Name = "panelcontenidoBotones";
            this.panelcontenidoBotones.Size = new System.Drawing.Size(175, 414);
            this.panelcontenidoBotones.TabIndex = 1;
            // 
            // btnEliminarActividad
            // 
            this.btnEliminarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnEliminarActividad.FlatAppearance.BorderSize = 0;
            this.btnEliminarActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEliminarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarActividad.Image = global::PIA_TP_II_ASILO.Properties.Resources.garbage;
            this.btnEliminarActividad.Location = new System.Drawing.Point(12, 186);
            this.btnEliminarActividad.Name = "btnEliminarActividad";
            this.btnEliminarActividad.Size = new System.Drawing.Size(150, 35);
            this.btnEliminarActividad.TabIndex = 2;
            this.btnEliminarActividad.Text = "Eliminar        ";
            this.btnEliminarActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarActividad.UseVisualStyleBackColor = false;
            this.btnEliminarActividad.Visible = false;
            this.btnEliminarActividad.Click += new System.EventHandler(this.btnEliminarActividad_Click);
            // 
            // btnEliminarCentro
            // 
            this.btnEliminarCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnEliminarCentro.FlatAppearance.BorderSize = 0;
            this.btnEliminarCentro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEliminarCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCentro.Image = global::PIA_TP_II_ASILO.Properties.Resources.garbage;
            this.btnEliminarCentro.Location = new System.Drawing.Point(12, 137);
            this.btnEliminarCentro.Name = "btnEliminarCentro";
            this.btnEliminarCentro.Size = new System.Drawing.Size(150, 35);
            this.btnEliminarCentro.TabIndex = 2;
            this.btnEliminarCentro.Text = "Eliminar        ";
            this.btnEliminarCentro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarCentro.UseVisualStyleBackColor = false;
            this.btnEliminarCentro.Visible = false;
            this.btnEliminarCentro.Click += new System.EventHandler(this.btnEliminarCentro_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Image = global::PIA_TP_II_ASILO.Properties.Resources.file;
            this.btnAsignar.Location = new System.Drawing.Point(12, 88);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(150, 35);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar        ";
            this.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnModificarActividad
            // 
            this.btnModificarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnModificarActividad.FlatAppearance.BorderSize = 0;
            this.btnModificarActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnModificarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarActividad.Image = global::PIA_TP_II_ASILO.Properties.Resources.edit;
            this.btnModificarActividad.Location = new System.Drawing.Point(12, 137);
            this.btnModificarActividad.Name = "btnModificarActividad";
            this.btnModificarActividad.Size = new System.Drawing.Size(150, 35);
            this.btnModificarActividad.TabIndex = 2;
            this.btnModificarActividad.Text = "Modificar    ";
            this.btnModificarActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarActividad.UseVisualStyleBackColor = false;
            this.btnModificarActividad.Visible = false;
            this.btnModificarActividad.Click += new System.EventHandler(this.btnModificarActividad_Click);
            // 
            // btnModificarCentro
            // 
            this.btnModificarCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnModificarCentro.FlatAppearance.BorderSize = 0;
            this.btnModificarCentro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnModificarCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCentro.Image = global::PIA_TP_II_ASILO.Properties.Resources.edit;
            this.btnModificarCentro.Location = new System.Drawing.Point(12, 88);
            this.btnModificarCentro.Name = "btnModificarCentro";
            this.btnModificarCentro.Size = new System.Drawing.Size(150, 35);
            this.btnModificarCentro.TabIndex = 2;
            this.btnModificarCentro.Text = "Modificar    ";
            this.btnModificarCentro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarCentro.UseVisualStyleBackColor = false;
            this.btnModificarCentro.Visible = false;
            this.btnModificarCentro.Click += new System.EventHandler(this.btnModificarCentro_Click);
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.btnRegresarMenu.FlatAppearance.BorderSize = 0;
            this.btnRegresarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegresarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenu.Image = global::PIA_TP_II_ASILO.Properties.Resources.backspace_arrow;
            this.btnRegresarMenu.Location = new System.Drawing.Point(12, 364);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(150, 35);
            this.btnRegresarMenu.TabIndex = 2;
            this.btnRegresarMenu.Text = "Cancelar    ";
            this.btnRegresarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresarMenu.UseVisualStyleBackColor = false;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // txtBuscarCentro
            // 
            this.txtBuscarCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.txtBuscarCentro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCentro.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarCentro.Location = new System.Drawing.Point(11, 25);
            this.txtBuscarCentro.MaxLength = 5;
            this.txtBuscarCentro.Name = "txtBuscarCentro";
            this.txtBuscarCentro.Size = new System.Drawing.Size(370, 20);
            this.txtBuscarCentro.TabIndex = 2;
            this.txtBuscarCentro.Text = "BUSCAR";
            this.txtBuscarCentro.Enter += new System.EventHandler(this.txtBuscarCentro_Enter);
            this.txtBuscarCentro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCentro_KeyPress);
            this.txtBuscarCentro.Leave += new System.EventHandler(this.txtBuscarCentro_Leave);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panelDetector);
            this.panelContenido.Controls.Add(this.btnAsignarActividad);
            this.panelContenido.Controls.Add(this.btnCentro);
            this.panelContenido.Controls.Add(this.dgvCentros);
            this.panelContenido.Controls.Add(this.panelBuscarL);
            this.panelContenido.Controls.Add(this.btnBuscarCentro);
            this.panelContenido.Controls.Add(this.txtBuscarCentro);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenido.Location = new System.Drawing.Point(0, 25);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(442, 389);
            this.panelContenido.TabIndex = 4;
            // 
            // panelDetector
            // 
            this.panelDetector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelDetector.Location = new System.Drawing.Point(11, 384);
            this.panelDetector.Name = "panelDetector";
            this.panelDetector.Size = new System.Drawing.Size(85, 5);
            this.panelDetector.TabIndex = 26;
            // 
            // btnAsignarActividad
            // 
            this.btnAsignarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnAsignarActividad.FlatAppearance.BorderSize = 0;
            this.btnAsignarActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAsignarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarActividad.Location = new System.Drawing.Point(103, 351);
            this.btnAsignarActividad.Name = "btnAsignarActividad";
            this.btnAsignarActividad.Size = new System.Drawing.Size(160, 35);
            this.btnAsignarActividad.TabIndex = 25;
            this.btnAsignarActividad.Text = "Asignar Actividad";
            this.btnAsignarActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignarActividad.UseVisualStyleBackColor = false;
            this.btnAsignarActividad.Click += new System.EventHandler(this.btnAsignarActividad_Click);
            // 
            // btnCentro
            // 
            this.btnCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.btnCentro.FlatAppearance.BorderSize = 0;
            this.btnCentro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro.Location = new System.Drawing.Point(11, 351);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(85, 35);
            this.btnCentro.TabIndex = 24;
            this.btnCentro.Text = "Centros";
            this.btnCentro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCentro.UseVisualStyleBackColor = false;
            this.btnCentro.Click += new System.EventHandler(this.btnCentro_Click);
            // 
            // dgvCentros
            // 
            this.dgvCentros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCentros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.dgvCentros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCentros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCentros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCentros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCentros.ColumnHeadersHeight = 30;
            this.dgvCentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCentros.EnableHeadersVisualStyles = false;
            this.dgvCentros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dgvCentros.Location = new System.Drawing.Point(11, 63);
            this.dgvCentros.Name = "dgvCentros";
            this.dgvCentros.ReadOnly = true;
            this.dgvCentros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCentros.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCentros.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCentros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCentros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCentros.Size = new System.Drawing.Size(420, 282);
            this.dgvCentros.TabIndex = 5;
            this.dgvCentros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCentros_CellContentClick);
            // 
            // panelBuscarL
            // 
            this.panelBuscarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelBuscarL.Location = new System.Drawing.Point(10, 46);
            this.panelBuscarL.Name = "panelBuscarL";
            this.panelBuscarL.Size = new System.Drawing.Size(420, 2);
            this.panelBuscarL.TabIndex = 4;
            // 
            // btnBuscarCentro
            // 
            this.btnBuscarCentro.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCentro.FlatAppearance.BorderSize = 0;
            this.btnBuscarCentro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBuscarCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCentro.Image = global::PIA_TP_II_ASILO.Properties.Resources.search;
            this.btnBuscarCentro.Location = new System.Drawing.Point(386, 11);
            this.btnBuscarCentro.Name = "btnBuscarCentro";
            this.btnBuscarCentro.Size = new System.Drawing.Size(44, 35);
            this.btnBuscarCentro.TabIndex = 2;
            this.btnBuscarCentro.UseVisualStyleBackColor = false;
            this.btnBuscarCentro.Click += new System.EventHandler(this.btnBuscarCentro_Click);
            // 
            // dgvCentroActividades
            // 
            this.dgvCentroActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.dgvCentroActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCentroActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentroActividades.Location = new System.Drawing.Point(147, 3);
            this.dgvCentroActividades.Name = "dgvCentroActividades";
            this.dgvCentroActividades.Size = new System.Drawing.Size(25, 23);
            this.dgvCentroActividades.TabIndex = 3;
            this.dgvCentroActividades.Visible = false;
            // 
            // MenuCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarraMenu);
            this.Controls.Add(this.panelcontenidoBotones);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MenuCentros";
            this.Size = new System.Drawing.Size(623, 414);
            this.panelBarraMenu.ResumeLayout(false);
            this.panelBarraMenu.PerformLayout();
            this.panelcontenidoBotones.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraMenu;
        private System.Windows.Forms.Panel panelcontenidoBotones;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Button btnBuscarCentro;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelBuscarL;
        public System.Windows.Forms.Button btnRegresarMenu;
        public System.Windows.Forms.Button btnModificarCentro;
        public System.Windows.Forms.Button btnEliminarCentro;
        public System.Windows.Forms.TextBox txtBuscarCentro;
        private System.Windows.Forms.Panel panelDetector;
        public System.Windows.Forms.Button btnAsignarActividad;
        public System.Windows.Forms.Button btnCentro;
        public System.Windows.Forms.Button btnEliminarActividad;
        public System.Windows.Forms.Button btnModificarActividad;
        public System.Windows.Forms.Button btnAsignar;
        public System.Windows.Forms.DataGridView dgvCentros;
        private System.Windows.Forms.DataGridView dgvCentroActividades;

    }
}
