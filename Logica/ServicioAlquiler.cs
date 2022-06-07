using System;
using System.Collections.Generic;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioAlquiler
    {
        RepositorioAlquilar repositorio = new RepositorioAlquilar(); // capa de datos
        List<AlquilarVehiculo> ListaVehiculos;
        public ServicioAlquiler()
        {
            ListaVehiculos = repositorio.Consultar();
        }
        void Actualizar()
        {
            ListaVehiculos = repositorio.Consultar();
        }
        public string Guardar(AlquilarVehiculo vehiculoAlquilado)
        {
            //validar
            return repositorio.Guardar(vehiculoAlquilado);

        }
        public List<AlquilarVehiculo> Consultar()
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

        public string Eliminar(string codAlquiler)
        {
            try
            {
                if (repositorio.buscarId(codAlquiler) != null)
                {
                    repositorio.Eliminar(codAlquiler);
                    Console.SetCursorPosition(25, 18); return ($"se han eliminado esta factura: {codAlquiler} ");
                }
                else
                {
                    Console.SetCursorPosition(25, 18); return ($"No se encuentra esta factura {codAlquiler}");
                }
            }
            catch (Exception e)
            {

                Console.SetCursorPosition(34, 18); return $"Error de la Aplicacion: {e.Message}";
            }
        }

    }
}
