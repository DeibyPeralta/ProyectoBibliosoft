using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PrestamoLibros:Usuario
    {
       // Libro libros = new Libro();
        
        public string Fechaprestamo { get; set; }
        public string Fechaentrega { get; set; }
        public string TipoUsuario { get; set; }
        public string TipoIdentidad { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
        public PrestamoLibros()
        {

        }
        public PrestamoLibros(string identificacion, string fechaprestamo, string fechaentrega, string tipoUsu, string tipoIdenti, string nombre, string apellido,string estado, string codigo)
        {
            Identificacion = identificacion;
            Fechaprestamo = Fechaprestamo;
            Fechaentrega = Fechaentrega;
            TipoUsuario = tipoUsu;
            TipoIdentidad = tipoIdenti;
            Nombre = nombre;
            Apellido = apellido;            
            Estado = estado;
            Codigo = codigo;
        }

    }
}
