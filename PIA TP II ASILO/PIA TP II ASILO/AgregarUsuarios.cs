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
    public partial class AgregarUsuarios : Form
    {
        public AgregarUsuarios()
        {
            InitializeComponent();
        }

        void CargarComoboBoxEmpleado()
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
                comando.CommandText = "spUsuarioEmpleado";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboEmpleado.DataSource = datos;
                comboEmpleado.ValueMember = "ID_EMPLEADO";
                comboEmpleado.DisplayMember = "EMPLEADO";

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

        private void AgregarUsuarios_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtIdUsuario;

            if (txtPassword.Text == "CONTRASEÑA")
            {
                this.CargarComoboBoxEmpleado();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool verificar = false;

            this.ValidarTextBox(ref verificar);

            if (verificar)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtIdUsuario_Enter(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "ID USUARIO")
            {
                txtIdUsuario.Text = "";
                txtIdUsuario.ForeColor = Color.White;
            }
        }

        private void txtIdUsuario_Leave(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "")
            {
                txtIdUsuario.Text = "ID USUARIO";
                txtIdUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassword.Focus();
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

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        void ValidarTextBox(ref bool verificar)
        {
            MensajeVerificacion P1 = new MensajeVerificacion();

            if (txtIdUsuario.Text == "ID USUARIO")
            {
                P1.lblMensajeError.Text = "Ingrese un ID";
                P1.ShowDialog();

                return;
            }
            else if (txtPassword.Text == "CONTRASEÑA" || txtPassword.Text.Trim() == "")
            {
                P1.lblMensajeError.Text = "Ingrese una CONTRASEÑA";

                P1.ShowDialog();

                return;
            }
            else if (rdAdministrativo.Checked == false && rdEmpleado.Checked == false)
            {
                P1.lblMensajeError.Text = "Seleccione un \nTIPO DE USUARIO";

                P1.ShowDialog();

                return;
            }

            verificar = true;
            this.VerificarID(ref verificar);
            verificar = this.verificarEmpleado();

            if (verificar)
            {
                if (txtIdUsuario.ReadOnly)
                {
                    this.ModificarUsuario();
                }
                else
                {
                    this.AgregarUsuario();
                }
            }
        }

        void AgregarUsuario()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarUsuario";
                comando.Parameters.Add("p_idUsuario", int.Parse(txtIdUsuario.Text));
                comando.Parameters.Add("p_idEmpleado", int.Parse(comboEmpleado.SelectedValue.ToString()));
                if (rdAdministrativo.Checked)
                {
                    comando.Parameters.Add("p_tipoUsuario", 1);
                }
                else
                {
                    comando.Parameters.Add("p_tipoUsuario", 2);
                }
                comando.Parameters.Add("p_password", txtPassword.Text);
                comando.ExecuteNonQuery();
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

        void ModificarUsuario()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarUsuario";
                comando.Parameters.Add("p_idUsuario", int.Parse(txtIdUsuario.Text));
                comando.Parameters.Add("p_idEmpleado", int.Parse(comboEmpleado.SelectedValue.ToString()));
                if (rdAdministrativo.Checked)
                {
                    comando.Parameters.Add("p_tipoUsuario", 1);
                }
                else
                {
                    comando.Parameters.Add("p_tipoUsuario", 2);
                }
                comando.Parameters.Add("p_password", txtPassword.Text);
                comando.ExecuteNonQuery();
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

        void VerificarID(ref bool verificar)
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
                comando.CommandText = "spBuscarUsuario";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idUsuario", int.Parse(txtIdUsuario.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdUsuario.ReadOnly == false)
                    {
                        if (datos.Rows[0]["ID_USUARIO"].ToString() == txtIdUsuario.Text)
                        {
                            MensajeVerificacion P1 = new MensajeVerificacion();

                            P1.lblMensajeError.Text = "El ID ya existe";

                            P1.ShowDialog();

                            verificar = false;
                        }
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;

                btnVerContraseña.Image = Properties.Resources.view;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

                btnVerContraseña.Image = Properties.Resources.hide;
            }
        }

        public void LlenarPantallaModificarUsuario(int BuscarUsuario)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();

            this.CargarComoboBoxEmpleado();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarUsuario2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                comando.Parameters.Add("p_idUsuario", BuscarUsuario);

                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                
                txtIdUsuario.Text = datos.Rows[0]["ID_USUARIO"].ToString();
                txtIdUsuario.ReadOnly = true;
                txtIdUsuario.ForeColor = Color.White;
                
                comboEmpleado.SelectedValue = datos.Rows[0]["ID_EMPLEADO"].ToString();

                if (int.Parse(datos.Rows[0]["ID_TIPO_USUARIO"].ToString()) == 1)
                {
                    rdAdministrativo.Checked = true;
                }
                else
                {
                    rdEmpleado.Checked = true;
                }
                txtPassword.Text = datos.Rows[0]["PASSWORD"].ToString();
                txtPassword.ForeColor = Color.White;

                this.ShowDialog();
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

        bool verificarEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            bool verificar = true;

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarUsuario2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idEmp", int.Parse(comboEmpleado.SelectedValue.ToString()));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdUsuario.ReadOnly == false)
                    {
                        MensajeVerificacion P1 = new MensajeVerificacion();

                        P1.lblMensajeError.Text = "Este empleado ya\ntiene un USUARIO";
                        P1.ShowDialog();

                        verificar = false;
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

            return verificar;
        }
    }
}
