using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
namespace Datos
{
    public class RepositorioAlquilar
    {
        string ruta = "AutosAlquilados.txt";// ruta donde se guarda el archivo
        public string Guardar(Entidades.AlquilarVehiculo vehiculo)
        {
            try
            {
                //FileStream archivo = new FileStream(ruta, FileMode.Append);
                //1. instanciar - abre en modo append -  adiciona datos
                using (StreamWriter escritor = new StreamWriter(ruta, true))
                {
                    // 2. operaciones
                    escritor.WriteLine(vehiculo.ToString());

                    //3.  guardar
                    escritor.Flush();
                    escritor.Close();
                }

                return "Se guardaron los datos";
            }
            catch (Exception e)
            {
                return "NO Se guardaron los datos YA EXISTE";
            }
            finally
            {
                Console.WriteLine("Finalizado");
            }


        }
          
        
        public string Modificar(List<Entidades.AlquilarVehiculo> vehiculos)
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
        public string Modificar2(List<Entidades.AlquilarVehiculo> vehiculos)
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
            List<AlquilarVehiculo> vehiculos = new List<AlquilarVehiculo>();
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

        private bool Encontrado(string codVehiculoAlquiladoReg, string codVehiculoAlquiladoBus)
        {
            return codVehiculoAlquiladoReg == codVehiculoAlquiladoBus;
        }

        public List<AlquilarVehiculo> Consultar()
        {
            try
            {
               
                StreamReader lector = new StreamReader(ruta);
                List<Entidades.AlquilarVehiculo> vehiculos = new List<Entidades.AlquilarVehiculo>();   
                // 2. operaciones
                string linea= string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    Entidades.AlquilarVehiculo vehiculo = new Entidades.AlquilarVehiculo();
                    vehiculo.CodAlquiler = linea.Split(';')[0];
                    vehiculo.PlacaVehiculo = linea.Split(';')[1];
                    vehiculo.Kilometraje = double.Parse(linea.Split(';')[2]);
                    vehiculo.ValorKM = double.Parse(linea.Split(';')[3]);
                    Entidades.Persona cliente = new RepositorioPersona().buscarId(linea.Split(';')[4]);
                    vehiculo.Fecha = DateTime.Parse(linea.Split(';')[5]);   
                    vehiculo.TotalPagar = double.Parse(linea.Split(';')[6]);
                    
                    
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
        public Entidades.AlquilarVehiculo buscarId(string codAlquiler)
        {
            foreach (var item in Consultar())
            {
                if (item.CodAlquiler == codAlquiler)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
