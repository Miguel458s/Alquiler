using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public Persona(string id, string nombre, string tipoCliente)
        {
            Id = id;
            Nombre = nombre;
            TipoCliente = tipoCliente;
        }
        public Persona()
        {

        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string TipoCliente { get; set; }

       

        public override string ToString() //linea
        {
            return Id.ToString() + ";" + Nombre.ToString() + ";"+ TipoCliente.ToString(); 
        }
    }
}
