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
    public partial class AgregarApoyos : Form
    {
        public AgregarApoyos()
        {
            InitializeComponent();
        }

        private void AgregarApoyos_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtIdApoyo;
        }

        private void txtIdApoyo_Enter(object sender, EventArgs e)
        {
            if (txtIdApoyo.Text == "ID APOYO")
            {
                txtIdApoyo.Text = "";
                txtIdApoyo.ForeColor = Color.White;
            }
        }

        private void txtIdApoyo_Leave(object sender, EventArgs e)
        {
            if (txtIdApoyo.Text == "")
            {
                txtIdApoyo.Text = "ID APOYO";
                txtIdApoyo.ForeColor = Color.DimGray;
            }
        }

        private void txtIdApoyo_KeyPress(object sender, KeyPressEventArgs e)
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
                txtDescripcion.Focus();
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

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "DESCRIPCION")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.White;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "DESCRIPCION";
                txtDescripcion.ForeColor = Color.DimGray;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        void ValidarTextBox(ref bool verificar)
        {
            MensajeVerificacion P1 = new MensajeVerificacion();

            if (txtIdApoyo.Text == "ID APOYO")
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

            verificar = true;
            this.VerificarID(ref verificar);

            if (verificar)
            {
                if (txtIdApoyo.ReadOnly)
                {
                    this.ModificarApoyo();
                }
                else
                {
                    this.AgregarApoyo();
                }
            }
        }

        void AgregarApoyo()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarApoyo";
                comando.Parameters.Add("p_idApoyo", int.Parse(txtIdApoyo.Text));
                comando.Parameters.Add("p_nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_descripcion", txtDescripcion.Text.ToUpper());
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

        void ModificarApoyo()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarApoyo";
                comando.Parameters.Add("p_idApoyo", int.Parse(txtIdApoyo.Text));
                comando.Parameters.Add("p_nombre", txtNombre.Text.ToUpper());
                comando.Parameters.Add("p_descripcion", txtDescripcion.Text.ToUpper());
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
                comando.CommandText = "spBuscarApoyo";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idApoyo", int.Parse(txtIdApoyo.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdApoyo.ReadOnly == false)
                    {
                        if (datos.Rows[0]["ID_APOYO"].ToString() == txtIdApoyo.Text)
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
