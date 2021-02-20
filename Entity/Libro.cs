using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Libro:Editorial
    {
        public string Codigo { get; set; }
        public string Area { get; set; }
        public string Autor { get; set; }
        public string Autor2 { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string NumeroPaginas { get; set; }
        public string FechaImpresion { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }

        public Libro() { }
        public Libro(string cod, string area, string autor, string autor2, string nombre, string ciudad, string pais, string numeroPaginas, string Fecha, int cantidad,string estado, string id, string nombreEdi, string direccion, string telefono)
        {
            Autor = autor;
            Codigo = cod;
            Area = area;
            Autor2 = autor2;
            Nombre = nombre;
            Ciudad = ciudad;
            Pais = pais;
            NumeroPaginas = numeroPaginas;
            FechaImpresion = Fecha;
            Cantidad = cantidad;
            Estado = estado;
//          Entidades de editorial
            Id = id;
            NombreEditorial = nombreEdi;
            Direccion = direccion;
            Telefono = telefono;
        }

    }
}
