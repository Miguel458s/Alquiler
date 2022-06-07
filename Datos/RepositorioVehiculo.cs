using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
namespace Datos
{
    public class RepositorioVehiculo
    {
        string ruta = "Vehiculos.txt";// ruta donde se guarda el archivo
        public string Guardar(Entidades.Vehiculo vehiculo)
        {
            try
            {
                //FileStream archivo = new FileStream(ruta, FileMode.Append);
                //1. instanciar - abre en modo append -  adiciona datos
                StreamWriter escritor = new StreamWriter(ruta, true);

                // 2. operaciones
                escritor.WriteLine(vehiculo.ToString());
                
                //3.  guardar
                escritor.Close();
                                
                return "Se guardaron los datos";
            }
            catch (Exception)
            {
                return "NO Se guardaron los datos";
            }

        }
        public string Modificar(List<Entidades.Vehiculo> vehiculos)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in vehiculos)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                return "Se modificaron los datos los datos";

                //File.Delete(ruta);  // elimina
                //File.Move("tmp", ruta);// renombrar
            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }
        public string Modificar2(List<Entidades.Vehiculo> vehiculos)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("tmp.txt", true);// sobreescribe
                foreach (var item in vehiculos)
                {
                    escritor.WriteLine(item.ToString());
                   
                    
                    //close
                }

                escritor.Close();

                File.Delete(ruta);  // elimina
                File.Move("tmp.txt", ruta);// renombrar

                return "Se modificaron los datos los datos";
                               
            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }
        public void Eliminar(String placa)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos = Consultar();
            FileStream archivo = new FileStream(ruta, FileMode.Create);
            archivo.Close();
            foreach (var item in vehiculos)
            {
                if (!Encontrado(item.PlacaVehiculo, placa))
                {
                    Guardar(item);
                }
            }
        }

        private bool Encontrado(string placaVehiculoReg, string placaVehiculoBus)
        {
            return placaVehiculoReg == placaVehiculoBus;
        }

        public List<Entidades.Vehiculo> Consultar()
        {
            try
            {
               
                StreamReader lector = new StreamReader(ruta);
                List<Entidades.Vehiculo> vehiculos = new List<Entidades.Vehiculo>();   
                // 2. operaciones
                string linea= string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    Entidades.Vehiculo vehiculo = new Entidades.Vehiculo();
                    vehiculo.PlacaVehiculo = linea.Split(';')[0];
                    vehiculo.Marca = linea.Split(';')[1];
                    vehiculo.Kilometraje = double.Parse(linea.Split(';')[2]);
                    vehiculos.Add(vehiculo);

                    //clientes.Add(new Entidades.Cliente(linea.Split(';')[0], linea.Split(';')[1]));
                }

                //3.  guardar
                lector.Close();

                return vehiculos;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Entidades.Vehiculo buscarId(string placa)
        {
            foreach (var item in Consultar())
            {
                if (item.PlacaVehiculo == placa)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
