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
    public partial class MenuContactos : UserControl
    {
        public MenuContactos()
        {
            InitializeComponent();
        }

        private void txtBuscarContactos_Enter(object sender, EventArgs e)
        {
            if (txtBuscarContactos.Text == "BUSCAR")
            {
                txtBuscarContactos.Text = "";
                txtBuscarContactos.ForeColor = Color.White;
            }
        }

        private void txtBuscarContactos_Leave(object sender, EventArgs e)
        {
            if (txtBuscarContactos.Text == "")
            {
                txtBuscarContactos.Text = "BUSCAR";
                txtBuscarContactos.ForeColor = Color.DimGray;
            }
        }

        private void btnRegresarcontactos_Click(object sender, EventArgs e)
        {
            CargarDGVContactos();

            txtBuscarContactos.Text = "BUSCAR";
            txtBuscarContactos.ForeColor = Color.DimGray;

            btnModificarContactos.Visible = false;
            btnEliminarContactos.Visible = false;
        }

        public void CargarDGVContactos()
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
                comando.CommandText = "spDatosContacto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvContactos.DataSource = datos;
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

        private void btnBuscarContactos_Click(object sender, EventArgs e)
        {
            if (txtBuscarContactos.Text == "BUSCAR" || txtBuscarContactos.Text.Trim() == "")
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Ingrese un ID";

                P1.ShowDialog();
            }
            else
            {
                BuscarContacto();
            }
        }

        private void txtBuscarContactos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txtBuscarContactos.Text == "BUSCAR" || txtBuscarContactos.Text.Trim() == "")
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Ingrese un ID";

                    P1.ShowDialog();
                }
                else
                {
                    BuscarContacto();
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

        private void btnEliminarContactos_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarAdulto();

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.EliminarContacto();
                }
                else
                {
                    this.LimpiarPanContacto();
                }
            }
        }

        private void btnModificarContactos_Click(object sender, EventArgs e)
        {
            AgregarContactos P1 = new AgregarContactos();

            if (txtBuscarContactos.Text == "BUSCAR")
            {
                P1.LlenarPantallaModificarContacto(int.Parse(dgvContactos.Rows[dgvContactos.CurrentRow.Index].Cells[0].Value.ToString()));

            }
            else
            {
                P1.LlenarPantallaModificarContacto(int.Parse(txtBuscarContactos.Text));
            }

            this.LimpiarPanContacto();
        }

        void BuscarContacto()
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
                comando.CommandText = "spBuscarContacto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idContacto", int.Parse(txtBuscarContactos.Text));
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
                            AgregarContactos P1 = new AgregarContactos();

                            P1.txtIdContacto.Text = txtBuscarContactos.Text;
                            P1.txtIdContacto.ForeColor = Color.White;
                            P1.txtIdContacto.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanContacto();
                        }
                        else
                        {
                            btnModificarContactos.Visible = false;
                            btnEliminarContactos.Visible = false;
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
                        dgvContactos.DataSource = datos;

                        btnModificarContactos.Visible = true;
                        btnEliminarContactos.Visible = true;
                    }
                    else
                    {
                        dgvContactos.DataSource = datos;
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

        void LimpiarPanContacto()
        {
            btnModificarContactos.Visible = false;
            btnEliminarContactos.Visible = false;
            txtBuscarContactos.Text = "BUSCAR";
            txtBuscarContactos.ForeColor = Color.DimGray;
            CargarDGVContactos();
        }

        void EliminarContacto()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarContacto";

                if (txtBuscarContactos.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idContacto", int.Parse(dgvContactos.Rows[dgvContactos.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idContacto", int.Parse(txtBuscarContactos.Text));
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

            LimpiarPanContacto();
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            if (cargo == "ADMINISTRADOR")
            {
                txtBuscarContactos.Text = "BUSCAR";
                txtBuscarContactos.ForeColor = Color.DimGray;

                btnModificarContactos.Visible = true;
                btnEliminarContactos.Visible = true;
            }
        }

        public void CargarDGVAdulto()
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
                comando.CommandText = "spDatosAdulto3";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvAdultos.DataSource = datos;
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

        bool VerificarAdulto()
        {
            this.CargarDGVAdulto();

            bool verificar = true;
            int idContacto;

            if (txtBuscarContactos.Text == "BUSCAR")
            {
                idContacto = int.Parse(dgvContactos.Rows[dgvContactos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                idContacto = int.Parse(txtBuscarContactos.Text);
            }

            for (int i = 0; i < dgvAdultos.RowCount - 1; i++)
            {
                if (idContacto == int.Parse(dgvAdultos.Rows[i].Cells[6].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no tenga\nasignado un HUESPED";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }
    }
}
