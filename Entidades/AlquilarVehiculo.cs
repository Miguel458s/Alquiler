using System;
using System.Collections.Generic;
using System.Text;


namespace Entidades
{
    public class AlquilarVehiculo : Vehiculo
    {
        
        public AlquilarVehiculo(string codAlquiler, string placa, double kilometraje, string cliente, double valorkm, DateTime fecha, double toatalPagar)
        {
            CodAlquiler = codAlquiler;
            PlacaVehiculo = placa;
            Kilometraje = kilometraje;
            Persona = cliente;
            ValorKM = valorkm;
            Fecha = fecha;
            TotalPagar = toatalPagar;

        }
        public AlquilarVehiculo(){}
        public string CodAlquiler { get; set; }
        
        public string Persona { get; set; }

        public double ValorKM { get; set; }

        public DateTime Fecha { get; set; }

        public double TotalPagar { get; set; }



        public override string ToString() //linea
        {
            return PlacaVehiculo.ToString() + ";" + Kilometraje.ToString() + ";" + Persona.ToString() + ";" + ValorKM.ToString() + ";" + Fecha.ToString() + ";" + TotalPagar.ToString();
        }
    }




}

