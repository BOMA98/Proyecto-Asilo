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
    public partial class AsignarActividadCentro : Form
    {
        public AsignarActividadCentro()
        {
            InitializeComponent();
        }

        void CargarComboBoxCentro()
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

        void CargarComboBoxActividades()
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
                comando.CommandText = "spBuscarTodasActividades";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboActividad.DataSource = datos;
                comboActividad.ValueMember = "ID_ACTIVIDAD";
                comboActividad.DisplayMember = "NOMBRE";
                
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

        private void AsignarActividadCentro_Load(object sender, EventArgs e)
        {
            if (txtVerificar.Text == "Agregar")
            {
                this.CargarComboBoxCentro();
                this.CargarComboBoxActividades();
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

            if (comboActividad.SelectedIndex == -1)
            {
                P1.lblMensajeError.Text = "Asegurese de agregar\nuna ACTIVIDAD";
                P1.ShowDialog();

                return;
            }

            verificar = this.verificarActividad();

            if (verificar)
            {
                if (txtVerificar.ReadOnly)
                {
                    this.ModificarCentroActividad();
                }
                else
                {
                    this.AgregarCentroActividad();
                }
            }
        }

        void AgregarCentroActividad()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarActividadCentro";
                comando.Parameters.Add("p_idCentro", int.Parse(comboCentro.SelectedValue.ToString()));
                comando.Parameters.Add("p_idActividad", int.Parse(comboActividad.SelectedValue.ToString()));
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

        void ModificarCentroActividad()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarActividadCentro";
                comando.Parameters.Add("p_idCentro", int.Parse(comboCentro.SelectedValue.ToString()));
                comando.Parameters.Add("p_idActividad", int.Parse(comboActividad.SelectedValue.ToString()));
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

        public void LlenarPantallaModificarEmpleado(int BuscarCentro, int BuscarActividad)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();

            this.CargarComboBoxCentro();
            this.CargarComboBoxActividades();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarActividadCentro2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", BuscarCentro);
                comando.Parameters.Add("p_idActividad", BuscarActividad);
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboCentro.SelectedValue = datos.Rows[0]["ID_CENTRO"].ToString();
                comboActividad.SelectedValue = datos.Rows[0]["ID_ACTIVIDAD"].ToString();
                txtDescripcion.Text = datos.Rows[0]["DESCRIPCION"].ToString();
                txtDescripcion.ForeColor = Color.White;
                txtVerificar.Text = "Modificar";
                txtVerificar.ReadOnly = true;
                comboCentro.Enabled = false;
                comboActividad.Enabled = false;

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

        bool verificarActividad()
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
                comando.CommandText = "spBuscarActividadCentro2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", int.Parse(comboCentro.SelectedValue.ToString()));
                comando.Parameters.Add("p_idActividad", int.Parse(comboActividad.SelectedValue.ToString()));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtVerificar.ReadOnly == false)
                    {
                        MensajeVerificacion P1 = new MensajeVerificacion();

                        P1.lblMensajeError.Text = "Esa ACTIVIDAD ya\nfue asignada";
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
