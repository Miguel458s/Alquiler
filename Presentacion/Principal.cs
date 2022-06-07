using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Principal
    {
        public void MenuPrincipal()
        {
            int opcion;
            do
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("**************************** BANCO - MENU PRINCIPAL********************");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*        1. VEHICULOS                                                  *");
                Console.WriteLine("*        2. PERSONAS                                                   *");
                Console.WriteLine("*        3. SALIR                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.Write("Digite una opcion:  ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        new PresentacionVehiculo().MenuVehiculo();
                        break;
                    case 2:
                        new PresentacionPersona().MenuPersonas();
                        break;
                        //case 3:
                        //    Environment.Exit(5);
                        //    break;
                }
            } while (opcion != 3);

        }
    }
}
