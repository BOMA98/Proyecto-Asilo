namespace PIA_TP_II_ASILO
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panelMenuDesplegable = new System.Windows.Forms.Panel();
            this.panelBarraMenu = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.panelHoraSalir = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.timerTiempoYFecha = new System.Windows.Forms.Timer(this.components);
            this.menuActividades1 = new PIA_TP_II_ASILO.MenuActividades();
            this.menuApoyos1 = new PIA_TP_II_ASILO.MenuApoyos();
            this.menuContactos1 = new PIA_TP_II_ASILO.MenuContactos();
            this.menuAdultos1 = new PIA_TP_II_ASILO.MenuAdultos();
            this.menuEmpleados1 = new PIA_TP_II_ASILO.MenuEmpleados();
            this.menuUsuarios1 = new PIA_TP_II_ASILO.MenuUsuarios();
            this.menuCentros1 = new PIA_TP_II_ASILO.MenuCentros();
            this.btnCerrarSecion = new System.Windows.Forms.Button();
            this.picBoxFotoUsuario = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCentros = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnApoyos = new System.Windows.Forms.Button();
            this.btnContactos = new System.Windows.Forms.Button();
            this.btnAdultos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnDesplegarMenu = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panelMenuDesplegable.SuspendLayout();
            this.panelBarraMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelHoraSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFotoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuDesplegable
            // 
            this.panelMenuDesplegable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuDesplegable.Controls.Add(this.btnUsuarios);
            this.panelMenuDesplegable.Controls.Add(this.btnCentros);
            this.panelMenuDesplegable.Controls.Add(this.btnInfo);
            this.panelMenuDesplegable.Controls.Add(this.btnAyuda);
            this.panelMenuDesplegable.Controls.Add(this.btnActividades);
            this.panelMenuDesplegable.Controls.Add(this.btnApoyos);
            this.panelMenuDesplegable.Controls.Add(this.btnContactos);
            this.panelMenuDesplegable.Controls.Add(this.btnAdultos);
            this.panelMenuDesplegable.Controls.Add(this.btnEmpleados);
            this.panelMenuDesplegable.Controls.Add(this.btnDesplegarMenu);
            this.panelMenuDesplegable.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuDesplegable.Location = new System.Drawing.Point(0, 25);
            this.panelMenuDesplegable.Name = "panelMenuDesplegable";
            this.panelMenuDesplegable.Size = new System.Drawing.Size(45, 475);
            this.panelMenuDesplegable.TabIndex = 0;
            // 
            // panelBarraMenu
            // 
            this.panelBarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelBarraMenu.Controls.Add(this.btnMinimizar);
            this.panelBarraMenu.Controls.Add(this.BtnCerrar);
            this.panelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBarraMenu.Name = "panelBarraMenu";
            this.panelBarraMenu.Size = new System.Drawing.Size(665, 25);
            this.panelBarraMenu.TabIndex = 1;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelSubMenu.Controls.Add(this.panelHoraSalir);
            this.panelSubMenu.Controls.Add(this.lblCargo);
            this.panelSubMenu.Controls.Add(this.lblNombre);
            this.panelSubMenu.Controls.Add(this.picBoxFotoUsuario);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubMenu.Location = new System.Drawing.Point(45, 445);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(620, 55);
            this.panelSubMenu.TabIndex = 2;
            // 
            // panelHoraSalir
            // 
            this.panelHoraSalir.Controls.Add(this.lblFecha);
            this.panelHoraSalir.Controls.Add(this.lblHora);
            this.panelHoraSalir.Controls.Add(this.btnCerrarSecion);
            this.panelHoraSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHoraSalir.Location = new System.Drawing.Point(340, 0);
            this.panelHoraSalir.Name = "panelHoraSalir";
            this.panelHoraSalir.Size = new System.Drawing.Size(280, 55);
            this.panelHoraSalir.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(128, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "DD/MM/AA";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(116, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(105, 30);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00:00";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(59, 28);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(55, 18);
            this.lblCargo.TabIndex = 5;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(59, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // timerTiempoYFecha
            // 
            this.timerTiempoYFecha.Enabled = true;
            this.timerTiempoYFecha.Tick += new System.EventHandler(this.timerTiempoYFecha_Tick);
            // 
            // menuActividades1
            // 
            this.menuActividades1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuActividades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuActividades1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuActividades1.ForeColor = System.Drawing.Color.White;
            this.menuActividades1.Location = new System.Drawing.Point(45, 25);
            this.menuActividades1.Margin = new System.Windows.Forms.Padding(5);
            this.menuActividades1.Name = "menuActividades1";
            this.menuActividades1.Size = new System.Drawing.Size(620, 420);
            this.menuActividades1.TabIndex = 9;
            this.menuActividades1.Visible = false;
            // 
            // menuApoyos1
            // 
            this.menuApoyos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuApoyos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuApoyos1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuApoyos1.ForeColor = System.Drawing.Color.White;
            this.menuApoyos1.Location = new System.Drawing.Point(45, 25);
            this.menuApoyos1.Margin = new System.Windows.Forms.Padding(5);
            this.menuApoyos1.Name = "menuApoyos1";
            this.menuApoyos1.Size = new System.Drawing.Size(620, 420);
            this.menuApoyos1.TabIndex = 8;
            this.menuApoyos1.Visible = false;
            // 
            // menuContactos1
            // 
            this.menuContactos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuContactos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuContactos1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuContactos1.ForeColor = System.Drawing.Color.White;
            this.menuContactos1.Location = new System.Drawing.Point(45, 25);
            this.menuContactos1.Margin = new System.Windows.Forms.Padding(5);
            this.menuContactos1.Name = "menuContactos1";
            this.menuContactos1.Size = new System.Drawing.Size(620, 420);
            this.menuContactos1.TabIndex = 7;
            this.menuContactos1.Visible = false;
            // 
            // menuAdultos1
            // 
            this.menuAdultos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuAdultos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuAdultos1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuAdultos1.ForeColor = System.Drawing.Color.White;
            this.menuAdultos1.Location = new System.Drawing.Point(45, 25);
            this.menuAdultos1.Margin = new System.Windows.Forms.Padding(5);
            this.menuAdultos1.Name = "menuAdultos1";
            this.menuAdultos1.Size = new System.Drawing.Size(620, 420);
            this.menuAdultos1.TabIndex = 6;
            this.menuAdultos1.Visible = false;
            // 
            // menuEmpleados1
            // 
            this.menuEmpleados1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuEmpleados1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuEmpleados1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEmpleados1.ForeColor = System.Drawing.Color.White;
            this.menuEmpleados1.Location = new System.Drawing.Point(45, 25);
            this.menuEmpleados1.Margin = new System.Windows.Forms.Padding(5);
            this.menuEmpleados1.Name = "menuEmpleados1";
            this.menuEmpleados1.Size = new System.Drawing.Size(620, 420);
            this.menuEmpleados1.TabIndex = 5;
            this.menuEmpleados1.Visible = false;
            // 
            // menuUsuarios1
            // 
            this.menuUsuarios1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuUsuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUsuarios1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuarios1.ForeColor = System.Drawing.Color.White;
            this.menuUsuarios1.Location = new System.Drawing.Point(45, 25);
            this.menuUsuarios1.Margin = new System.Windows.Forms.Padding(5);
            this.menuUsuarios1.Name = "menuUsuarios1";
            this.menuUsuarios1.Size = new System.Drawing.Size(620, 420);
            this.menuUsuarios1.TabIndex = 4;
            this.menuUsuarios1.Visible = false;
            // 
            // menuCentros1
            // 
            this.menuCentros1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.menuCentros1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuCentros1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCentros1.ForeColor = System.Drawing.Color.White;
            this.menuCentros1.Location = new System.Drawing.Point(45, 25);
            this.menuCentros1.Margin = new System.Windows.Forms.Padding(5);
            this.menuCentros1.Name = "menuCentros1";
            this.menuCentros1.Size = new System.Drawing.Size(620, 420);
            this.menuCentros1.TabIndex = 3;
            // 
            // btnCerrarSecion
            // 
            this.btnCerrarSecion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSecion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnCerrarSecion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSecion.Image = global::PIA_TP_II_ASILO.Properties.Resources.exit1;
            this.btnCerrarSecion.Location = new System.Drawing.Point(227, 3);
            this.btnCerrarSecion.Name = "btnCerrarSecion";
            this.btnCerrarSecion.Size = new System.Drawing.Size(50, 50);
            this.btnCerrarSecion.TabIndex = 0;
            this.btnCerrarSecion.UseVisualStyleBackColor = true;
            this.btnCerrarSecion.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // picBoxFotoUsuario
            // 
            this.picBoxFotoUsuario.Image = global::PIA_TP_II_ASILO.Properties.Resources.user1;
            this.picBoxFotoUsuario.Location = new System.Drawing.Point(3, 3);
            this.picBoxFotoUsuario.Name = "picBoxFotoUsuario";
            this.picBoxFotoUsuario.Size = new System.Drawing.Size(50, 50);
            this.picBoxFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFotoUsuario.TabIndex = 3;
            this.picBoxFotoUsuario.TabStop = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = global::PIA_TP_II_ASILO.Properties.Resources.id_card2;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 83);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(175, 35);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "   Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCentros
            // 
            this.btnCentros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCentros.FlatAppearance.BorderSize = 0;
            this.btnCentros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnCentros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCentros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentros.Image = global::PIA_TP_II_ASILO.Properties.Resources.house;
            this.btnCentros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentros.Location = new System.Drawing.Point(0, 42);
            this.btnCentros.Name = "btnCentros";
            this.btnCentros.Size = new System.Drawing.Size(175, 35);
            this.btnCentros.TabIndex = 2;
            this.btnCentros.Text = "   Centros";
            this.btnCentros.UseVisualStyleBackColor = false;
            this.btnCentros.Click += new System.EventHandler(this.btnCentros_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Image = global::PIA_TP_II_ASILO.Properties.Resources.info;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 439);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(175, 35);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "        Acerca de ";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Image = global::PIA_TP_II_ASILO.Properties.Resources.question;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 398);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(175, 35);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.Image = global::PIA_TP_II_ASILO.Properties.Resources.runner;
            this.btnActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.Location = new System.Drawing.Point(0, 288);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(175, 35);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "         Actividades";
            this.btnActividades.UseVisualStyleBackColor = true;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnApoyos
            // 
            this.btnApoyos.FlatAppearance.BorderSize = 0;
            this.btnApoyos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnApoyos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnApoyos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApoyos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApoyos.Image = global::PIA_TP_II_ASILO.Properties.Resources.like;
            this.btnApoyos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApoyos.Location = new System.Drawing.Point(0, 247);
            this.btnApoyos.Name = "btnApoyos";
            this.btnApoyos.Size = new System.Drawing.Size(175, 35);
            this.btnApoyos.TabIndex = 2;
            this.btnApoyos.Text = " Apoyos";
            this.btnApoyos.UseVisualStyleBackColor = true;
            this.btnApoyos.Click += new System.EventHandler(this.btnApoyos_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.FlatAppearance.BorderSize = 0;
            this.btnContactos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnContactos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactos.Image = global::PIA_TP_II_ASILO.Properties.Resources.contact;
            this.btnContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactos.Location = new System.Drawing.Point(0, 206);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(175, 35);
            this.btnContactos.TabIndex = 2;
            this.btnContactos.Text = "       Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnAdultos
            // 
            this.btnAdultos.FlatAppearance.BorderSize = 0;
            this.btnAdultos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnAdultos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAdultos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdultos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdultos.Image = global::PIA_TP_II_ASILO.Properties.Resources.couple;
            this.btnAdultos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdultos.Location = new System.Drawing.Point(0, 165);
            this.btnAdultos.Name = "btnAdultos";
            this.btnAdultos.Size = new System.Drawing.Size(175, 35);
            this.btnAdultos.TabIndex = 2;
            this.btnAdultos.Text = "        Huéspedes";
            this.btnAdultos.UseVisualStyleBackColor = true;
            this.btnAdultos.Click += new System.EventHandler(this.btnAdultos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::PIA_TP_II_ASILO.Properties.Resources.network;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 124);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(175, 35);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "        Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDesplegarMenu
            // 
            this.btnDesplegarMenu.FlatAppearance.BorderSize = 0;
            this.btnDesplegarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnDesplegarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDesplegarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegarMenu.Image = global::PIA_TP_II_ASILO.Properties.Resources.menu;
            this.btnDesplegarMenu.Location = new System.Drawing.Point(6, 6);
            this.btnDesplegarMenu.Name = "btnDesplegarMenu";
            this.btnDesplegarMenu.Size = new System.Drawing.Size(30, 30);
            this.btnDesplegarMenu.TabIndex = 2;
            this.btnDesplegarMenu.UseVisualStyleBackColor = true;
            this.btnDesplegarMenu.Click += new System.EventHandler(this.btnDesplegarMenu_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::PIA_TP_II_ASILO.Properties.Resources.substract;
            this.btnMinimizar.Location = new System.Drawing.Point(612, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::PIA_TP_II_ASILO.Properties.Resources.x;
            this.BtnCerrar.Location = new System.Drawing.Point(640, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(665, 500);
            this.Controls.Add(this.menuActividades1);
            this.Controls.Add(this.menuApoyos1);
            this.Controls.Add(this.menuContactos1);
            this.Controls.Add(this.menuAdultos1);
            this.Controls.Add(this.menuEmpleados1);
            this.Controls.Add(this.menuUsuarios1);
            this.Controls.Add(this.menuCentros1);
            this.Controls.Add(this.panelSubMenu);
            this.Controls.Add(this.panelMenuDesplegable);
            this.Controls.Add(this.panelBarraMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelMenuDesplegable.ResumeLayout(false);
            this.panelBarraMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelSubMenu.PerformLayout();
            this.panelHoraSalir.ResumeLayout(false);
            this.panelHoraSalir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFotoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraMenu;
        private System.Windows.Forms.Button btnDesplegarMenu;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.PictureBox picBoxFotoUsuario;
        private MenuCentros menuCentros1;
        public System.Windows.Forms.Label lblCargo;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Panel panelMenuDesplegable;
        public System.Windows.Forms.Button btnCentros;
        private MenuUsuarios menuUsuarios1;
        private System.Windows.Forms.Button btnAdultos;
        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Button btnApoyos;
        private System.Windows.Forms.Button btnActividades;
        private MenuEmpleados menuEmpleados1;
        private MenuAdultos menuAdultos1;
        private MenuContactos menuContactos1;
        private MenuApoyos menuApoyos1;
        private MenuActividades menuActividades1;
        private System.Windows.Forms.Panel panelHoraSalir;
        private System.Windows.Forms.Button btnCerrarSecion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerTiempoYFecha;
        private System.Windows.Forms.Button btnInfo;
    }
}