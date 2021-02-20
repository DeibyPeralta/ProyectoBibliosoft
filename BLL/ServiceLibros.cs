using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using DAL;

namespace BLL
{
    public class ServiceLibros
    {
        SqlConnection conexion;
        IList<Libro> ListaLibros;
        DatosLibros baseDatos;

        public ServiceLibros()
        {
            conexion = new SqlConnection("Data Source=FAMILIAMONTEROD\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True");
            baseDatos = new DatosLibros(conexion);
        }


        public string GuardarLibros(Libro libro)
        {
            try
            {
                conexion.Open();
                baseDatos.GuardarLibro(libro);
                conexion.Close();
                return "Se registro el prestamo ";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    conexion.Close();
                    return "Error, un libro solo se registra una ves";
                }
                else
                {
                    conexion.Close();
                    return ex.Message.ToString();
                }
            }
        }

        public IList<Libro> Consultar()
        {
            conexion.Open();

            ListaLibros = new List<Libro>();
            ListaLibros = baseDatos.Consultar();

            conexion.Close();

            return ListaLibros;
        }

        Libro lib = new Libro();
        public Libro BuscarCodigo(string codigo)
        {
            conexion.Open();
            lib = baseDatos.BuscarCodigo(codigo);
            conexion.Close();

            return lib;
        }
        


        public string Actualizar(Libro librox)
        {
            try
            {
                conexion.Open();
                baseDatos.Actualizar(librox);
                conexion.Close();
                return "se actualizo";
            }
            catch (Exception ex)
            {
                conexion.Close();
                return ex.Message.ToString();
            }
        }

        public string Eliminar(Libro librox)
        {
            try
            {;
                conexion.Open();
                baseDatos.EliminarLibro(librox);
                conexion.Close();
                return "Se actualizo";
            }
            catch (Exception ex)
            {
                conexion.Close();
                return "error de base de datos" + ex.Message.ToString();
            }
        }



    }//no tocar
}
