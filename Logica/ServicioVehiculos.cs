using System;
using System.Collections.Generic;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioVehiculos
    {
        RepositorioVehiculo repositorio = new RepositorioVehiculo(); // capa de datos
        List<Vehiculo> ListaVehiculos;
        public ServicioVehiculos()
        {
            ListaVehiculos = repositorio.Consultar();
        }
        void Actualizar()
        {
            ListaVehiculos = repositorio.Consultar();
        }
        public string Guardar(Vehiculo cliente)
        {
            //validar
            return repositorio.Guardar(cliente);

        }
        public List<Vehiculo> Consultar()
        {
            Actualizar();
            return ListaVehiculos;
        }
        public Vehiculo BuscarId(string placa)
        {
            foreach (var item in ListaVehiculos)
            {
                if (item.PlacaVehiculo==placa)
                {
                    return item;
                }
            }
            return null;
        }
        public void Modificar()
        {
            repositorio.Modificar(ListaVehiculos);
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
