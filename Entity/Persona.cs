using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string TipoUsuario { get; set; }
        public string TipoIdentidad { get; set; }

        public Persona() { }

        public Persona(string nombre, string apellido, string identificaion,string tipoUsu, string tipoIdenti)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificaion;
            TipoUsuario = tipoUsu;
            TipoIdentidad = tipoIdenti;
        }
    }
}
