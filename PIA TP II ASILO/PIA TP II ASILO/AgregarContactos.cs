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
    public partial class AgregarContactos : Form
    {
        public AgregarContactos()
        {
            InitializeComponent();
        }

        void CargarComoboBoxParentesco()
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
                comando.CommandText = "spDatosParentesco";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboParentesco.DataSource = datos;
                comboParentesco.ValueMember = "ID_PARENTESCO";
                comboParentesco.DisplayMember = "PARENTESCO";

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

        private void AgregarContactos_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtIdContacto;

            if (txtNombre.Text == "NOMBRE")
            {
                this.CargarComoboBoxParentesco();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtIdContacto_Enter(object sender, EventArgs e)
        {
            if (txtIdContacto.Text == "ID CONTACTO")
            {
                txtIdContacto.Text = "";
                txtIdContacto.ForeColor = Color.White;
            }
        }

        private void txtIdContacto_Leave(object sender, EventArgs e)
        {
            if (txtIdContacto.Text == "")
            {
                txtIdContacto.Text = "ID CONTACTO";
                txtIdContacto.ForeColor = Color.DimGray;
            }
        }

        private void txtIdContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombre.Focus();
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

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoP.Focus();
            }

            if (Char.IsLetter(e.KeyChar))
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

        private void txtApellidoP_Enter(object sender, EventArgs e)
        {
            if (txtApellidoP.Text == "APELLIDO PATERNO")
            {
                txtApellidoP.Text = "";
                txtApellidoP.ForeColor = Color.White;
            }
        }

        private void txtApellidoP_Leave(object sender, EventArgs e)
        {
            if (txtApellidoP.Text == "")
            {
                txtApellidoP.Text = "APELLIDO PATERNO";
                txtApellidoP.ForeColor = Color.DimGray;
            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoM.Focus();
            }

            if (Char.IsLetter(e.KeyChar))
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

        private void txtApellidoM_Enter(object sender, EventArgs e)
        {
            if (txtApellidoM.Text == "APELLIDO MATERNO")
            {
                txtApellidoM.Text = "";
                txtApellidoM.ForeColor = Color.White;
            }
        }

        private void txtApellidoM_Leave(object sender, EventArgs e)
        {
            if (txtApellidoM.Text == "")
            {
                txtApellidoM.Text = "APELLIDO MATERNO";
                txtApellidoM.ForeColor = Color.DimGray;
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelefono.Focus();
            }

            if (Char.IsLetter(e.KeyChar))
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

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "TELEFONO")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.White;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "TELEFONO";
                txtTelefono.ForeColor = Color.DimGray;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        void ValidarTextBox(ref bool verificar)
        {
            MensajeVerificacion P1 = new MensajeVerificacion();

            if (txtIdContacto.Text == "ID USUARIO")
            {
                P1.lblMensajeError.Text = "Ingrese un ID";
                P1.ShowDialog();

                return;
            }
            else if (txtNombre.Text == "NOMBRE")
            {
                P1.lblMensajeError.Text = "Ingrese un NOMBRE";

                P1.ShowDialog();

                return;
            }
            else if (txtApellidoP.Text == "APELLIDO PATERNO")
            {
                P1.lblMensajeError.Text = "Ingrese un APELLIDO PATERNO";

                P1.ShowDialog();

                return;
            }
            else if (txtApellidoM.Text == "APELLIDO MATERNO")
            {
                P1.lblMensajeError.Text = "Ingrese un APELLIDO MATERNO";

                P1.ShowDialog();

                return;
            }
            else if (txtTelefono.Text == "TELEFONO")
            {
                P1.lblMensajeError.Text = "Ingrese un TELEFONO";

                P1.ShowDialog();

                return;
            }
            else if (rdMasculino.Checked == false && rdFemenino.Checked == false)
            {
                P1.lblMensajeError.Text = "Seleccione el SEXO";

                P1.ShowDialog();

                return;
            }

            verificar = true;
            this.VerificarID(ref verificar);

            if (verificar)
            {
                if (txtIdContacto.ReadOnly)
                {
                    this.ModificarContacto();
                }
                else
                {
                    this.AgregarContacto();
                }
            }
        }

        void AgregarContacto()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarContacto";
                comando.Parameters.Add("p_idComtacto", int.Parse(txtIdContacto.Text));
                comando.Parameters.Add("p_Nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_ApellidoP", txtApellidoP.Text.ToUpper());
                comando.Parameters.Add("p_ApellidoM", txtApellidoM.Text.ToUpper());
                if (rdMasculino.Checked)
                {
                    comando.Parameters.Add("p_idSexo", 1);
                }
                else
                {
                    comando.Parameters.Add("p_idSexo", 2);
                }
                comando.Parameters.Add("p_Telefono", txtTelefono.Text);
                comando.Parameters.Add("p_idEmpleado", int.Parse(comboParentesco.SelectedValue.ToString()));
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

        void ModificarContacto()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarContacto";
                comando.Parameters.Add("p_idComtacto", int.Parse(txtIdContacto.Text));
                comando.Parameters.Add("p_Nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_ApellidoP", txtApellidoP.Text.ToUpper());
                comando.Parameters.Add("p_ApellidoM", txtApellidoM.Text.ToUpper());
                if (rdMasculino.Checked)
                {
                    comando.Parameters.Add("p_idSexo", 1);
                }
                else
                {
                    comando.Parameters.Add("p_idSexo", 2);
                }
                comando.Parameters.Add("p_Telefono", txtTelefono.Text);
                comando.Parameters.Add("p_idEmpleado", int.Parse(comboParentesco.SelectedValue.ToString()));
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
                comando.CommandText = "spBuscarContacto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idContacto", int.Parse(txtIdContacto.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdContacto.ReadOnly == false)
                    {
                        if (datos.Rows[0]["ID_CONTACTO"].ToString() == txtIdContacto.Text)
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

        public void LlenarPantallaModificarContacto(int BuscarUsuario)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();

            this.CargarComoboBoxParentesco();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarContacto2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idContacto", BuscarUsuario);
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                txtIdContacto.Text = datos.Rows[0]["ID_CONTACTO"].ToString();
                txtIdContacto.ReadOnly = true;
                txtIdContacto.ForeColor = Color.White;
                txtNombre.Text = datos.Rows[0]["NOMBRE"].ToString();
                txtNombre.ForeColor = Color.White;
                txtApellidoP.Text = datos.Rows[0]["APELLIDO_P"].ToString();
                txtApellidoP.ForeColor = Color.White;
                txtApellidoM.Text = datos.Rows[0]["APELLIDO_M"].ToString();
                txtApellidoM.ForeColor = Color.White;
                txtTelefono.Text = datos.Rows[0]["TELEFONO"].ToString();
                txtTelefono.ForeColor = Color.White;
                if (int.Parse(datos.Rows[0]["ID_SEXO"].ToString()) == 1)
                {
                    rdMasculino.Checked = true;
                }
                else
                {
                    rdFemenino.Checked = true;
                }
                comboParentesco.SelectedValue = datos.Rows[0]["ID_PARENTESCO"].ToString();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool verificar = false;

            this.ValidarTextBox(ref verificar);

            if (verificar)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
