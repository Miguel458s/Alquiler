using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Presentacion
{
    public class PresentacionVehiculo
    {
        public void MenuVehiculo()
        {
            int opcion;
            do
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.WriteLine("******************************* ALQUILER - MENU VEHICULO ********************************");
                Console.WriteLine("*                                                                                       *");
                Console.WriteLine("*        1. Agregar Cliente                                                             *");
                Console.WriteLine("*        2. Consultar Cliente                                                           *");
                Console.WriteLine("*        4. Eliminar                                                                    *");
                Console.WriteLine("*        5. volver ...                                                                  *");
                Console.WriteLine("*                                                                                       *");
                Console.WriteLine("*****************************************************************************************");
                Console.Write("Digite una opcion:  ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: // agregar
                        MenuAgregar();
                        break;
                    case 2:
                        MenuConsultar();
                        break;
                    case 3:
                        MenuEliminar();
                        break;
                    case 5:

                        break;
                }
            } while (opcion != 5);
        }
        void MenuAgregar()
        {
            Vehiculo vehiculo = new Vehiculo();
            Logica.ServicioVehiculos servico = new Logica.ServicioVehiculos();
            Console.Clear();
            Console.Write("Placa: "); vehiculo.PlacaVehiculo = Console.ReadLine();
            Console.Write("Marca: "); vehiculo.Marca = Console.ReadLine();
            Console.Write("Kilometraje: "); vehiculo.Kilometraje = double.Parse(Console.ReadLine());
            Console.WriteLine(servico.Guardar(vehiculo));
            Console.ReadKey();
        }
        void MenuConsultar()
        {
            Vehiculo vehiculo = new Vehiculo();
            Logica.ServicioVehiculos servico = new Logica.ServicioVehiculos();

            Console.Clear();
            Console.WriteLine("Placa   -   Marca -   Kilometraje  ");
            foreach (var item in servico.Consultar())
            {
                Console.WriteLine(item.PlacaVehiculo + " --> " + item.Marca + " --> " + item.Kilometraje);
            }

            Console.ReadKey();
        }

        //void MenuModificar()
        //{
        //    string Id;
        //    string newNombre;
        //    Vehiculo cliente;
        //    Logica.ServicioVehiculos servico = new Logica.ServicioVehiculos();
        //    Console.Clear();
        //    Console.Write("Ingresar Cedula : "); Id = Console.ReadLine();

        //    cliente = servico.BuscarId( Id);
        //    if (cliente == null)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("cliente no existe");
        //        Console.ReadKey();
        //        return;
        //    }
        //    else { 
            
        //        Console.WriteLine(cliente.IdCliente + "-->" + cliente.Nombre);
           
        //        Console.Write("Ingresar Nuevo nombre : "); newNombre = Console.ReadLine();
            
        //        cliente.Nombre = newNombre;
                
        //        servico.Modificar();
        //    }
        //    // validar <=0
            
        //}

        void MenuEliminar()
        {
              Logica.ServicioVehiculos servico = new Logica.ServicioVehiculos();

                Console.Clear();
                string placa;
                Console.SetCursorPosition(34, 3); Console.WriteLine("E L I M I N A R   C L I E N T E");
                Console.WriteLine("");
                Console.SetCursorPosition(34, 5); Console.Write("Digite la placa ");
                Console.SetCursorPosition(34 + 18, 5); placa = Console.ReadLine();
                Console.WriteLine("");
                Console.SetCursorPosition(34, 6); Console.WriteLine(servico.Eliminar(placa));
                Console.WriteLine("");
                Console.SetCursorPosition(34, 20); Console.Write("Digite una tecla para regresar al menu...");
                Console.ReadKey();
            

            // validar <=0

        }

    }
}
