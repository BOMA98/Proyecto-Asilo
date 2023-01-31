using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace PIA_TP_II_ASILO
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public static string Cargo = string.Empty;
        public static int IdCargo = 0;

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MensajeSalirExit();

            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDesplegarMenu_Click(object sender, EventArgs e)
        {
            DesplegarMenu();
        }

        void DesplegarMenu()
        {
            if (panelMenuDesplegable.Width == 45)
            {
                panelMenuDesplegable.Width = 170;
            }
            else
            {
                panelMenuDesplegable.Width = 45;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Cargo = lblCargo.Text;
            menuCentros1.CargarDGVCentros();
        }

        private void btnCentros_Click(object sender, EventArgs e)
        {
            menuCentros1.CargarDGVCentros();

            if (menuUsuarios1.Visible)
            {
                menuUsuarios1.Visible = false;
                btnUsuarios.BackColor = Color.Transparent;

                menuCentros1.Visible = true;
                btnCentros.BackColor = Color.FromArgb(0, 102, 204); 
            }
            else if (menuEmpleados1.Visible)
            {
                menuEmpleados1.Visible = false;
                btnEmpleados.BackColor = Color.Transparent;

                menuCentros1.Visible = true;
                btnCentros.BackColor = Color.FromArgb(0, 102, 204); 
            }
            else if (menuAdultos1.Visible)
            {
                menuAdultos1.Visible = false;
                btnAdultos.BackColor = Color.Transparent;

                menuCentros1.Visible = true;
                btnCentros.BackColor = Color.FromArgb(0, 102, 204); 
            }
            else if (menuContactos1.Visible)
            {
                menuContactos1.Visible = false;
                btnContactos.BackColor = Color.Transparent;

                menuCentros1.Visible = true;
                btnCentros.BackColor = Color.FromArgb(0, 102, 204); 
            }
            else if (menuApoyos1.Visible)
            {
                menuApoyos1.Visible = false;
                btnApoyos.BackColor = Color.Transparent;

                menuCentros1.Visible = true;
                btnCentros.BackColor = Color.FromArgb(0, 102, 204); 
            }
            else if (menuActividades1.Visible)
            {
                menuActividades1.Visible = false;
                btnActividades.BackColor = Color.Transparent;

                menuCentros1.Visible = true;
                btnCentros.BackColor = Color.FromArgb(0, 102, 204); 
            }
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            menuUsuarios1.CargarDGVUsuarios();

            if (menuCentros1.Visible)
            {
                menuCentros1.Visible = false;
                btnCentros.BackColor = Color.Transparent;

                menuUsuarios1.Visible = true;
                btnUsuarios.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuEmpleados1.Visible)
            {
                menuEmpleados1.Visible = false;
                btnEmpleados.BackColor = Color.Transparent;

                menuUsuarios1.Visible = true;
                btnUsuarios.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuAdultos1.Visible)
            {
                menuAdultos1.Visible = false;
                btnAdultos.BackColor = Color.Transparent;

                menuUsuarios1.Visible = true;
                btnUsuarios.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuContactos1.Visible)
            {
                menuContactos1.Visible = false;
                btnContactos.BackColor = Color.Transparent;

                menuUsuarios1.Visible = true;
                btnUsuarios.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuApoyos1.Visible)
            {
                menuApoyos1.Visible = false;
                btnApoyos.BackColor = Color.Transparent;

                menuUsuarios1.Visible = true;
                btnUsuarios.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuActividades1.Visible)
            {
                menuActividades1.Visible = false;
                btnActividades.BackColor = Color.Transparent;

                menuUsuarios1.Visible = true;
                btnUsuarios.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            menuEmpleados1.CargarDGVEmpelados();

            if (menuCentros1.Visible)
            {
                menuCentros1.Visible = false;
                btnCentros.BackColor = Color.Transparent;

                menuEmpleados1.Visible = true;
                btnEmpleados.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuUsuarios1.Visible)
            {
                menuUsuarios1.Visible = false;
                btnUsuarios.BackColor = Color.Transparent;

                menuEmpleados1.Visible = true;
                btnEmpleados.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuAdultos1.Visible)
            {
                menuAdultos1.Visible = false;
                btnAdultos.BackColor = Color.Transparent;

                menuEmpleados1.Visible = true;
                btnEmpleados.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuContactos1.Visible)
            {
                menuContactos1.Visible = false;
                btnContactos.BackColor = Color.Transparent;

                menuEmpleados1.Visible = true;
                btnEmpleados.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuApoyos1.Visible)
            {
                menuApoyos1.Visible = false;
                btnApoyos.BackColor = Color.Transparent;

                menuEmpleados1.Visible = true;
                btnEmpleados.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuActividades1.Visible)
            {
                menuActividades1.Visible = false;
                btnActividades.BackColor = Color.Transparent;

                menuEmpleados1.Visible = true;
                btnEmpleados.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void btnAdultos_Click(object sender, EventArgs e)
        {
            menuAdultos1.CargarDGVAdulto();
            
            if (menuCentros1.Visible)
            {
                menuCentros1.Visible = false;
                btnCentros.BackColor = Color.Transparent;

                menuAdultos1.Visible = true;
                btnAdultos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuUsuarios1.Visible)
            {
                menuUsuarios1.Visible = false;
                btnUsuarios.BackColor = Color.Transparent;

                menuAdultos1.Visible = true;
                btnAdultos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuEmpleados1.Visible)
            {
                menuEmpleados1.Visible = false;
                btnEmpleados.BackColor = Color.Transparent;

                menuAdultos1.Visible = true;
                btnAdultos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuContactos1.Visible)
            {
                menuContactos1.Visible = false;
                btnContactos.BackColor = Color.Transparent;

                menuAdultos1.Visible = true;
                btnAdultos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuApoyos1.Visible)
            {
                menuApoyos1.Visible = false;
                btnApoyos.BackColor = Color.Transparent;

                menuAdultos1.Visible = true;
                btnAdultos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuActividades1.Visible)
            {
                menuActividades1.Visible = false;
                btnActividades.BackColor = Color.Transparent;

                menuAdultos1.Visible = true;
                btnAdultos.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            menuContactos1.CargarDGVContactos();
            
            if (menuCentros1.Visible)
            {
                menuCentros1.Visible = false;
                btnCentros.BackColor = Color.Transparent;

                menuContactos1.Visible = true;
                btnContactos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuUsuarios1.Visible)
            {
                menuUsuarios1.Visible = false;
                btnUsuarios.BackColor = Color.Transparent;

                menuContactos1.Visible = true;
                btnContactos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuEmpleados1.Visible)
            {
                menuEmpleados1.Visible = false;
                btnEmpleados.BackColor = Color.Transparent;

                menuContactos1.Visible = true;
                btnContactos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuAdultos1.Visible)
            {
                menuAdultos1.Visible = false;
                btnAdultos.BackColor = Color.Transparent;

                menuContactos1.Visible = true;
                btnContactos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuApoyos1.Visible)
            {
                menuApoyos1.Visible = false;
                btnApoyos.BackColor = Color.Transparent;

                menuContactos1.Visible = true;
                btnContactos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuActividades1.Visible)
            {
                menuActividades1.Visible = false;
                btnActividades.BackColor = Color.Transparent;

                menuContactos1.Visible = true;
                btnContactos.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void btnApoyos_Click(object sender, EventArgs e)
        {
            menuApoyos1.CargarDGVApoyos();

            if (menuCentros1.Visible)
            {
                menuCentros1.Visible = false;
                btnCentros.BackColor = Color.Transparent;

                menuApoyos1.Visible = true;
                btnApoyos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuUsuarios1.Visible)
            {
                menuUsuarios1.Visible = false;
                btnUsuarios.BackColor = Color.Transparent;

                menuApoyos1.Visible = true;
                btnApoyos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuEmpleados1.Visible)
            {
                menuEmpleados1.Visible = false;
                btnEmpleados.BackColor = Color.Transparent;

                menuApoyos1.Visible = true;
                btnApoyos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuAdultos1.Visible)
            {
                menuAdultos1.Visible = false;
                btnAdultos.BackColor = Color.Transparent;

                menuApoyos1.Visible = true;
                btnApoyos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuContactos1.Visible)
            {
                menuContactos1.Visible = false;
                btnContactos.BackColor = Color.Transparent;

                menuApoyos1.Visible = true;
                btnApoyos.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuActividades1.Visible)
            {
                menuActividades1.Visible = false;
                btnActividades.BackColor = Color.Transparent;

                menuApoyos1.Visible = true;
                btnApoyos.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            menuActividades1.CargarDGVActividades();

            if (menuCentros1.Visible)
            {
                menuCentros1.Visible = false;
                btnCentros.BackColor = Color.Transparent;

                menuActividades1.Visible = true;
                btnActividades.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuUsuarios1.Visible)
            {
                menuUsuarios1.Visible = false;
                btnUsuarios.BackColor = Color.Transparent;

                menuActividades1.Visible = true;
                btnActividades.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuEmpleados1.Visible)
            {
                menuEmpleados1.Visible = false;
                btnEmpleados.BackColor = Color.Transparent;

                menuActividades1.Visible = true;
                btnActividades.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuAdultos1.Visible)
            {
                menuAdultos1.Visible = false;
                btnAdultos.BackColor = Color.Transparent;

                menuActividades1.Visible = true;
                btnActividades.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuContactos1.Visible)
            {
                menuContactos1.Visible = false;
                btnContactos.BackColor = Color.Transparent;

                menuActividades1.Visible = true;
                btnActividades.BackColor = Color.FromArgb(0, 102, 204);
            }
            else if (menuApoyos1.Visible)
            {
                menuApoyos1.Visible = false;
                btnApoyos.BackColor = Color.Transparent;

                menuActividades1.Visible = true;
                btnActividades.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda P1 = new Ayuda();

            P1.ShowDialog();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MensajeSalir();

            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Login P1 = new Login();

                this.Close();
                P1.ShowDialog();
            }
        }

        private void timerTiempoYFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            AcercadeNosotros P1 = new AcercadeNosotros();

            P1.ShowDialog();
        }
    }
}
