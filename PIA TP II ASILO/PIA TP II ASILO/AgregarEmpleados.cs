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
    public partial class AgregarEmpleados : Form
    {
        public AgregarEmpleados()
        {
            InitializeComponent();
        }

        public void CargarComboEstadoCivil()
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
                comando.CommandText = "spDatosEstadoCivil";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboEstadoCivil.DataSource = datos;
                comboEstadoCivil.DisplayMember = "ESTADO_CIVIL";
                comboEstadoCivil.ValueMember = "ID_ESTADO_CIVIL";
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

        void CargarComboNacionalidad()
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
                comando.CommandText = "spDatosNacionalidad";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboNacionalidad.DataSource = datos;
                comboNacionalidad.DisplayMember = "NACIONALIDAD";
                comboNacionalidad.ValueMember = "ID_NACIONALIDAD";
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

        void CargarComboTurno()
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
                comando.CommandText = "spDatosTurno";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboTurno.DataSource = datos;
                comboTurno.DisplayMember = "TURNO";
                comboTurno.ValueMember = "ID_TURNO";
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

        void CargarComboTipoEmpleado()
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
                comando.CommandText = "spDatosTipoEmp";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboTipoEmpleado.DataSource = datos;
                comboTipoEmpleado.DisplayMember = "TIPO_EMPLEADO";
                comboTipoEmpleado.ValueMember = "ID_TIPO_EMPLEADO";
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

        void CargarComboCentro()
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
                comando.CommandText = "spBuscarTodosCentros";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboCentro.DataSource = datos;
                comboCentro.DisplayMember = "NOMBRE";
                comboCentro.ValueMember = "ID_CENTRO";
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

        private void AgregarEmpleados_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtIdEmpleado;

            if (txtNombre.Text == "NOMBRE")
            {
                this.CargarComboCentro();
                this.CargarComboEstadoCivil();
                this.CargarComboNacionalidad();
                this.CargarComboTipoEmpleado();
                this.CargarComboTurno();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool verificar = false;

            this.ValidarTextBox(ref verificar);

            if (verificar)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        void ValidarTextBox(ref bool verificar)
        {
            MensajeVerificacion P1 = new MensajeVerificacion();

            if (txtIdEmpleado.Text == "ID EMPLEADO")
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
            else if (txtDomicilio.Text == "DOMICILIO")
            {
                P1.lblMensajeError.Text = "Ingrese un DOMICILIO";

                P1.ShowDialog();

                return;
            }
            else if (txtApellidoPaterno.Text == "APELLIDO PATERNO")
            {
                P1.lblMensajeError.Text = "Ingrese un APELLIDO PATERNO";

                P1.ShowDialog();

                return;
            }
            else if (txtApellidoMaterno.Text == "APELLIDO MATERNO")
            {
                P1.lblMensajeError.Text = "Ingrese un APELLIDO MATERNO";

                P1.ShowDialog();

                return;
            }
            else if (rdMasculino.Checked == false && rdFemenino.Checked == false)
            {
                P1.lblMensajeError.Text = "Seleccione un SEXO";

                P1.ShowDialog();

                return;
            }

            verificar = true;
            this.VerificarID(ref verificar);

            if (verificar)
            {
                if (txtIdEmpleado.ReadOnly)
                {
                    this.ModificarEmpleado();
                }
                else
                {
                    this.AgregarEmpleado();
                }
            }
        }

        void AgregarEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarEmpleado";
                comando.Parameters.Add("p_idEmpleado", int.Parse(txtIdEmpleado.Text));
                comando.Parameters.Add("p_nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_apellidoP", txtApellidoPaterno.Text.ToUpper());
                comando.Parameters.Add("p_apellidoM", txtApellidoMaterno.Text.ToUpper());
                comando.Parameters.Add("p_idEstadoC", int.Parse(comboEstadoCivil.SelectedValue.ToString()));
                if (rdMasculino.Checked)
                {
                    comando.Parameters.Add("p_sexo", 1);
                }
                else
                {
                    comando.Parameters.Add("p_sexo", 2);
                }
                comando.Parameters.Add("p_idNacionalidad", int.Parse(comboNacionalidad.SelectedValue.ToString()));
                comando.Parameters.Add("p_idTurno", int.Parse(comboTurno.SelectedValue.ToString()));
                comando.Parameters.Add("p_domicilio", txtDomicilio.Text.ToUpper());
                comando.Parameters.Add("p_idTipoEmp", int.Parse(comboTipoEmpleado.SelectedValue.ToString()));
                comando.Parameters.Add("p_idCentro", int.Parse(comboCentro.SelectedValue.ToString()));
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

        void ModificarEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarEmpleado";
                comando.Parameters.Add("p_idEmpleado", int.Parse(txtIdEmpleado.Text));
                comando.Parameters.Add("p_nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_apellidoP", txtApellidoPaterno.Text.ToUpper());
                comando.Parameters.Add("p_apellidoM", txtApellidoMaterno.Text.ToUpper());
                comando.Parameters.Add("p_idEstadoC", int.Parse(comboEstadoCivil.SelectedValue.ToString()));
                if (rdMasculino.Checked)
                {
                    comando.Parameters.Add("p_sexo", 1);
                }
                else
                {
                    comando.Parameters.Add("p_sexo", 2);
                }
                comando.Parameters.Add("p_idNacionalidad", int.Parse(comboNacionalidad.SelectedValue.ToString()));
                comando.Parameters.Add("p_idTurno", int.Parse(comboTurno.SelectedValue.ToString()));
                comando.Parameters.Add("p_domicilio", txtApellidoMaterno.Text.ToUpper());
                comando.Parameters.Add("p_idTipoEmp", int.Parse(comboTipoEmpleado.SelectedValue.ToString()));
                comando.Parameters.Add("p_idCentro", int.Parse(comboCentro.SelectedValue.ToString()));
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
                comando.CommandText = "spBuscarEmpleado";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idEmpleado", int.Parse(txtIdEmpleado.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdEmpleado.ReadOnly == false)
                    {
                        if (datos.Rows[0]["ID_EMPLEADO"].ToString() == txtIdEmpleado.Text)
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

        private void txtIdEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text == "ID EMPLEADO")
            {
                txtIdEmpleado.Text = "";
                txtIdEmpleado.ForeColor = Color.White;
            }
        }

        private void txtIdEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text == "")
            {
                txtIdEmpleado.Text = "ID EMPLEADO";
                txtIdEmpleado.ForeColor = Color.DimGray;
            }
        }

        private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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
                txtApellidoPaterno.Focus();
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

        private void txtApellidoPaterno_Enter(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text == "APELLIDO PATERNO")
            {
                txtApellidoPaterno.Text = "";
                txtApellidoPaterno.ForeColor = Color.White;
            }
        }

        private void txtApellidoPaterno_Leave(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text == "")
            {
                txtApellidoPaterno.Text = "APELLIDO PATERNO";
                txtApellidoPaterno.ForeColor = Color.DimGray;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoMaterno.Focus();
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

        private void txtApellidoMaterno_Enter(object sender, EventArgs e)
        {
            if (txtApellidoMaterno.Text == "APELLIDO MATERNO")
            {
                txtApellidoMaterno.Text = "";
                txtApellidoMaterno.ForeColor = Color.White;
            }
        }

        private void txtApellidoMaterno_Leave(object sender, EventArgs e)
        {
            if (txtApellidoMaterno.Text == "")
            {
                txtApellidoMaterno.Text = "APELLIDO MATERNO";
                txtApellidoMaterno.ForeColor = Color.DimGray;
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDomicilio.Focus();
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

        private void txtDomicilio_Enter(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "DOMICILIO")
            {
                txtDomicilio.Text = "";
                txtDomicilio.ForeColor = Color.White;
            }
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "")
            {
                txtDomicilio.Text = "DOMICILIO";
                txtDomicilio.ForeColor = Color.DimGray;
            }
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bool verificar = false;

                this.ValidarTextBox(ref verificar);

                if (verificar)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        public void LlenarPantallaModificarEmpleado(int BuscarEmpleado)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            
            this.CargarComboCentro();
            this.CargarComboEstadoCivil();
            this.CargarComboNacionalidad();
            this.CargarComboTipoEmpleado();
            this.CargarComboTurno();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarEmpleado2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idEmpleado", BuscarEmpleado);
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                txtIdEmpleado.Text = datos.Rows[0]["ID_EMPLEADO"].ToString();
                txtIdEmpleado.ReadOnly = true;
                txtIdEmpleado.ForeColor = Color.White;
                txtNombre.Text = datos.Rows[0]["NOMBRE"].ToString();
                txtNombre.ForeColor = Color.White;
                txtApellidoPaterno.Text = datos.Rows[0]["APELLIDO_P"].ToString();
                txtApellidoPaterno.ForeColor = Color.White;
                txtApellidoMaterno.Text = datos.Rows[0]["APELLIDO_M"].ToString();
                txtApellidoMaterno.ForeColor = Color.White;
                comboEstadoCivil.SelectedValue = int.Parse(datos.Rows[0]["ID_ESTADO_CIVIL"].ToString());
                if (datos.Rows[0]["ID_SEXO"].ToString() == "1")
                {
                    rdMasculino.Checked = true;
                }
                else
                {
                    rdFemenino.Checked = true;
                }
                comboNacionalidad.SelectedValue = datos.Rows[0]["ID_NACIONALIDAD"].ToString();
                comboTurno.SelectedValue = datos.Rows[0]["ID_TURNO"].ToString();
                txtDomicilio.Text = datos.Rows[0]["DOMICILIO"].ToString();
                txtDomicilio.ForeColor = Color.White;
                comboTipoEmpleado.SelectedValue = datos.Rows[0]["ID_TIPO_EMPLEADO"].ToString();
                comboCentro.SelectedValue = datos.Rows[0]["ID_CENTRO"].ToString();

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
    }
}
