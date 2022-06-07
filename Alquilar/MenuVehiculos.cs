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
    public partial class MenuVehiculos : Form
    {
        public MenuVehiculos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AddVehiculo frm = new AddVehiculo();

            frm.ShowDialog();
        }

        private void BtnEliminar_Vehi_Click(object sender, EventArgs e)
        {
            EliminarVehiculo frm = new EliminarVehiculo();

            frm.ShowDialog();
        }

        private void Btnconsultar_Vehi_Click(object sender, EventArgs e)
        {
            ConsultarVehiculos frm = new ConsultarVehiculos();

            frm.ShowDialog();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
