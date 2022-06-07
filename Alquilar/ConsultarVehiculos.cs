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
    public partial class ConsultarVehiculos : Form
    {
        public ConsultarVehiculos()
        {
            InitializeComponent();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {

            System.IO.StreamReader file = new System.IO.StreamReader("Vehiculos.txt");
            string[] columnnames = file.ReadLine().Split(';');
            DataTable dt = new DataTable();
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(';');
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            file.Close();

            dataGridMostrar.DataSource = dt;
        }
    }
}
