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
    public partial class AsignarActividadAdulto : Form
    {
        public AsignarActividadAdulto()
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

        void CargarComboBoxActividad()
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

        private void AsignarActividadAdulto_Load(object sender, EventArgs e)
        {
            if (txtVerificar.Text == "Agregar")
            {
                this.CargarComboBoxAdulto();
                this.CargarComboBoxActividad();
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

            if (comboAdulto.SelectedIndex == -1)
            {
                P1.lblMensajeError.Text = "Asegurese de agregar\nun HUESPED";
                P1.ShowDialog();

                return;
            }
            else if (comboActividad.SelectedIndex == -1)
            {
                P1.lblMensajeError.Text = "Asegurese de agregar\nuna ACTIVIDAD";
                P1.ShowDialog();

                return;
            }

            verificar = this.verificarActividad();
            this.VerificarCentroActiviadad(ref verificar);

            if (verificar)
            {
                if (txtVerificar.ReadOnly)
                {
                    this.ModificarAdultoActividad();
                }
                else
                {
                    this.AgregarAdultoActividad();
                }
            }
        }

        void AgregarAdultoActividad()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spAgregarActividadAdulto";
                comando.Parameters.Add("p_idAdulto", int.Parse(comboAdulto.SelectedValue.ToString()));
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

        void ModificarAdultoActividad()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spModificarActividadAdulto";
                comando.Parameters.Add("p_idAdulto", int.Parse(comboAdulto.SelectedValue.ToString()));
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

        public void LlenarPantallaModificarAdultoActividad(int BuscarCentro, int BuscarActividad)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();

            this.CargarComboBoxAdulto();
            this.CargarComboBoxActividad();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarActividadAdulto2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", BuscarCentro);
                comando.Parameters.Add("p_idActividad", BuscarActividad);
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                comboAdulto.SelectedValue = datos.Rows[0]["ID_ADULTO"].ToString();
                comboActividad.SelectedValue = datos.Rows[0]["ID_ACTIVIDAD"].ToString();
                txtDescripcion.Text = datos.Rows[0]["DESCRIPCION"].ToString();
                txtDescripcion.ForeColor = Color.White;
                txtVerificar.Text = "Modificar";
                txtVerificar.ReadOnly = true;
                comboAdulto.Enabled = false;
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
                comando.CommandText = "spBuscarActividadAdulto2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idAdulto", int.Parse(comboAdulto.SelectedValue.ToString()));
                comando.Parameters.Add("p_idActividad", int.Parse(comboActividad.SelectedValue.ToString()));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count != 0)
                {
                    if (txtVerificar.ReadOnly == false)
                    {
                        MensajeVerificacion P1 = new MensajeVerificacion();

                        P1.lblMensajeError.Text = "Esa actividad ya\nfue asignada";
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool verificar = false;

            this.ValidarTextBox(ref verificar);

            if (verificar)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        void VerificarCentroActiviadad(ref bool verificar)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            int idCentro = 0;

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarAdulto2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idAdulto", int.Parse(comboAdulto.SelectedValue.ToString()));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                idCentro = int.Parse(datos.Rows[0]["ID_CENTRO"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            VerificarCentroActividades(idCentro, ref verificar);
        }

        void VerificarCentroActividades(int idCentro, ref bool verificar)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            bool verficarCant = true;

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarActividadCentro";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", idCentro);
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                if (datos.Rows.Count != 0)
                {
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        if (comboActividad.SelectedValue.ToString() == datos.Rows[i]["ID_ACTIVIDAD"].ToString())
                        {
                            verificar = true;
                            verficarCant = true;
                            break;
                        }
                        else
                        {
                            verificar = false;
                            verficarCant = false;
                        }
                    }
                    
                }
                else
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "El centro no tiene asignana\nninguna actividad";
                    P1.ShowDialog();
                    
                    verificar = false;
                    verficarCant = true;
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

            if (verficarCant != true)
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Asegurese que el centro\nimparta la actvidad";
                P1.ShowDialog();
            }
        }
    }
}
