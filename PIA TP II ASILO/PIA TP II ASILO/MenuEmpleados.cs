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
    public partial class MenuEmpleados : UserControl
    {
        public MenuEmpleados()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            lblEmpleados.Text = "Empleados";
            lblEmpleados.Location = new Point(161, 1);

            panelDetector.Location = new Point(10, 385);
            panelDetector.Size = new Size(btnCambiar.Width, 4);

            btnModificarEmpleado.Visible = false;
            btnEliminarEmpleado.Visible = false;

            this.CargarDGVEmpelados();
            this.LimpiarPanEmpleado();
        }

        private void btnTipoEmpleado_Click(object sender, EventArgs e)
        {
            lblEmpleados.Text = "Tipo de Empleados";
            lblEmpleados.Location = new Point(126, 1);

            panelDetector.Location = new Point(125, 385);
            panelDetector.Size = new Size(btnTipoEmpleado.Width, 4);

            btnModificarEmpleado.Visible = false;
            btnEliminarEmpleado.Visible = false;

            this.CargarDGVEmpelados();
            this.LimpiarPanEmpleado();
        }

        private void txtBuscarEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text == "BUSCAR")
            {
                txtBuscarEmpleado.Text = "";
                txtBuscarEmpleado.ForeColor = Color.White;
            }
        }

        private void txtBuscarEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text == "")
            {
                txtBuscarEmpleado.Text = "BUSCAR";
                txtBuscarEmpleado.ForeColor = Color.DimGray;
            }
        }

        private void txtBuscarEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtBuscarEmpleado.Text == "BUSCAR" || txtBuscarEmpleado.Text.Trim() == "")
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Ingrese un ID";

                    P1.ShowDialog();
                }
                else
                {
                    if (lblEmpleados.Text == "Empleados")
                    {
                        BuscarEmpleado();
                    }
                    else
                    {
                        BuscarTipoEmpleado();
                    }
                    
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

        public void CargarDGVEmpelados()
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

                if (lblEmpleados.Text == "Empleados")
                {
                    comando.CommandText = "spDatosEmpleado";
                }
                else
                {
                    comando.CommandText = "spDatosTipoEmp";
                }

                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvEmpleados.DataSource = datos;
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

        void BuscarEmpleado()
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
                comando.CommandText = "spBuscarEmpleado";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idEmpleado", int.Parse(txtBuscarEmpleado.Text));
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
                            AgregarEmpleados P1 = new AgregarEmpleados();

                            P1.txtIdEmpleado.Text = txtBuscarEmpleado.Text;
                            P1.txtIdEmpleado.ForeColor = Color.White;
                            P1.txtIdEmpleado.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanEmpleado();
                        }
                        else
                        {
                            btnModificarEmpleado.Visible = false;
                            btnEliminarEmpleado.Visible = false;
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
                        dgvEmpleados.DataSource = datos;

                        btnModificarEmpleado.Visible = true;
                        btnEliminarEmpleado.Visible = true;
                    }
                    else
                    {
                        dgvEmpleados.DataSource = datos;
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

        void BuscarTipoEmpleado()
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
                comando.CommandText = "spBuscarTipoEmp";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idTipoEmp", int.Parse(txtBuscarEmpleado.Text));
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
                            AgregarTiposEmpleados P1 = new AgregarTiposEmpleados();

                            P1.txtIdTipoEmpleado.Text = txtBuscarEmpleado.Text;
                            P1.txtIdTipoEmpleado.ForeColor = Color.White;
                            P1.txtIdTipoEmpleado.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanEmpleado();
                        }
                        else
                        {
                            btnModificarTiposEmpleados.Visible = false;
                            btnEliminarTiposEmpleados.Visible = false;
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
                        dgvEmpleados.DataSource = datos;

                        btnModificarTiposEmpleados.Visible = true;
                        btnEliminarTiposEmpleados.Visible = true;
                    }
                    else
                    {
                        dgvEmpleados.DataSource = datos;
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

        void LimpiarPanEmpleado()
        {
            if (txtBuscarEmpleado.Text == "Empleados")
            {
                btnModificarEmpleado.Visible = false;
                btnEliminarEmpleado.Visible = false;
            }
            else
            {
                btnModificarTiposEmpleados.Visible = false;
                btnEliminarTiposEmpleados.Visible = false;
            }

            txtBuscarEmpleado.Text = "BUSCAR";
            txtBuscarEmpleado.ForeColor = Color.DimGray;
            this.CargarDGVEmpelados();
        }

        void EliminarEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarEmpleado";

                if (txtBuscarEmpleado.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idEmpleado", int.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idEmpleado", int.Parse(txtBuscarEmpleado.Text));
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

            LimpiarPanEmpleado();
        }

        void EliminarTipoEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarTipoEmp";

                if (txtBuscarEmpleado.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idTipoEmp", int.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idTipoEmp", int.Parse(txtBuscarEmpleado.Text));
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

            LimpiarPanEmpleado();
        }

        void LlenarPantallaModificarTipoEmpleado()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            AgregarTiposEmpleados P1 = new AgregarTiposEmpleados();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarTipoEmp";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                if (txtBuscarEmpleado.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idTipoEmp", int.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idTipoEmp", int.Parse(txtBuscarEmpleado.Text));
                }

                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);



                if (txtBuscarEmpleado.Text == "BUSCAR")
                {
                    P1.txtIdTipoEmpleado.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString();
                    P1.txtIdTipoEmpleado.ReadOnly = true;
                    P1.txtIdTipoEmpleado.ForeColor = Color.White;
                }
                else
                {
                    P1.txtIdTipoEmpleado.Text = datos.Rows[0]["ID_TIPO_EMPLEADO"].ToString();
                    P1.txtIdTipoEmpleado.ReadOnly = true;
                    P1.txtIdTipoEmpleado.ForeColor = Color.White;
                }

                P1.txtTipoEmpleado.Text = datos.Rows[0]["TIPO_EMPLEADO"].ToString();
                P1.txtTipoEmpleado.ForeColor = Color.White;

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

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            if (cargo == "ADMINISTRADOR")
            {
                txtBuscarEmpleado.Text = "BUSCAR";
                txtBuscarEmpleado.ForeColor = Color.DimGray;

                if (lblEmpleados.Text == "Empleados")
                {
                    btnModificarEmpleado.Visible = true;
                    btnEliminarEmpleado.Visible = true;
                }
                else
                {
                    btnModificarTiposEmpleados.Visible = true;
                    btnEliminarTiposEmpleados.Visible = true;
                }
            }
            
        }

        private void btnModificarTiposEmpleados_Click(object sender, EventArgs e)
        {
            this.LlenarPantallaModificarTipoEmpleado();

            this.LimpiarPanEmpleado();
        }

        private void btnEliminarTiposEmpleados_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarTipoEmpleado();

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.EliminarTipoEmpleado();
                }
                else
                {
                    this.LimpiarPanEmpleado();
                }
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text == "BUSCAR" || txtBuscarEmpleado.Text.Trim() == "")
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Ingrese un ID";

                P1.ShowDialog();
            }
            else
            {
                if (lblEmpleados.Text == "Empleados")
                {
                    BuscarEmpleado();
                }
                else
                {
                    BuscarTipoEmpleado();
                }
            }
        }

        private void btnRegresarEmpleado_Click(object sender, EventArgs e)
        {
            this.CargarDGVEmpelados();

            txtBuscarEmpleado.Text = "BUSCAR";
            txtBuscarEmpleado.ForeColor = Color.DimGray;
            btnModificarEmpleado.Visible = false;
            btnEliminarEmpleado.Visible = false;
            btnModificarTiposEmpleados.Visible = false;
            btnEliminarTiposEmpleados.Visible = false;
            
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleados P1 = new AgregarEmpleados();

            if (txtBuscarEmpleado.Text == "BUSCAR")
            {
                P1.LlenarPantallaModificarEmpleado(int.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString()));

            }
            else
            {
                P1.LlenarPantallaModificarEmpleado(int.Parse(txtBuscarEmpleado.Text));
            }

            this.LimpiarPanEmpleado();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarEmpleado();

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.EliminarEmpleado();
                }
                else
                {
                    this.LimpiarPanEmpleado();
                }
            }
        }

        void CargarDGVUsuario()
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
                if (lblEmpleados.Text == "Empleados")
                {
                    comando.CommandText = "spDatosUsuarioEmpleado2";
                }
                else
                {
                    comando.CommandText = "spDatosEmpleado2";
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

        bool VerificarEmpleado()
        {
            this.CargarDGVUsuario();

            bool verificar = true;
            int centro;

            if (txtBuscarEmpleado.Text == "BUSCAR")
            {
                centro = int.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                centro = int.Parse(txtBuscarEmpleado.Text);
            }

            for (int i = 0; i < dgvUsuarios.RowCount - 1; i++)
            {
                if (centro == int.Parse(dgvUsuarios.Rows[i].Cells[1].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no tenga\nasignado un USUARIO";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }

        bool VerificarTipoEmpleado()
        {
            this.CargarDGVUsuario();

            bool verificar = true;
            int idTipoEmp;

            if (txtBuscarEmpleado.Text == "BUSCAR")
            {
                idTipoEmp = int.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                idTipoEmp = int.Parse(txtBuscarEmpleado.Text);
            }

            for (int i = 0; i < dgvUsuarios.RowCount - 1; i++)
            {
                if (idTipoEmp == int.Parse(dgvUsuarios.Rows[i].Cells[9].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no fue\nasignado a un EMPLEADO";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }
    }
}
