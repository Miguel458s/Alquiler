using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
namespace Logica
{
    public class ServicioPersonas
    {
        Datos.RepositorioPersona repositorio = new Datos.RepositorioPersona();
        List<Persona> ListaPersonas;
        public ServicioPersonas()
        {
            ListaPersonas = repositorio.Consultar();
        }
        void Actualizar()
        {
            ListaPersonas = repositorio.Consultar();
        }
        public string Guardar(Persona cuenta)
        {
            //validar
            return repositorio.Guardar(cuenta);

        }
        public List<Persona> Consultar()
        {
            Actualizar();
            return ListaPersonas;
        }

        public Persona BuscarId(string id)
        {
            foreach (var item in ListaPersonas)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public void GuardarCambios()
        {
            repositorio.Modificar(ListaPersonas);
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                if (repositorio.buscarId(identificacion) != null)
                {
                    repositorio.Eliminar(identificacion);
                    return ($"se han eliminado el vehiculo con placa: {identificacion} ");
                }
                else
                {
                    return ($"No se encuentra registrado el vehiculo con placa {identificacion}");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }
        }
    }
}
