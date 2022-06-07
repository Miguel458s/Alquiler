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
using Datos;
using Logica;

namespace Alquilar
{
    public partial class Alquilar : Form
    {
        AlquilarVehiculo calculos = new AlquilarVehiculo();
        Persona persona = new Persona();    
        public Alquilar()
        {
            InitializeComponent();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            ServicioVehiculos servicio = new ServicioVehiculos();
            if (e.KeyChar == (char)Keys.Enter)
            {

                var Vehiculo = servicio.BuscarId(txtPlaca.Text);
                Ver(Vehiculo);

            }
          
            
        }
        void Ver(Vehiculo vehiculo)
        {

            txtPlaca.Text = vehiculo.PlacaVehiculo;
            txtMarca.Text = vehiculo.Marca;
            txtKilometraje.Text = vehiculo.Kilometraje.ToString();
            

        }

        private void txtCedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ServicioPersonas servicio = new ServicioPersonas();
            if (e.KeyChar == (char)Keys.Enter)
            {

                var Persona = servicio.BuscarId(txtCedula.Text);
                VerCliente(Persona);

            }

        }
        void VerCliente(Persona persona)
        {
                txtNombre.Text = persona.Nombre;
                txtTipoPersona.Text = persona.TipoCliente;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            ServicioVehiculos servicioV = new ServicioVehiculos();
            ServicioPersonas servicioP = new ServicioPersonas();    
            if (txtCedula.Text == "" || txtMarca.Text == "" || txtKilometraje.Text == "" || txtCedula.Text == "" || txtNombre.Text == "" || txtTipoPersona.Text == "" || txtValorKM.Text == "" || dateFecha.Text == "")
            {
                MessageBox.Show("Error, Campos Vacios");
            }
            else
            {
              

                DataTable tabla = new DataTable();

                DataColumn column;
                DataRow row;


                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Placa";
                tabla.Columns.Add(column);
                column = new DataColumn();

                column.DataType = Type.GetType("System.Double");
                column.ColumnName = "KM";
                tabla.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.Double");
                column.ColumnName = "ValorKM";
                tabla.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Persona";
                tabla.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.DateTime");
                column.ColumnName = "Fecha";
                tabla.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.Double");
                column.ColumnName = "Total";
                tabla.Columns.Add(column);


                row = tabla.NewRow();
                row["Placa"] = txtPlaca.Text;
                row["KM"] = txtKilometraje.Text;
                row["ValorKM"] = txtValorKM.Text;
                row["Persona"] = txtNombre.Text;
                row["Fecha"] = dateFecha.Text;
                row["Total"] = calculoAlquiler();
                tabla.Rows.Add(row);

               

                dataGridViewResult.DataSource = tabla;
              
            }

        }

        public double calculoAlquiler()
        {
            ServicioPersonas servicio = new ServicioPersonas();
            string TipoPersona = txtTipoPersona.Text;
            double precio = 0;
            double valorKilometro = double.Parse(txtValorKM.Text);
            double kilometro = double.Parse(txtKilometraje.Text);
            double precioFinal;
            double descuento;

            if (TipoPersona == "Ocasional")
            {
                precio = precio + kilometro * valorKilometro;
            }
            else
            {
                descuento = (kilometro * valorKilometro) * 0.15;
                precio = (kilometro * valorKilometro) - descuento;
            }


            return precioFinal = precio;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Guardar();
        }

        void Guardar()
        {
            AlquilarVehiculo alquilar = new AlquilarVehiculo();

            alquilar.PlacaVehiculo = txtPlaca.Text;
            alquilar.Kilometraje = double.Parse(txtKilometraje.Text);
            alquilar.ValorKM = double.Parse(txtValorKM.Text);
            alquilar.Persona = txtNombre.Text;
            alquilar.Fecha = DateTime.Parse(dateFecha.Text);
            alquilar.TotalPagar = calculoAlquiler();


            String Mensaje;
            ServicioAlquiler SC = new ServicioAlquiler();
            Mensaje = SC.Guardar(alquilar);
            MessageBox.Show(Mensaje);

        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            ConsultarVehiculosAlquilados frm = new ConsultarVehiculosAlquilados();

            frm.ShowDialog();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
