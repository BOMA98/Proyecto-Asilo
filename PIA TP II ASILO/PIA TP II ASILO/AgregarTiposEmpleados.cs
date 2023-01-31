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
    public partial class AgregarTiposEmpleados : Form
    {
        public AgregarTiposEmpleados()
        {
            InitializeComponent();
        }

        private void AgregarTiposEmpleados_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtIdTipoEmpleado;
        }

        private void txtIdTipoEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtIdTipoEmpleado.Text == "ID TIPO DE EMPLEADO")
            {
                txtIdTipoEmpleado.Text = "";
                txtIdTipoEmpleado.ForeColor = Color.White;
            }
        }

        private void txtIdTipoEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtIdTipoEmpleado.Text == "")
            {
                txtIdTipoEmpleado.Text = "ID TIPO DE EMPLEADO";
                txtIdTipoEmpleado.ForeColor = Color.DimGray;
            }
        }

        private void txtIdTipoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTipoEmpleado.Focus();
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

        private void txtTipoEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtTipoEmpleado.Text == "TIPO DE EMPLEADO")
            {
                txtTipoEmpleado.Text = "";
                txtTipoEmpleado.ForeColor = Color.White;
            }
        }

        private void txtTipoEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtTipoEmpleado.Text == "")
            {
                txtTipoEmpleado.Text = "TIPO DE EMPLEADO";
                txtTipoEmpleado.ForeColor = Color.DimGray;
            }
        }

        private void txtTipoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        void ValidarTextBox(ref bool verificar)
        {
            MensajeVerificacion P1 = new MensajeVerificacion();

            if (txtIdTipoEmpleado.Text == "ID TIPO DE EMPLEADO")
            {
                P1.lblMensajeError.Text = "Ingrese un ID";
                P1.ShowDialog();

                return;
            }
            else if (txtTipoEmpleado.Text == "TIPO DE EMPLEADO" || txtTipoEmpleado.Text.Trim() == "")
            {
                P1.lblMensajeError.Text = "Ingrese TIPO DE EMPLEADO";

                P1.ShowDialog();

                return;
            }

            verificar = true;
            this.VerificarID(ref verificar);

            if (verificar)
            {
                if (txtIdTipoEmpleado.ReadOnly)
                {
                    this.ModificarTipoEmpleado();
                }
                else
                {
                    this.AgregarTipoEmpleado();
                }
            }
        }

        void AgregarTipoEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarTipoEmp";
                comando.Parameters.Add("p_idTipoEmp", int.Parse(txtIdTipoEmpleado.Text));
                comando.Parameters.Add("p_Tipo", txtTipoEmpleado.Text.ToUpper());
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

        void ModificarTipoEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarTipoEmp";
                comando.Parameters.Add("p_Tipo", txtTipoEmpleado.Text.ToUpper());
                comando.Parameters.Add("p_idActividad", int.Parse(txtIdTipoEmpleado.Text));
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
                comando.CommandText = "spBuscarTipoEmp";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idTipoEmp", int.Parse(txtIdTipoEmpleado.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdTipoEmpleado.ReadOnly == false)
                    {
                        if (datos.Rows[0]["ID_TIPO_EMPLEADO"].ToString() == txtIdTipoEmpleado.Text)
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
    }
}
