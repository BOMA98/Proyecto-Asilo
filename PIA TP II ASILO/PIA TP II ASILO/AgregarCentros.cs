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
    public partial class AgregarCentros : Form
    {
        public AgregarCentros()
        {
            InitializeComponent();
        }

        private void AgregarCentros_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtIdCentro;
        }

        private void txtIdCentro_Enter(object sender, EventArgs e)
        {
            if (txtIdCentro.Text == "ID CENTRO")
            {
                txtIdCentro.Text = "";
                txtIdCentro.ForeColor = Color.White;
            }
        }

        private void txtIdCentro_Leave(object sender, EventArgs e)
        {
            if (txtIdCentro.Text == "")
            {
                txtIdCentro.Text = "ID CENTRO";
                txtIdCentro.ForeColor = Color.DimGray;
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

        private void txtIdCentro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
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

            if (txtIdCentro.Text == "ID CENTRO")
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
            else if(txtTelefono.Text == "TELEFONO" || txtTelefono.Text.Trim() == "")
            {
                P1.lblMensajeError.Text = "Ingrese un TELEFONO";

                P1.ShowDialog();

                return;
            }

            verificar = true;
            this.VerificarID(ref verificar);

            if (verificar)
            {
                if (txtIdCentro.ReadOnly)
                {
                    this.ModificarCentro();
                }
                else
                {
                    this.AgregarCentro();
                }
            }
        }

        void AgregarCentro()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarCentro";
                comando.Parameters.Add("p_idCentro", int.Parse(txtIdCentro.Text));
                comando.Parameters.Add("p_nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_telefono", txtTelefono.Text);
                comando.Parameters.Add("p_direccion", txtDomicilio.Text.ToUpper());
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

        void ModificarCentro()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarCentro";
                comando.Parameters.Add("p_nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_telefono", txtTelefono.Text);
                comando.Parameters.Add("p_direccion", txtDomicilio.Text.ToUpper());
                comando.Parameters.Add("p_idCentro", int.Parse(txtIdCentro.Text));
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
                comando.CommandText = "spBuscarCentro";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", int.Parse(txtIdCentro.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdCentro.ReadOnly == false)
                    {
                        if (datos.Rows[0]["ID_CENTRO"].ToString() == txtIdCentro.Text)
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
    }
}
