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
    public partial class AgregarAdultos : Form
    {
        public AgregarAdultos()
        {
            InitializeComponent();
        }

        void CargarComoboBoxContacto()
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
                comando.CommandText = "spDatosAdultoContacto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboContacto.DataSource = datos;
                comboContacto.ValueMember = "ID_CONTACTO";
                comboContacto.DisplayMember = "CONTACTO";

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

        void CargarComoboBoxCentro()
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
                comboCentro.ValueMember = "ID_CENTRO";
                comboCentro.DisplayMember = "NOMBRE";

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

        private void AgregarAdultos_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtIdAdulto;

            if (txtNombre.Text == "NOMBRE")
            {
                this.CargarComoboBoxContacto();
                this.CargarComoboBoxCentro();
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

        private void txtIdAdulto_Enter(object sender, EventArgs e)
        {
            if (txtIdAdulto.Text == "ID ADULTO")
            {
                txtIdAdulto.Text = "";
                txtIdAdulto.ForeColor = Color.White;
            }
        }

        private void txtIdAdulto_Leave(object sender, EventArgs e)
        {
            if (txtIdAdulto.Text == "")
            {
                txtIdAdulto.Text = "ID ADULTO";
                txtIdAdulto.ForeColor = Color.DimGray;
            }
        }

        private void txtIdAdulto_KeyPress(object sender, KeyPressEventArgs e)
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
                txtEdad.Focus();
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

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "EDAD")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.White;
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "EDAD";
                txtEdad.ForeColor = Color.DimGray;
            }
        }

        void ValidarTextBox(ref bool verificar)
        {
            MensajeVerificacion P1 = new MensajeVerificacion();

            if (txtIdAdulto.Text == "ID ADULTO")
            {
                P1.lblMensajeError.Text = "Ingrese un ID";
                P1.ShowDialog();

                return;
            }
            else if (txtNombre.Text == "NOMBRE")
            {
                P1.lblMensajeError.Text = "Ingrese una NOMBRE";

                P1.ShowDialog();

                return;
            }
            else if (txtApellidoP.Text == "APELLIDO PATERNO")
            {
                P1.lblMensajeError.Text = "Ingrese una \nAPELLIDO PATERNO";

                P1.ShowDialog();

                return;
            }
            else if (txtApellidoM.Text == "APELLIDO MATERNO")
            {
                P1.lblMensajeError.Text = "Ingrese una \nAPELLIDO MATERNO";

                P1.ShowDialog();

                return;
            }
            else if (txtEdad.Text == "EDAD")
            {
                P1.lblMensajeError.Text = "Ingrese una EDAD";

                P1.ShowDialog();

                return;
            }
            else if (rdMasculino.Checked == false && rdFemenino.Checked == false)
            {
                P1.lblMensajeError.Text = "Seleccione un SEXO";

                P1.ShowDialog();

                return;
            }
            else if (int.Parse(txtEdad.Text) < 60)
            {
                P1.lblMensajeError.Text = "El HUSPED debe tener una\nEDAD mayor o igual a 60";

                P1.ShowDialog();

                return;
            }
            else if (comboContacto.SelectedIndex == -1)
            {
                P1.lblMensajeError.Text = "Asegurese de agregar\nun CONTACTO";

                P1.ShowDialog();

                return;
            }

            verificar = true;
            this.VerificarID(ref verificar);

            if (verificar)
            {
                if (txtIdAdulto.ReadOnly)
                {
                    this.ModificarAdulto();
                }
                else
                {
                    this.AgregarAdulto();
                }
            }
        }

        void AgregarAdulto()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarAdulto";
                comando.Parameters.Add("p_idAdulto", int.Parse(txtIdAdulto.Text));
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
                comando.Parameters.Add("p_Edad", int.Parse(txtEdad.Text));
                comando.Parameters.Add("p_idContacto", int.Parse(comboContacto.SelectedValue.ToString()));
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

        void ModificarAdulto()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarAdulto";
                comando.Parameters.Add("p_idAdulto", int.Parse(txtIdAdulto.Text));
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
                comando.Parameters.Add("p_Edad", int.Parse(txtEdad.Text));
                comando.Parameters.Add("p_idContacto", int.Parse(comboContacto.SelectedValue.ToString()));
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
                comando.CommandText = "spBuscarAdulto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idAdulto", int.Parse(txtIdAdulto.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtIdAdulto.ReadOnly == false)
                    {
                        if (datos.Rows[0]["ID_ADULTO"].ToString() == txtIdAdulto.Text)
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

        public void LlenarPantallaModificarAdulto(int BuscarUsuario)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();

            this.CargarComoboBoxContacto();
            this.CargarComoboBoxCentro();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarAdulto2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                comando.Parameters.Add("p_idUsuario", BuscarUsuario);

                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                txtIdAdulto.Text = datos.Rows[0]["ID_ADULTO"].ToString();
                txtIdAdulto.ReadOnly = true;
                txtIdAdulto.ForeColor = Color.White;
                txtNombre.Text = datos.Rows[0]["NOMBRE"].ToString();
                txtNombre.ForeColor = Color.White;
                txtApellidoP.Text = datos.Rows[0]["APELLIDO_P"].ToString();
                txtApellidoP.ForeColor = Color.White;
                txtApellidoM.Text = datos.Rows[0]["APELLIDO_M"].ToString();
                txtApellidoM.ForeColor = Color.White;
                txtEdad.Text = datos.Rows[0]["EDAD"].ToString();
                txtEdad.ForeColor = Color.White;
                if (int.Parse(datos.Rows[0]["ID_SEXO"].ToString()) == 1)
                {
                    rdMasculino.Checked = true;
                }
                else
                {
                    rdFemenino.Checked = true;
                }
                comboContacto.SelectedValue = datos.Rows[0]["ID_CONTACTO"].ToString();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool verificar = false;

            this.ValidarTextBox(ref verificar);

            if (verificar)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
