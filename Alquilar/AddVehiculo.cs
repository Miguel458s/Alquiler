using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Alquilar
{
    public partial class AddVehiculo : Form
    {
        public AddVehiculo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        void Nuevo()
        {
            PlacaTxt.Clear();
            MarcaTxt.Clear();
            KilometrajeTxt.Clear();
            PlacaTxt.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        void Guardar()
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.PlacaVehiculo = PlacaTxt.Text;
            vehiculo.Marca = MarcaTxt.Text;
            vehiculo.Kilometraje = double.Parse(KilometrajeTxt.Text);
            String Mensaje;
            ServicioVehiculos SC = new ServicioVehiculos();
            Mensaje = SC.Guardar(vehiculo);
            MessageBox.Show(Mensaje);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void MarcaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void KilometrajeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {

                e.Handled = true;
            }
        }
    }
}
