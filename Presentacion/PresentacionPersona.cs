using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Logica;

namespace Presentacion
{
    public class PresentacionPersona
    {
        public void MenuPersonas()
        {
            int opcion;
            do
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("******************************* ALQUILER - MENU PERSONAS********************************");
                Console.WriteLine("*                                                                                      *");
                Console.WriteLine("*        1. Agregar Persona                                                            *");
                Console.WriteLine("*        2. Consultar                                                                  *");
                Console.WriteLine("*        3. Modificar                                                                  *");
                Console.WriteLine("*        4. Eliminar                                                                   *");
                Console.WriteLine("*        5. volver ...                                                                 *");
                Console.WriteLine("*                                                                                      *");
                Console.WriteLine("****************************************************************************************");
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
                        //MenuConsignar();
                        break;
                    case 4:
                        //MenuRetirar();
                        break;
                    case 5:

                        break;
                }
            } while (opcion != 5);
        }
        void MenuAgregar()
        {
            Persona persona = new Persona();
            Logica.ServicioPersonas servico = new Logica.ServicioPersonas();
            Console.Clear();
            Console.Write("Cedula: "); persona.Id = Console.ReadLine();
            Console.Write("Nombre: "); persona.Nombre = Console.ReadLine();
            Console.Write("Tipo persona: "); persona.TipoCliente = Console.ReadLine();
            Console.WriteLine(servico.Guardar(persona));
            Console.ReadKey();
        }
        void MenuConsultar()
        {
            Persona persona = new Persona();
            Logica.ServicioPersonas servico = new Logica.ServicioPersonas();
            
            Console.Clear();
            Console.WriteLine("id - nombre cliente - tipo cliente  ");
            foreach (var item in servico.Consultar())
            {
                Console.WriteLine(item.Id + " --> " + item.Nombre + " --> " + item.TipoCliente);
            }

            Console.ReadKey();
        }
        

    }
}
