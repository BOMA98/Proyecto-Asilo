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
    public partial class MenuApoyos : UserControl
    {
        public MenuApoyos()
        {
            InitializeComponent();
        }

        public void CargarDGVApoyos()
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
                dgvApoyos.DataSource = datos;
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

        private void dgvApoyos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            if (cargo == "ADMINISTRADOR")
            {
                txtBuscarApoyos.Text = "BUSCAR";
                txtBuscarApoyos.ForeColor = Color.DimGray;

                btnModificarApoyos.Visible = true;
                btnEliminarApoyos.Visible = true;
            }
        }

        private void txtBuscarApoyos_Enter(object sender, EventArgs e)
        {
            if (txtBuscarApoyos.Text == "BUSCAR")
            {
                txtBuscarApoyos.Text = "";
                txtBuscarApoyos.ForeColor = Color.White;
            }
        }

        private void txtBuscarApoyos_Leave(object sender, EventArgs e)
        {
            if (txtBuscarApoyos.Text == "")
            {
                txtBuscarApoyos.Text = "BUSCAR";
                txtBuscarApoyos.ForeColor = Color.DimGray;
            }
        }

        private void btnRegresarApoyos_Click(object sender, EventArgs e)
        {
            CargarDGVApoyos();

            txtBuscarApoyos.Text = "BUSCAR";
            txtBuscarApoyos.ForeColor = Color.DimGray;

            btnModificarApoyos.Visible = false;
            btnEliminarApoyos.Visible = false;
        }

        private void btnBuscarApoyos_Click(object sender, EventArgs e)
        {
            if (txtBuscarApoyos.Text == "BUSCAR" || txtBuscarApoyos.Text.Trim() == "")
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Ingrese un ID";

                P1.ShowDialog();
            }
            else
            {
                BuscarApoyos();
            }
        }

        private void txtBuscarApoyos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtBuscarApoyos.Text == "BUSCAR" || txtBuscarApoyos.Text.Trim() == "")
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Ingrese un ID";

                    P1.ShowDialog();
                }
                else
                {
                    BuscarApoyos();
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

        private void btnEliminarApoyos_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarOtorgarApoyo();

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.EliminarApoyo();
                }
                else
                {
                    this.LimpiarPanApoyos();
                }
            }
        }

        private void btnModificarApoyos_Click(object sender, EventArgs e)
        {
            this.LlenarPantallaModificarApoyo();

            this.LimpiarPanApoyos();
        }

        void BuscarApoyos()
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
                comando.CommandText = "spBuscarApoyo";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idApoyo", int.Parse(txtBuscarApoyos.Text));
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
                            AgregarApoyos P1 = new AgregarApoyos();

                            P1.txtIdApoyo.Text = txtBuscarApoyos.Text;
                            P1.txtIdApoyo.ForeColor = Color.White;
                            P1.txtIdApoyo.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanApoyos();
                        }
                        else
                        {
                            btnModificarApoyos.Visible = false;
                            btnEliminarApoyos.Visible = false;
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
                        dgvApoyos.DataSource = datos;

                        btnModificarApoyos.Visible = true;
                        btnEliminarApoyos.Visible = true;
                    }
                    else
                    {
                        dgvApoyos.DataSource = datos;
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

        void LimpiarPanApoyos()
        {
            btnModificarApoyos.Visible = false;
            btnEliminarApoyos.Visible = false;
            txtBuscarApoyos.Text = "BUSCAR";
            txtBuscarApoyos.ForeColor = Color.DimGray;
            this.CargarDGVApoyos();
        }

        void EliminarApoyo()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarApoyo";

                if (txtBuscarApoyos.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idApoyo", int.Parse(dgvApoyos.Rows[dgvApoyos.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idApoyo", int.Parse(txtBuscarApoyos.Text));
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

            this.LimpiarPanApoyos();
        }

        void LlenarPantallaModificarApoyo()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            AgregarApoyos P1 = new AgregarApoyos();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarApoyo";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                if (txtBuscarApoyos.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idApoyos", int.Parse(dgvApoyos.Rows[dgvApoyos.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idApoyos", int.Parse(txtBuscarApoyos.Text));
                }

                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);



                if (txtBuscarApoyos.Text == "BUSCAR")
                {
                    P1.txtIdApoyo.Text = dgvApoyos.Rows[dgvApoyos.CurrentRow.Index].Cells[0].Value.ToString();
                    P1.txtIdApoyo.ReadOnly = true;
                    P1.txtIdApoyo.ForeColor = Color.White;
                }
                else
                {
                    P1.txtIdApoyo.Text = datos.Rows[0]["ID_APOYO"].ToString();
                    P1.txtIdApoyo.ReadOnly = true;
                    P1.txtIdApoyo.ForeColor = Color.White;
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

        public void CargarDGVOtorgarApoyo()
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
                comando.CommandText = "spDatosAdultoApoyos";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvOtorgarApoyo.DataSource = datos;
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

        bool VerificarOtorgarApoyo()
        {
            this.CargarDGVOtorgarApoyo();

            bool verificar = true;
            int idApoyo;

            if (txtBuscarApoyos.Text == "BUSCAR")
            {
                idApoyo = int.Parse(dgvApoyos.Rows[dgvApoyos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                idApoyo = int.Parse(txtBuscarApoyos.Text);
            }

            for (int i = 0; i < dgvOtorgarApoyo.RowCount - 1; i++)
            {
                if (idApoyo == int.Parse(dgvOtorgarApoyo.Rows[i].Cells[4].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no este\notorgada a un HUESPED";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }
    }
}
