using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Alquilar
{
    public partial class ConsultarVehiculosAlquilados : Form
    {
        public ConsultarVehiculosAlquilados()
        {
            InitializeComponent();
    
        }

        private void btn_CargarTabla_Click(object sender, EventArgs e)
        {
            
                System.IO.StreamReader file = new System.IO.StreamReader("AutosAlquilados.txt");
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
            dataGridConsultar.DataSource = dt;
            
        }
    }


}
