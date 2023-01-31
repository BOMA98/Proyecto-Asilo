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
    public partial class MenuUsuarios : UserControl
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void txtBuscarUsuarios_Enter(object sender, EventArgs e)
        {
            if (txtBuscarUsuarios.Text == "BUSCAR")
            {
                txtBuscarUsuarios.Text = "";
                txtBuscarUsuarios.ForeColor = Color.White;
            }
        }

        private void txtBuscarUsuarios_Leave(object sender, EventArgs e)
        {
            if (txtBuscarUsuarios.Text == "")
            {
                txtBuscarUsuarios.Text = "BUSCAR";
                txtBuscarUsuarios.ForeColor = Color.DimGray;
            }
        }

        private void btnCanelarUsuario_Click(object sender, EventArgs e)
        {
            CargarDGVUsuarios();

            txtBuscarUsuarios.Text = "BUSCAR";
            txtBuscarUsuarios.ForeColor = Color.DimGray;

            btnModificarUsuarios.Visible = false;
            btnEliminarUsuarios.Visible = false;
        }

        public void CargarDGVUsuarios()
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
                if (cargo == "ADMINISTRADOR")
                {
                    comando.CommandText = "spDatosUsuario";
                }
                else
                {
                    comando.CommandText = "spDatosUsuarioEmpleado";
                }
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);


                dgvUsuarios.DataSource = datos;
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

        private void btnBuscarUsuarios_Click(object sender, EventArgs e)
        {
            if (txtBuscarUsuarios.Text == "BUSCAR" || txtBuscarUsuarios.Text.Trim() == "")
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Ingrese un ID";

                P1.ShowDialog();
            }
            else
            {
                BuscarUsuario();
            }
        }

        private void txtBuscarUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtBuscarUsuarios.Text == "BUSCAR" || txtBuscarUsuarios.Text.Trim() == "")
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Ingrese un ID";

                    P1.ShowDialog();
                }
                else
                {
                    BuscarUsuario();
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

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarCentro();

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.EliminarUsuario();
                }
                else
                {
                    this.LimpiarPanUsuario();
                }
            }
        }

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {
            AgregarUsuarios P1 = new AgregarUsuarios();

            if (txtBuscarUsuarios.Text == "BUSCAR")
            {
                P1.LlenarPantallaModificarUsuario(int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString()));
                    
            }
            else
            {
                P1.LlenarPantallaModificarUsuario(int.Parse(txtBuscarUsuarios.Text));
            }

            this.LimpiarPanUsuario();
        }

        void BuscarUsuario()
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
                if (cargo == "ADMINISTRADOR")
                {
                    comando.CommandText = "spBuscarUsuario";
                }
                else
                {
                    comando.CommandText = "spBuscarUsuarioEmp";
                }
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idUsuario", int.Parse(txtBuscarUsuarios.Text));
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
                            AgregarUsuarios P1 = new AgregarUsuarios();

                            P1.txtIdUsuario.Text = txtBuscarUsuarios.Text;
                            P1.txtIdUsuario.ForeColor = Color.White;
                            P1.txtIdUsuario.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanUsuario();
                        }
                        else
                        {
                            btnModificarUsuarios.Visible = false;
                            btnEliminarUsuarios.Visible = false;
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
                        dgvUsuarios.DataSource = datos;

                        btnModificarUsuarios.Visible = true;
                        btnEliminarUsuarios.Visible = true;
                    }
                    else
                    {
                        dgvUsuarios.DataSource = datos;
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

        void LimpiarPanUsuario()
        {
            btnModificarUsuarios.Visible = false;
            btnEliminarUsuarios.Visible = false;
            txtBuscarUsuarios.Text = "BUSCAR";
            txtBuscarUsuarios.ForeColor = Color.DimGray;
            CargarDGVUsuarios();
        }

        void EliminarUsuario()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarUsuario";

                if (txtBuscarUsuarios.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idUsuario", int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idUsuario", int.Parse(txtBuscarUsuarios.Text));
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

            LimpiarPanUsuario();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            if (cargo == "ADMINISTRADOR")
            {
                txtBuscarUsuarios.Text = "BUSCAR";
                txtBuscarUsuarios.ForeColor = Color.DimGray;

                btnModificarUsuarios.Visible = true;
                btnEliminarUsuarios.Visible = true;
            }
        }

        bool VerificarCentro()
        {
            bool verificar = true;
            int idusuario = MenuPrincipal.IdCargo;
            int deleUsuario;

            if (txtBuscarUsuarios.Text == "BUSCAR")
            {
                deleUsuario = int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                deleUsuario = int.Parse(txtBuscarUsuarios.Text);
            }

            if (idusuario == deleUsuario)
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Imposible eliminar\nUSUARIO en uso";
                P1.ShowDialog();

                verificar = false;
            }

            return verificar;
        }
    }
}
