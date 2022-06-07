using System;

namespace Entidades
{
    public class Vehiculo
    {
        public string PlacaVehiculo { get; set; }
        public string Marca { get; set; }

        public double Kilometraje { get; set; }

        public Vehiculo(string placaVehiculo, string marca, double kilometraje)
        {
            PlacaVehiculo = placaVehiculo;
            Marca = marca;  
            Kilometraje = kilometraje;  
        }
        public Vehiculo()
        {

        }
        public override string ToString()
        {
            return PlacaVehiculo + ";" + Marca + ";" + Kilometraje;
        }
    }
}