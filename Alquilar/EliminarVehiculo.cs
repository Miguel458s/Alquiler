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

namespace Alquilar
{
    public partial class EliminarVehiculo : Form
    {
        public EliminarVehiculo()
        {
            InitializeComponent();
        }

        private void PlacaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.ServicioVehiculos servicio = new Logica.ServicioVehiculos();
            if (e.KeyChar == (char)Keys.Enter)
            {

                var vehiculo = servicio.BuscarId(PlacaTxt.Text);
                if (vehiculo == null)
                {
                    MessageBox.Show("Este Vehiculo no existe");
                }
                else
                {
                    Ver(vehiculo);

                }
            }

            void Ver(Vehiculo vehiculo)
            {
                PlacaTxt.Text = vehiculo.PlacaVehiculo;
                MarcaTxt.Text = vehiculo.Marca;
                KmTxt.Text = vehiculo.Kilometraje.ToString();
            }
        }

        private void btn_Confirmar_Consig_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        void Eliminar()
        {
            string placa;

           Vehiculo vehiculo;
            Logica.ServicioVehiculos servico = new Logica.ServicioVehiculos();

            placa = PlacaTxt.Text;

            vehiculo = servico.BuscarId(placa);
            if (vehiculo == null)
            {
                MessageBox.Show("Este  Vehiculo no existe");
                return;
            }
            else
            {
                servico.Eliminar(placa);
                MessageBox.Show("Eliminacion Exitosa");
                this.Close();
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void EliminarVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
