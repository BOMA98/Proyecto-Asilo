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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = false;

                btnVerContraseña.Image = Properties.Resources.view;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;

                btnVerContraseña.Image = Properties.Resources.hide;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }

            lblError.Visible = false;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();
            }

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
            }

            lblError.Visible = false;
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ComprobarDatos();
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            ComprobarDatos();
        }

        void ComprobarDatos()
        {
            if (txtUsuario.Text == "USUARIO")
            {
                lblError.Text = "Ingrese un usuario";
                lblError.Visible = true;
            }
            else if (txtContraseña.Text == "CONTRASEÑA" || txtContraseña.Text.Trim() == "")
            {
                lblError.Text = "Ingrse una contraseña";
                lblError.Visible = true;
            }
            else
            {
                ConectarUsuario();
            }
        }

        void ConectarUsuario()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarUsuarioContraseña";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_usuario", int.Parse(txtUsuario.Text));
                comando.Parameters.Add("p_password", txtContraseña.Text);
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count == 0)
                {
                    lblError.Text = "Usuario o contraseña incorrecta";
                    lblError.Visible = true;
                }
                else
                {
                    if (txtContraseña.Text == datos.Rows[0]["PASSWORD"].ToString())
                    {
                        MenuPrincipal P1 = new MenuPrincipal();
                        P1.lblNombre.Text = datos.Rows[0]["NOMBRE"].ToString();
                        P1.lblCargo.Text = datos.Rows[0]["TIPO_USUARIO"].ToString();
                        MenuPrincipal.IdCargo = int.Parse(datos.Rows[0]["ID_USUARIO"].ToString());
                        P1.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblError.Text = "Usuario o contraseña incorrecta";
                        lblError.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
