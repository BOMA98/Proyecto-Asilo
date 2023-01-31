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
    public partial class MenuCentros : UserControl
    {
        public MenuCentros()
        {
            InitializeComponent();
        }

        private void txtBuscarCentro_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCentro.Text == "BUSCAR")
            {
                txtBuscarCentro.Text = "";
                txtBuscarCentro.ForeColor = Color.White;
            }
        }

        private void txtBuscarCentro_Leave(object sender, EventArgs e)
        {
            if (txtBuscarCentro.Text == "")
            {
                txtBuscarCentro.Text = "BUSCAR";
                txtBuscarCentro.ForeColor = Color.DimGray;
            }
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            CargarDGVCentros();

            txtBuscarCentro.Text = "BUSCAR";
            txtBuscarCentro.ForeColor = Color.DimGray;

            this.LimpiarPanCentro();
        }

        public void CargarDGVCentros()
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
                if (lblCentro.Text == "Centros")
                {
                    comando.CommandText = "spBuscarTodosCentros";
                }
                else
                {
                    comando.CommandText = "spDatosActividadCentro";
                }
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvCentros.DataSource = datos;
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

        private void btnBuscarCentro_Click(object sender, EventArgs e)
        {
            if (txtBuscarCentro.Text == "BUSCAR" || txtBuscarCentro.Text.Trim() == "")
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Ingrese un ID";

                P1.ShowDialog();
            }
            else
            {
                if (lblCentro.Text == "Centros")
                {
                    BuscarCentro();
                }
                else
                {
                    BuscarActividadCentro();
                }
                
            }
        }

        private void txtBuscarCentro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txtBuscarCentro.Text == "BUSCAR" || txtBuscarCentro.Text.Trim() == "")
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Ingrese un ID";

                    P1.ShowDialog();
                }
                else
                {
                    if (lblCentro.Text == "Centros")
                    {
                        BuscarCentro();
                    }
                    else
                    {
                        BuscarActividadCentro();
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

        private void btnEliminarCentro_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarCentro();

            if (verificar)
            {
                verificar = this.VerificarEmpleado();
            }

            if (verificar)
            {
                 verificar = this.VerificarAdulto();
            }

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();



                if (resultado == DialogResult.OK)
                {
                    this.EliminarCentro();
                }
                else
                {
                    this.LimpiarPanCentro();
                }
            }
            
        }

        private void btnModificarCentro_Click(object sender, EventArgs e)
        {
            this.LlenarPantallaModificarCentro();

            this.LimpiarPanCentro();
        }

        void BuscarCentro()
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
                comando.CommandText = "spBuscarCentro";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", int.Parse(txtBuscarCentro.Text));
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
                            AgregarCentros P1 = new AgregarCentros();

                            P1.txtIdCentro.Text = txtBuscarCentro.Text;
                            P1.txtIdCentro.ForeColor = Color.White;
                            P1.txtIdCentro.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanCentro();
                        }
                        else
                        {
                            btnModificarCentro.Visible = false;
                            btnEliminarCentro.Visible = false;
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
                        dgvCentros.DataSource = datos;
                        
                        btnModificarCentro.Visible = true;
                        btnEliminarCentro.Visible = true;
                    }
                    else
                    {
                        dgvCentros.DataSource = datos;
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

        void BuscarActividadCentro()
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
                comando.CommandText = "spBuscarActividadCentro";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idCentro", int.Parse(txtBuscarCentro.Text));
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                if (datos.Rows.Count == 0)
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "No existe el ID";
                    P1.ShowDialog();
                }
                else
                {
                    if (cargo == "ADMINISTRADOR")
                    {
                        dgvCentros.DataSource = datos;
                    }
                    else
                    {
                        dgvCentros.DataSource = datos;
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

        void LimpiarPanCentro()
        {
            btnModificarCentro.Visible = false;
            btnEliminarCentro.Visible = false;
            btnEliminarActividad.Visible = false;
            btnModificarActividad.Visible = false;
            if (lblCentro.Text == "Centros")
            {
                btnAsignar.Visible = false;
            }
            txtBuscarCentro.Text = "BUSCAR";
            txtBuscarCentro.ForeColor = Color.DimGray;
            CargarDGVCentros();
        }

        void EliminarCentro()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarCentro";

                if (txtBuscarCentro.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idCentro", int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idCentro", int.Parse(txtBuscarCentro.Text));
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

            LimpiarPanCentro();
        }

        void EliminarActividadCentro()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarActividadCentro";


                comando.Parameters.Add("p_idCentro", int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString()));
                comando.Parameters.Add("p_idActividad", int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[2].Value.ToString()));
                

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

            LimpiarPanCentro();
        }

        void LlenarPantallaModificarCentro()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();
            DataTable datos = new DataTable();
            AgregarCentros P1 = new AgregarCentros();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBuscarCentro";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                if (txtBuscarCentro.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idCentro", int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idCentro", int.Parse(txtBuscarCentro.Text));
                }

                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

                

                if (txtBuscarCentro.Text == "BUSCAR")
                {
                    P1.txtIdCentro.Text = dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString();
                    P1.txtIdCentro.ReadOnly = true;
                    P1.txtIdCentro.ForeColor = Color.White;
                }
                else
                {
                    P1.txtIdCentro.Text = datos.Rows[0]["ID_CENTRO"].ToString();
                    P1.txtIdCentro.ReadOnly = true;
                    P1.txtIdCentro.ForeColor = Color.White;
                }

                P1.txtNombre.Text = datos.Rows[0]["NOMBRE"].ToString();
                P1.txtNombre.ForeColor = Color.White;
                P1.txtDomicilio.Text = datos.Rows[0]["DIRECCION"].ToString();
                P1.txtDomicilio.ForeColor = Color.White;
                P1.txtTelefono.Text = datos.Rows[0]["TELEFONO"].ToString();
                P1.txtTelefono.ForeColor = Color.White;

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

        private void dgvCentros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            if (cargo == "ADMINISTRADOR")
            {
                txtBuscarCentro.Text = "BUSCAR";
                txtBuscarCentro.ForeColor = Color.DimGray;

                if (lblCentro.Text == "Centros")
                {
                    btnModificarCentro.Visible = true;
                    btnEliminarCentro.Visible = true;
                }
                else
                {
                    btnModificarActividad.Visible = true;
                    btnEliminarActividad.Visible = true;
                }
                
            }
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            lblCentro.Text = "Centros";
            lblCentro.Location = new Point(184, 1);

            panelDetector.Location = new Point(btnCentro.Location.X, 385);
            panelDetector.Size = new Size(btnCentro.Width, 4);

            btnModificarCentro.Visible = false;
            btnEliminarCentro.Visible = false;

            this.CargarDGVCentros();
            this.LimpiarPanCentro();
        }

        private void btnAsignarActividad_Click(object sender, EventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;
            
            lblCentro.Text = "Asignar Actividad";
            lblCentro.Location = new Point(143, 1);

            panelDetector.Location = new Point(btnAsignarActividad.Location.X, 385);
            panelDetector.Size = new Size(btnAsignarActividad.Width, 4);

            btnModificarCentro.Visible = false;
            btnEliminarCentro.Visible = false;

            this.CargarDGVCentros();
            this.LimpiarPanCentro();

            if (cargo == "ADMINISTRADOR")
            {
                btnAsignar.Visible = true;
            }
        }

        private void btnModificarActividad_Click(object sender, EventArgs e)
        {
            AsignarActividadCentro P1 = new AsignarActividadCentro();

            P1.LlenarPantallaModificarEmpleado(int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString()), int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[2].Value.ToString()));
            
            this.LimpiarPanCentro();
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MensajeEliminarConfimacion();

            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.EliminarActividadCentro();
            }
            else
            {
                this.LimpiarPanCentro();
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            AsignarActividadCentro P1 = new AsignarActividadCentro();

            P1.txtVerificar.Text = "Agregar";
            P1.txtVerificar.ReadOnly = false;
            P1.comboCentro.Enabled = true;

            P1.ShowDialog();

            this.LimpiarPanCentro();
        }

        void CargarDGVCentroAct()
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
                dgvCentroActividades.DataSource = datos;
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

        void CargarDGVCentroEmpleado()
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
                comando.CommandText = "spDatosEmpleado2";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                dgvCentroActividades.DataSource = datos;
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

        void CargarDGVCentroAdulto()
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
                dgvCentroActividades.DataSource = datos;
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

        bool VerificarCentro()
        {
            this.CargarDGVCentroAct();

            bool verificar = true;
            int centro;

            if (txtBuscarCentro.Text == "BUSCAR")
            {
                centro = int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                centro = int.Parse(txtBuscarCentro.Text);
            }

            for (int i = 0; i < dgvCentroActividades.RowCount - 1; i++)
            {
                if (centro == int.Parse(dgvCentroActividades.Rows[i].Cells[0].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no tenga\nasignada ACTIVIDADES";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }

        bool VerificarEmpleado()
        {
            this.CargarDGVCentroEmpleado();

            bool verificar = true;
            int centro;

            if (txtBuscarCentro.Text == "BUSCAR")
            {
                centro = int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                centro = int.Parse(txtBuscarCentro.Text);
            }

            for (int i = 0; i < dgvCentroActividades.RowCount - 1; i++)
            {
                if (centro == int.Parse(dgvCentroActividades.Rows[i].Cells[10].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no este\nasignado a un EMPLEADO";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }

        bool VerificarAdulto()
        {
            this.CargarDGVCentroAdulto();

            bool verificar = true;
            int centro;

            if (txtBuscarCentro.Text == "BUSCAR")
            {
                centro = int.Parse(dgvCentros.Rows[dgvCentros.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                centro = int.Parse(txtBuscarCentro.Text);
            }

            for (int i = 0; i < dgvCentroActividades.RowCount - 1; i++)
            {
                if (centro == int.Parse(dgvCentroActividades.Rows[i].Cells[7].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no este\nasignado a un HUESPED";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }
    }
}
