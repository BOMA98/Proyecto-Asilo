using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIA_TP_II_ASILO
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void comboAyuda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAyuda.SelectedIndex == 0)
            {
                txtMensaje.Text = "Seleccione una opcion para poder brindar informacion de ayuda";
            }
            else if (comboAyuda.SelectedIndex == 1)
            {
                txtMensaje.Text = "Para poder buscar un registro solo tiene que ingresar en el TextBox que dice \"BUSCAR\" el ID, de la misma manera presionar Enter o presionar el botón de BUSCAR, esto verificara si existe el registro para mostrarlo en el DataGridView.";
            }
            else if (comboAyuda.SelectedIndex == 2)
            {
                txtMensaje.Text = "Para poder agregar un registro solo tiene que ingresar en el TextBox que dice \"BUSCAR\" el ID, de la misma manera presionar Enter o presionar el botón de BUSCAR, esto verificara si existe un registro en el caso contrario se le mostrara una ventana diciendo \"El ID no existe\" solo falta con presionar el botón Aceptar para agregarlo.\r\nNOTA: Verifique que su usuario sea ADMINISTRADOR de lo contrario no podrá agregar registros.";
            }
            else if (comboAyuda.SelectedIndex == 3)
            {
                txtMensaje.Text = "Para poder modificar un registro tiene dos maneras:\r\n1) En el Texbox que dice \"BUSCAR\" ingrese el ID del registro que desea modificar, de la misma manera presionar Enter o presionar el botón de BUSCAR, en consiguiente se le mostrara un botón que dice Modificar, solo falta con presionar el botón para modificar el registro.\r\n2)Seleccione un registro de la DataGridView en consiguiente se le mostrara el botón que dice Modificar, solo falta con presionar el botón para modificar el registro.\r\nNOTA: Verifique que su usuario sea ADMINISTRADOR de lo contrario no podrá modificar registros.";
            }
            else if (comboAyuda.SelectedIndex == 4)
            {
                txtMensaje.Text = "Para poder eliminar un registro tiene dos maneras:\r\n1) En el Texbox que dice \"BUSCAR\" ingrese el ID del registro que desea Eliminar, de la misma manera presionar Enter o presionar el botón de BUSCAR, en consiguiente se le mostrara un botón que dice Eliminar, solo falta con presionar el botón para Eliminar el registro.\r\n2)Seleccione un registro de la DataGridView en consiguiente se le mostrara el botón que dice Eliminar, solo falta con presionar el botón para Eliminar el registro.\r\nNOTA: Verifique que su usuario sea ADMINISTRADOR de lo contrario no podrá eliminar registros.";
            }
            else if (comboAyuda.SelectedIndex == 5)
            {
                txtMensaje.Text = "Para poder agregar un tipo de empleado, deberá que presionar en el menú la opción Empleado, de esa misma manera en la pantalla de Empleados abajo se le mostrara el botón que dice \"Tipos de Empleados\", depuse deberá que seguir con los pasos que se muestran en \"COMO AGREGAR UN REGISTRO\"";
            }
            else if (comboAyuda.SelectedIndex == 6)
            {
                txtMensaje.Text = "Para poder asignar una actividad a un centro, deberá que presionar en el Menú la opción Centros, de esa misma manera en la pantalla de Centros abajo se le mostrara el botón que dice \"Asignar Actividad\", después deberá presionar en el botón Asignar para poder asignar una actividad al Centro.\r\nNOTA: Verifique que su usuario sea ADMINISTRADOR de lo contrario no podrá Asignar actividades.";
            }
            else if (comboAyuda.SelectedIndex == 7)
            {
                txtMensaje.Text = "Para poder otorgar un apoyo a un huésped, deberá que presionar en el Menú la opción Huésped, de esa misma manera en la pantalla de Huéspedes abajo se le mostrara el botón que dice \"Otorgar Apoyo\", después deberá presionar en el botón Otorgar para poder otorgar un apoyo al Huésped.\r\nNOTA: Verifique que su usuario sea ADMINISTRADOR de lo contrario no podrá otorgar Apoyos.";
            }
            else
            {
                txtMensaje.Text = "Para poder asignar una actividad a un huésped, deberá que presionar en el Menú la opción Huésped, de esa misma manera en la pantalla de Huéspedes abajo se le mostrara el botón que dice \"Asignar Actividad\", después deberá presionar en el botón Asignar para poder asignar una actividad al Huésped.\r\nNOTA: Verifique que su usuario sea ADMINISTRADOR de lo contrario no podrá asignar Actividades.";
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            comboAyuda.SelectedIndex = 0;
        }
    }
}
