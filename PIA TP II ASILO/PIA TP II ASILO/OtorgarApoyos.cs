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
    public partial class OtorgarApoyos : Form
    {
        public OtorgarApoyos()
        {
            InitializeComponent();
        }

        void CargarComboBoxAdulto()
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
                comando.CommandText = "spDatosAdulto2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboAdulto.DataSource = datos;
                comboAdulto.ValueMember = "ID_ADULTO";
                comboAdulto.DisplayMember = "ADULTO";

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

        void CargarComboBoxApoyo()
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
                comando.CommandText = "spBuscarTodosApoyos";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboApoyo.DataSource = datos;
                comboApoyo.ValueMember = "ID_APOYO";
                comboApoyo.DisplayMember = "NOMBRE";

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

        private void OtorgarApoyos_Load(object sender, EventArgs e)
        {
            if (txtVerificar.Text == "Agregar")
            {
                this.CargarComboBoxAdulto();
                this.CargarComboBoxApoyo();
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

        void ValidarTextBox(ref bool verificar)
        {
            MensajeVerificacion P1 = new MensajeVerificacion();

            if (comboAdulto.SelectedIndex == -1)
            {
                P1.lblMensajeError.Text = "Asegurese de agregar\nun HUESPED";
                P1.ShowDialog();

                return;
            }
            else if (comboApoyo.SelectedIndex == -1)
            {
                P1.lblMensajeError.Text = "Asegurese de agregar\nuna APOYO";
                P1.ShowDialog();

                return;
            }

            verificar = this.verificarApoyo();

            if (verificar)
            {
                if (txtVerificar.ReadOnly)
                {
                    this.ModificarCentroApoyo();
                }
                else
                {
                    this.AgregarCentroApoyo();
                }
            }
        }

        void AgregarCentroApoyo()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarAdultoApoyo";
                comando.Parameters.Add("p_idAdulto", int.Parse(comboAdulto.SelectedValue.ToString()));
                comando.Parameters.Add("p_idApoyo", int.Parse(comboApoyo.SelectedValue.ToString()));
                comando.Parameters.Add("p_Descripcion", txtDescripcion.Text.ToUpper());
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

        void ModificarCentroApoyo()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarAdultoApoyo";
                comando.Parameters.Add("p_idAdulto", int.Parse(comboAdulto.SelectedValue.ToString()));
                comando.Parameters.Add("p_idApoyo", int.Parse(comboApoyo.SelectedValue.ToString()));
                comando.Parameters.Add("p_Descripcion", txtDescripcion.Text);
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

        public void LlenarPantallaModificarApoyo(int BuscarCentro, int BuscarActividad)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();

            this.CargarComboBoxAdulto();
            this.CargarComboBoxApoyo();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarAdultoApoyo2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", BuscarCentro);
                comando.Parameters.Add("p_idActividad", BuscarActividad);
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboAdulto.SelectedValue = datos.Rows[0]["ID_ADULTO"].ToString();
                comboApoyo.SelectedValue = datos.Rows[0]["ID_APOYO"].ToString();
                txtDescripcion.Text = datos.Rows[0]["DESCRIPCION"].ToString();
                txtDescripcion.ForeColor = Color.White;
                txtVerificar.Text = "Modificar";
                txtVerificar.ReadOnly = true;
                comboAdulto.Enabled = false;
                comboApoyo.Enabled = false;

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

        bool verificarApoyo()
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
                comando.CommandText = "spBuscarAdultoApoyo2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idAdulto", int.Parse(comboAdulto.SelectedValue.ToString()));
                comando.Parameters.Add("p_idApoyo", int.Parse(comboApoyo.SelectedValue.ToString()));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtVerificar.ReadOnly == false)
                    {
                        MensajeVerificacion P1 = new MensajeVerificacion();

                        P1.lblMensajeError.Text = "Ese APOYO ya\nfue asignada";
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
        }
    }
}
