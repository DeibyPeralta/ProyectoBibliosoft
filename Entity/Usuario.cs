using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string apellido, string identificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
        }
    }
}
