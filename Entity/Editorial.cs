using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Editorial
    {
        public string Id { get; set; }
        public string NombreEditorial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Editorial() { }

        public Editorial(string id, string nombre, string direccion, string telefono)
        {
            Id = id;
            NombreEditorial = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
