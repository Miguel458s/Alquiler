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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_Alquilar_Click(object sender, EventArgs e)
        {
            Alquilar frm = new Alquilar();

            frm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MenuVehiculos frm = new MenuVehiculos();

            frm.ShowDialog();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            MenuPersonas frm = new MenuPersonas();

            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
