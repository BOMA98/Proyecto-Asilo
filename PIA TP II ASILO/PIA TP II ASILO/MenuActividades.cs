using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace PIA_TP_II_ASILO
{
    public partial class MenuActividades : UserControl
    {
        public MenuActividades()
        {
            InitializeComponent();
        }

        private void txtBuscarActividades_Enter(object sender, EventArgs e)
        {
            if (txtBuscarActividades.Text == "BUSCAR")
            {
                txtBuscarActividades.Text = "";
                txtBuscarActividades.ForeColor = Color.White;
            }
        }

        private void txtBuscarActividades_Leave(object sender, EventArgs e)
        {
            if (txtBuscarActividades.Text == "")
            {
                txtBuscarActividades.Text = "BUSCAR";
                txtBuscarActividades.ForeColor = Color.DimGray;
            }
        }

        public void CargarDGVActividades()
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
                dgvActividades.DataSource = datos;
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

        private void btnRegresarActividades_Click(object sender, EventArgs e)
        {
            this.CargarDGVActividades();

            txtBuscarActividades.Text = "BUSCAR";
            txtBuscarActividades.ForeColor = Color.DimGray;

            btnModificarActividades.Visible = false;
            btnEliminarActividades.Visible = false;
        }

        private void btnBuscarActividades_Click(object sender, EventArgs e)
        {
            if (txtBuscarActividades.Text == "BUSCAR" || txtBuscarActividades.Text.Trim() == "")
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Ingrese un ID";

                P1.ShowDialog();
            }
            else
            {
                this.BuscarActividad();
            }
        }

        private void txtBuscarActividades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtBuscarActividades.Text == "BUSCAR" || txtBuscarActividades.Text.Trim() == "")
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Ingrese un ID";

                    P1.ShowDialog();
                }
                else
                {
                    this.BuscarActividad();
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

        private void btnEliminarActividades_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarActividadCentro();

            if (verificar)
            {
                verificar = this.VerificarActividadAdulto();
            }

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.EliminarActividad();
                }
                else
                {
                    this.LimpiarPanActividad();
                }
            }
        }

        private void btnModificarActividades_Click(object sender, EventArgs e)
        {
            AgregarCentros P1 = new AgregarCentros();

            this.LlenarPantallaModificarActividad();

            this.LimpiarPanActividad();
        }

        void LimpiarPanActividad()
        {
            btnModificarActividades.Visible = false;
            btnEliminarActividades.Visible = false;
            txtBuscarActividades.Text = "BUSCAR";
            txtBuscarActividades.ForeColor = Color.DimGray;
            this.CargarDGVActividades();
        }

        void BuscarActividad()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            string cargo = MenuPrincipal.Cargo;

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarActividad";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idActividad", int.Parse(txtBuscarActividades.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count == 0)
                {
                    if (cargo == "ADMINISTRADOR")
                    {
                        DialogResult resultado = new DialogResult();
                        Form mensaje = new MensajeNoexiste();

                        resultado = mensaje.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            AgregarActividad P1 = new AgregarActividad();

                            P1.txtIdActividad.Text = txtBuscarActividades.Text;
                            P1.txtIdActividad.ForeColor = Color.White;
                            P1.txtIdActividad.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanActividad();
                        }
                        else
                        {
                            btnModificarActividades.Visible = false;
                            btnEliminarActividades.Visible = false;
                        }
                    }
                    else
                    {
                        MensajeVerificacion P1 = new MensajeVerificacion();

                        P1.lblMensajeError.Text = "No existe el ID";
                        P1.ShowDialog();
                    }
                }
                else
                {
                    if (cargo == "ADMINISTRADOR")
                    {
                        dgvActividades.DataSource = datos;

                        btnModificarActividades.Visible = true;
                        btnEliminarActividades.Visible = true;
                    }
                    else
                    {
                        dgvActividades.DataSource = datos;
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

        void EliminarActividad()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarActividad";

                if (txtBuscarActividades.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idActividad", int.Parse(dgvActividades.Rows[dgvActividades.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idActividad", int.Parse(txtBuscarActividades.Text));
                }

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

            this.LimpiarPanActividad();
        }

        void LlenarPantallaModificarActividad()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            AgregarActividad P1 = new AgregarActividad();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarActividad";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                if (txtBuscarActividades.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idActividad", int.Parse(dgvActividades.Rows[dgvActividades.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idActividad", int.Parse(txtBuscarActividades.Text));
                }
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                if (txtBuscarActividades.Text == "BUSCAR")
                {
                    P1.txtIdActividad.Text = dgvActividades.Rows[dgvActividades.CurrentRow.Index].Cells[0].Value.ToString();
                    P1.txtIdActividad.ReadOnly = true;
                    P1.txtIdActividad.ForeColor = Color.White;
                }
                else
                {
                    P1.txtIdActividad.Text = datos.Rows[0]["ID_ACTIVIDAD"].ToString();
                    P1.txtIdActividad.ReadOnly = true;
                    P1.txtIdActividad.ForeColor = Color.White;
                }
                P1.txtNombre.Text = datos.Rows[0]["NOMBRE"].ToString();
                P1.txtNombre.ForeColor = Color.White;
                P1.txtDescripcion.Text = datos.Rows[0]["DESCRIPCION"].ToString();
                P1.txtDescripcion.ForeColor = Color.White;

                P1.ShowDialog();
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

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            if (cargo == "ADMINISTRADOR")
            {
                txtBuscarActividades.Text = "BUSCAR";
                txtBuscarActividades.ForeColor = Color.DimGray;

                btnModificarActividades.Visible = true;
                btnEliminarActividades.Visible = true;
            }
        }

        public void CargarDGVActividadCentro()
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
                comando.CommandText = "spDatosActividadCentro";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvComprobarActApo.DataSource = datos;
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

        public void CargarDGVActividadAdulto()
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
                comando.CommandText = "spDatosActividadAdulto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvComprobarActApo.DataSource = datos;
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

        bool VerificarActividadCentro()
        {
            this.CargarDGVActividadCentro();

            bool verificar = true;
            int idActividad;

            if (txtBuscarActividades.Text == "BUSCAR")
            {
                idActividad = int.Parse(dgvActividades.Rows[dgvActividades.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                idActividad = int.Parse(txtBuscarActividades.Text);
            }

            for (int i = 0; i < dgvComprobarActApo.RowCount - 1; i++)
            {
                if (idActividad == int.Parse(dgvComprobarActApo.Rows[i].Cells[2].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no este\nasignada a un CENTRO";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }

        bool VerificarActividadAdulto()
        {
            this.CargarDGVActividadAdulto();

            bool verificar = true;
            int idActividad;

            if (txtBuscarActividades.Text == "BUSCAR")
            {
                idActividad = int.Parse(dgvActividades.Rows[dgvActividades.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                idActividad = int.Parse(txtBuscarActividades.Text);
            }

            for (int i = 0; i < dgvComprobarActApo.RowCount - 1; i++)
            {
                if (idActividad == int.Parse(dgvComprobarActApo.Rows[i].Cells[4].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no este\nasignada a un HUESPED";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }
    }
}
