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
    public partial class MenuAdultos : UserControl
    {
        public MenuAdultos()
        {
            InitializeComponent();
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
                if (lblAdultos.Text == "Huéspedes")
                {
                    comando.CommandText = "spDatosAdulto";
                }
                else if (lblAdultos.Text == "Otorgar Apoyo")
                {
                    comando.CommandText = "spDatosAdultoApoyos"; 
                }
                else
                {
                    comando.CommandText = "spDatosActividadAdulto";
                }
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

        private void txtBuscarAdultos_Enter(object sender, EventArgs e)
        {
            if (txtBuscarAdultos.Text == "BUSCAR")
            {
                txtBuscarAdultos.Text = "";
                txtBuscarAdultos.ForeColor = Color.White;
            }
        }

        private void txtBuscarAdultos_Leave(object sender, EventArgs e)
        {
            if (txtBuscarAdultos.Text == "")
            {
                txtBuscarAdultos.Text = "BUSCAR";
                txtBuscarAdultos.ForeColor = Color.DimGray;
            }
        }

        private void txtBuscarAdultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtBuscarAdultos.Text == "BUSCAR" || txtBuscarAdultos.Text.Trim() == "")
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Ingrese un ID";

                    P1.ShowDialog();
                }
                else
                {
                    if (lblAdultos.Text == "Huéspedes")
                    {
                        BuscarAdulto();
                    }
                    else if (lblAdultos.Text == "Otorgar Apoyo")
                    {
                        BuscarAdultoApoyo();
                    }
                    else
                    {
                        BuscarAdultoActividades();
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

        private void btnBuscarAdultos_Click(object sender, EventArgs e)
        {
            if (txtBuscarAdultos.Text == "BUSCAR" || txtBuscarAdultos.Text.Trim() == "")
            {
                MensajeVerificacion P1 = new MensajeVerificacion();

                P1.lblMensajeError.Text = "Ingrese un ID";

                P1.ShowDialog();
            }
            else
            {
                if (lblAdultos.Text == "Huéspedes")
                {
                    BuscarAdulto();
                }
                else if (lblAdultos.Text == "Otorgar Apoyo")
                {
                    BuscarAdultoApoyo();
                }
                else
                {
                    BuscarAdultoActividades();
                }
            }
        }

        private void btnRegresarAdultos_Click(object sender, EventArgs e)
        {
            CargarDGVAdulto();

            txtBuscarAdultos.Text = "BUSCAR";
            txtBuscarAdultos.ForeColor = Color.DimGray;

            this.LimpiarPanAdulto();
        }

        void BuscarAdulto()
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
                comando.CommandText = "spBuscarAdulto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idAdulto", int.Parse(txtBuscarAdultos.Text));
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
                            AgregarAdultos P1 = new AgregarAdultos();

                            P1.txtIdAdulto.Text = txtBuscarAdultos.Text;
                            P1.txtIdAdulto.ForeColor = Color.White;
                            P1.txtIdAdulto.ReadOnly = false;

                            P1.ShowDialog();

                            this.LimpiarPanAdulto();
                        }
                        else
                        {
                            btnModificarAdultos.Visible = false;
                            btnEliminarAdultos.Visible = false;
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
                        dgvAdultos.DataSource = datos;

                        btnModificarAdultos.Visible = true;
                        btnEliminarAdultos.Visible = true;
                    }
                    else
                    {
                        dgvAdultos.DataSource = datos;
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

        void BuscarAdultoApoyo()
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
                comando.CommandText = "spBuscarAdultoApoyo";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idAdulto", int.Parse(txtBuscarAdultos.Text));
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
                        dgvAdultos.DataSource = datos;
                    }
                    else
                    {
                        dgvAdultos.DataSource = datos;
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

        void BuscarAdultoActividades()
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
                comando.CommandText = "spBuscarActividadAdulto";
                comando.Parameters.Add("c_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("p_idAdulto", int.Parse(txtBuscarAdultos.Text));
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
                        dgvAdultos.DataSource = datos;
                    }
                    else
                    {
                        dgvAdultos.DataSource = datos;
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

        void LimpiarPanAdulto()
        {
            txtBuscarAdultos.Text = "BUSCAR";
            txtBuscarAdultos.ForeColor = Color.DimGray;

            if (lblAdultos.Text =="Huéspedes")
            {
                btnOtorgar.Visible = false;
                btnAsignarAct.Visible = false;
            }
            else if (lblAdultos.Text == "Otorgar Apoyo")
            {
                btnAsignarAct.Visible = false;
            }
            else
            {
                btnOtorgar.Visible = false;
            }
            btnModificarAdultos.Visible = false;
            btnEliminarAdultos.Visible = false;
            btnModificarApoyo.Visible = false;
            btnEliminarApoyo.Visible = false;
            btnModificarAct.Visible = false;
            btnEliminarAct.Visible = false;

            this.CargarDGVAdulto();
        }

        void EliminarAdulto()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarAdulto";

                if (txtBuscarAdultos.Text == "BUSCAR")
                {
                    comando.Parameters.Add("p_idApoyo", int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                else
                {
                    comando.Parameters.Add("p_idApoyo", int.Parse(txtBuscarAdultos.Text));
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

            this.LimpiarPanAdulto();
        }

        void EliminarAdultoApoyo()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarAdultoApoyo";
                comando.Parameters.Add("p_idAdulto", int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString()));
                comando.Parameters.Add("p_idApoyo", int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[4].Value.ToString()));
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

            this.LimpiarPanAdulto();
        }

        void EliminarAdultoActividades()
        {
            OracleConnection con = new OracleConnection();
            OracleCommand comando = new OracleCommand();

            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ToString();
                con.Open();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spBorrarActividadAdulto";
                comando.Parameters.Add("p_idAdulto", int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString()));
                comando.Parameters.Add("p_idActividad", int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[4].Value.ToString()));
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

            this.LimpiarPanAdulto();
        }

        private void btnModificarAdultos_Click(object sender, EventArgs e)
        {
            AgregarAdultos P1 = new AgregarAdultos();

            if (txtBuscarAdultos.Text == "BUSCAR")
            {
                P1.LlenarPantallaModificarAdulto(int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString()));

            }
            else
            {
                P1.LlenarPantallaModificarAdulto(int.Parse(txtBuscarAdultos.Text));
            }

            this.LimpiarPanAdulto();
        }

        private void btnEliminarAdultos_Click(object sender, EventArgs e)
        {
            bool verificar = this.VerificarApoyo();

            if (verificar)
            {
                verificar = this.VerificarActividad();
            }

            if (verificar)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MensajeEliminarConfimacion();

                resultado = mensaje.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.EliminarAdulto();
                }
                else
                {
                    this.LimpiarPanAdulto();
                }
            }
        }

        private void dgvAdultos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            if (cargo == "ADMINISTRADOR")
            {
                txtBuscarAdultos.Text = "BUSCAR";
                txtBuscarAdultos.ForeColor = Color.DimGray;

                if (lblAdultos.Text == "Huéspedes")
                {
                    btnModificarAdultos.Visible = true;
                    btnEliminarAdultos.Visible = true;
                }
                else if (lblAdultos.Text == "Otorgar Apoyo")
                {
                    btnEliminarApoyo.Visible = true;
                    btnModificarApoyo.Visible = true;
                }
                else
                {
                    btnEliminarAct.Visible = true;
                    btnModificarAct.Visible = true;
                }
                
            }
        }

        private void btnAdulto_Click(object sender, EventArgs e)
        {
            lblAdultos.Text = "Huéspedes";
            lblAdultos.Location = new Point(163, 1);

            panelDetector.Location = new Point(btnAdulto.Location.X, 385);
            panelDetector.Size = new Size(btnAdulto.Width, 4);

            btnModificarAdultos.Visible = false;
            btnEliminarAdultos.Visible = false;

            this.CargarDGVAdulto();
            this.LimpiarPanAdulto();
        }

        private void btnOtorgarApoyos_Click(object sender, EventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            lblAdultos.Text = "Otorgar Apoyo";
            lblAdultos.Location = new Point(143, 1);

            panelDetector.Location = new Point(btnOtorgarApoyo.Location.X, 385);
            panelDetector.Size = new Size(btnOtorgarApoyo.Width, 4);

            btnModificarAdultos.Visible = false;
            btnEliminarAdultos.Visible = false;

            this.CargarDGVAdulto();
            this.LimpiarPanAdulto();

            if (cargo == "ADMINISTRADOR")
            {
                btnOtorgar.Visible = true;
            }
        }

        private void btnAsignarActividad_Click(object sender, EventArgs e)
        {
            string cargo = MenuPrincipal.Cargo;

            lblAdultos.Text = "Asignar Actividad";
            lblAdultos.Location = new Point(131, 1);

            panelDetector.Location = new Point(btnAsignarActividad.Location.X, 385);
            panelDetector.Size = new Size(btnAsignarActividad.Width, 4);

            btnModificarAdultos.Visible = false;
            btnEliminarAdultos.Visible = false;

            this.CargarDGVAdulto();
            this.LimpiarPanAdulto();

            if (cargo == "ADMINISTRADOR")
            {
                btnAsignarAct.Visible = true;
            }
        }

        private void btnEliminarApoyo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MensajeEliminarConfimacion();

            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.EliminarAdultoApoyo();
            }
            else
            {
                this.LimpiarPanAdulto();
            }
        }

        private void btnOtorgar_Click(object sender, EventArgs e)
        {
            OtorgarApoyos P1 = new OtorgarApoyos();

            P1.txtVerificar.Text = "Agregar";
            P1.txtVerificar.ReadOnly = false;
            P1.comboAdulto.Enabled = true;
            P1.comboApoyo.Enabled = true;

            P1.ShowDialog();

            this.LimpiarPanAdulto();
        }

        private void btnModificarApoyo_Click(object sender, EventArgs e)
        {
            OtorgarApoyos P1 = new OtorgarApoyos();

            P1.LlenarPantallaModificarApoyo(int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString()), int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[4].Value.ToString()));

            this.LimpiarPanAdulto();
        }

        private void btnEliminarAct_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MensajeEliminarConfimacion();

            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.EliminarAdultoActividades();
            }
            else
            {
                this.LimpiarPanAdulto();
            }
        }

        private void btnModificarAct_Click(object sender, EventArgs e)
        {
            AsignarActividadAdulto P1 = new AsignarActividadAdulto();

            P1.LlenarPantallaModificarAdultoActividad(int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString()), int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[4].Value.ToString()));

            this.LimpiarPanAdulto();
        }

        private void btnAsignarAct_Click(object sender, EventArgs e)
        {
            AsignarActividadAdulto P1 = new AsignarActividadAdulto();

            P1.txtVerificar.Text = "Agregar";
            P1.txtVerificar.ReadOnly = false;
            P1.comboAdulto.Enabled = true;
            P1.comboActividad.Enabled = true;

            P1.ShowDialog();

            this.LimpiarPanAdulto();
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
                comando.CommandText = "spDatosAdultoApoyos";
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

        public void CargarDGVActividad()
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
        
        bool VerificarApoyo()
        {
            this.CargarDGVApoyos();

            bool verificar = true;
            int centro;

            if (txtBuscarAdultos.Text == "BUSCAR")
            {
                centro = int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                centro = int.Parse(txtBuscarAdultos.Text);
            }

            for (int i = 0; i < dgvApoyos.RowCount - 1; i++)
            {
                if (centro == int.Parse(dgvApoyos.Rows[i].Cells[0].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no tenga\nasignado un APOYO";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }

        bool VerificarActividad()
        {
            this.CargarDGVActividad();

            bool verificar = true;
            int centro;

            if (txtBuscarAdultos.Text == "BUSCAR")
            {
                centro = int.Parse(dgvAdultos.Rows[dgvAdultos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            else
            {
                centro = int.Parse(txtBuscarAdultos.Text);
            }

            for (int i = 0; i < dgvApoyos.RowCount - 1; i++)
            {
                if (centro == int.Parse(dgvApoyos.Rows[i].Cells[0].Value.ToString()))
                {
                    MensajeVerificacion P1 = new MensajeVerificacion();

                    P1.lblMensajeError.Text = "Verifique que no tenga\nasignada una ACTIVIDAD";
                    P1.ShowDialog();

                    verificar = false;

                    break;
                }
            }

            return verificar;
        }
    }
}
