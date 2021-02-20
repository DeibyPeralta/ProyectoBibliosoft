using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Autor : Persona
    {
        private string Nacionlaidad { get; set; }
        public Autor() {
        }
        public Autor(string nacionalidad, string nombre, string apellido, string identificaion)
        {
            Nacionlaidad = nacionalidad;
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificaion;
        }
    }

}
