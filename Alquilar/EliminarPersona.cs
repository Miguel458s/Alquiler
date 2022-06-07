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
    public partial class EliminarPersona : Form
    {
        public EliminarPersona()
        {
            InitializeComponent();
        }

        private void IdPersonaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.ServicioPersonas servicio = new Logica.ServicioPersonas();
            if (e.KeyChar == (char)Keys.Enter)
            {

                var persona = servicio.BuscarId(IdPersonaTxt.Text);
                if (persona == null)
                {
                    MessageBox.Show("Esta Persona no existe");
                }
                else
                {
                    Ver(persona);

                }
            }

            void Ver(Persona persona)
            {
                IdPersonaTxt.Text = persona.Id;
                NombreTxt.Text = persona.Nombre;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        void Eliminar()
        {
            string id;

            Persona persona;
            Logica.ServicioPersonas servico = new Logica.ServicioPersonas();

            id = IdPersonaTxt.Text; 

            persona = servico.BuscarId(id);
            if (persona == null)
            {
                MessageBox.Show("Esta Persona no existe");
                return;
            }
            else
            {
                servico.Eliminar(id);
                MessageBox.Show("Eliminacion Exitosa");
                this.Close();
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
