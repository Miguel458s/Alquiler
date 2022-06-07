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
    public partial class AddPersona : Form
    {
        public AddPersona()
        {
            InitializeComponent();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void Nuevo()
        {
            IdPersonaTxt.Clear();
            NombreTxt.Clear();
            IdPersonaTxt.Focus();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        void Guardar()
        {
            Persona persona = new Persona();
            persona.Id = IdPersonaTxt.Text;
            persona.Nombre = NombreTxt.Text;
            persona.TipoCliente = ComboTipop.Text;
            String Mensaje;
            ServicioPersonas SC = new ServicioPersonas();
            Mensaje = SC.Guardar(persona);
            MessageBox.Show(Mensaje);

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
