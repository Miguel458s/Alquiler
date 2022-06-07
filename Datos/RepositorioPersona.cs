using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Entidades;
namespace Datos
{
    public class RepositorioPersona
    {
        string ruta = "Personas.txt";// ruta donde se guarda el archivo
        public string Guardar(Entidades.Persona cuenta)
        {
            try
            {
                //FileStream archivo = new FileStream(ruta, FileMode.Append);
                //1. instanciar - abre en modo append -  adiciona datos
                StreamWriter escritor = new StreamWriter(ruta, true);

                // 2. operaciones
                escritor.WriteLine(cuenta.ToString());

                //3.  guardar
                escritor.Close();

                return "Se guardaron los datos";
            }
            catch (Exception)
            {
                return "NO Se guardaron los datos";
            }

        }
        public string Modificar(List<Entidades.Persona> personas)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in personas)
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
        public string Modificar2(List<Entidades.Persona> personas)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("tmp.txt", true);// sobreescribe
                foreach (var item in personas)
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

        public void Eliminar(String identificacion)
        {
            List<Persona> personas = new List<Persona>();
            personas = Consultar();
            FileStream archivo = new FileStream(ruta, FileMode.Create);
            archivo.Close();
            foreach (var item in personas)
            {
                if (!Encontrado(item.Id, identificacion))
                {
                    Guardar(item);
                }
            }
        }

        private bool Encontrado(string identificacionReg, string identificacionBus)
        {
            return identificacionReg == identificacionBus;
        }

        public Persona buscarId(string id)
        {
            foreach (var item in Consultar())
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }


        public List<Entidades.Persona> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Entidades.Persona> personas = new List<Entidades.Persona>();
                // 2. operaciones
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();

                    string id =  linea.Split(';')[0];
                    string nombre = linea.Split(';')[1];
                    string tipoCliente = linea.Split(';')[2];
                    

                 Entidades.Persona persona = new Entidades.Persona(id,nombre,tipoCliente);
                 personas.Add(persona);

                    //clientes.Add(new Entidades.Cliente(linea.Split(';')[0], linea.Split(';')[1]));
                }

                //3.  guardar
                lector.Close();

                return personas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
