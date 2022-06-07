using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquilar
{
    public partial class MenuPersonas : Form
    {
        public MenuPersonas()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           AddPersona frm = new AddPersona();

            frm.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarPersona frm = new EliminarPersona();

            frm.ShowDialog();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
           ConsultarPersonas frm = new ConsultarPersonas();

            frm.ShowDialog();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPersonas_Load(object sender, EventArgs e)
        {

         
        }

        
    }
}
