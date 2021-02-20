using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using DAL;

namespace BLL
{       
    public class ServicePrestamo
    {
        SqlConnection conexion;
        IList<PrestamoLibros> listaPrestamo;
        DatosPrestamos database;
        DatosLibros libros;
        public ServicePrestamo()
        {
            conexion = new SqlConnection("Data Source=FAMILIAMONTEROD\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True");
            database = new DatosPrestamos(conexion);
            libros = new DatosLibros(conexion);
        }



        Libro Datox = new Libro();  
        public string GuardarPrestamo(PrestamoLibros prestamo)
        {
            try
            {
                conexion.Open();

                if( database.Validar(prestamo.Codigo) == true )
                {
                    if (libros.ActualizarCantidadGuardar(prestamo.Codigo) == true ) 
                    {
                        Datox = libros.BuscarCodigo(prestamo.Codigo);

                        if (Datox.Cantidad == 0)
                        {
                            database.CambiarEstado(prestamo.Codigo);
                            database.GuardarPrestamo(prestamo);
                        }
                        else
                        {
                            database.GuardarPrestamo(prestamo);
                        }
                        
                         conexion.Close();
                        return "Se registro el prestamo";
                    }

                    else 
                    {
                        conexion.Close();
                        return "No hay libros disponibles";
                    }                   
                }
                else
                {
                    conexion.Close();
                    return "Error, no existe el libro";
                }                
            }
            catch(SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    libros.ActualizarCantidadEliminar(prestamo.Codigo);
                    conexion.Close();
                    return "Error, un usuario solo puede tener un libro prestado";
                }
                else
                {
                    conexion.Close();
                     return ex.Message.ToString();
                }
            }
        }

    
        public string GuardarUsuario(Persona prestamo)
        {
            try
            {
                conexion.Open();
                database.GuardarUsuario(prestamo);
                conexion.Close();
                    return "Se registro el prestamo ";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    conexion.Close();
                    return "Error, un usuario solo se puede registrar una ves";
                }
                else
                {
                    conexion.Close();
                    return ex.Message.ToString();
                }
            }
        }

        Libro ValidaCantidad = new Libro();
        public Boolean prueba(PrestamoLibros prestamo)
        {
            ValidaCantidad = libros.BuscarCodigo(prestamo.Codigo);

            if (ValidaCantidad.Cantidad >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        Libro cantidad = new Libro();
        public void ActualizarCantidadGuardar(PrestamoLibros prestamo)
        {
            ValidaCantidad = libros.BuscarCodigo(prestamo.Codigo);

            cantidad.Codigo = ValidaCantidad.Codigo;
            cantidad.Area = ValidaCantidad.Area;
            cantidad.Autor = ValidaCantidad.Autor;
            cantidad.Autor2 = ValidaCantidad.Autor2;
            cantidad.Nombre = ValidaCantidad.Nombre;
            cantidad.Ciudad = ValidaCantidad.Ciudad;
            cantidad.Pais = ValidaCantidad.Pais;
            cantidad.NumeroPaginas = ValidaCantidad.NumeroPaginas;
            cantidad.FechaImpresion = ValidaCantidad.FechaImpresion;
            cantidad.Id = ValidaCantidad.Id;
            cantidad.NombreEditorial = ValidaCantidad.NombreEditorial;
            cantidad.Direccion = ValidaCantidad.Direccion;
            cantidad.Telefono = ValidaCantidad.Telefono;
            cantidad.Cantidad = ValidaCantidad.Cantidad -1;
            cantidad.Estado = ValidaCantidad.Estado;

            libros.Actualizar(cantidad);
        }

        public void ActualizarCantidadEliminar(PrestamoLibros prestamo)
        {
            ValidaCantidad = libros.BuscarCodigo(prestamo.Codigo);

            cantidad.Codigo = ValidaCantidad.Codigo;
            cantidad.Area = ValidaCantidad.Area;
            cantidad.Autor = ValidaCantidad.Autor;
            cantidad.Autor2 = ValidaCantidad.Autor2;
            cantidad.Nombre = ValidaCantidad.Nombre;
            cantidad.Ciudad = ValidaCantidad.Ciudad;
            cantidad.Pais = ValidaCantidad.Pais;
            cantidad.NumeroPaginas = ValidaCantidad.NumeroPaginas;
            cantidad.FechaImpresion = ValidaCantidad.FechaImpresion;
            cantidad.Id = ValidaCantidad.Id;
            cantidad.NombreEditorial = ValidaCantidad.NombreEditorial;
            cantidad.Direccion = ValidaCantidad.Direccion;
            cantidad.Telefono = ValidaCantidad.Telefono;
            cantidad.Cantidad = ValidaCantidad.Cantidad - 1;
            cantidad.Estado = ValidaCantidad.Estado;

            libros.Actualizar(cantidad);
        }

        PrestamoLibros prestamo = new PrestamoLibros();
        Persona datox = new Persona();
        public PrestamoLibros BuscarIdentidad(string dato)
        {            
            conexion.Open();
            prestamo = database.BuscarIdentificacion(dato);
            conexion.Close();

            return prestamo;
        }

        public Persona BuscarUsuario(string dato)
        {
            conexion.Open();
            datox = database.BuscarIdentificacionUsuario(dato);
            conexion.Close();

            return datox;
        }

        public PrestamoLibros BuscarCodigoPrestado(string codigo)
        {
            conexion.Open();
                 prestamo = database.BuscarCodigo(codigo);
            conexion.Close();

            return prestamo;
        }

        IList<Persona> ListaPersona;
        public IList<Persona> ConsultarUsuario()
        {
            conexion.Open();
            ListaPersona = new List<Persona>();

            ListaPersona = database.ConsultarUsuario();

            conexion.Close();

            return ListaPersona;
        }
        public IList<PrestamoLibros> Consultar()
        {
            conexion.Open();

            listaPrestamo = new List<PrestamoLibros>();
            listaPrestamo = database.Consultar();

            conexion.Close();

            return listaPrestamo;
        }


        public string Actualizar(PrestamoLibros prestamo)
        {
            try
            {
                conexion.Open();
                database.Actualizar(prestamo);
                conexion.Close();
                return "Se actualizo el prestamo ";
            }
            catch (Exception ex)
            {
                conexion.Close();
                return "error de base de datos" + ex.Message.ToString();
            }
        }
             
       public string ActualizarUsuario(Persona prestamo)
        {
            try
            {
                conexion.Open();
                database.ActualizarUsuario(prestamo);
                conexion.Close();
                return "Se actualizo el prestamo ";
            }
            catch (Exception ex)
            {
                conexion.Close();
                return ex.Message.ToString();
            }
        }


        string dato = "Se elimino el prestamo ";
        public string Eliminar(PrestamoLibros prestamo)
        {
            try
            {
                conexion.Open();

                if (database.Validar(prestamo.Codigo) == true)
                {
                    libros.ActualizarCantidadEliminar(prestamo.Codigo);
                    database.CambiarEstadoDisponible(prestamo.Codigo);
                    database.Eliminar(prestamo);
                    conexion.Close();
                    return "Se elimino el prestamo ";
                }
                else
                {
                    conexion.Close();
                    return dato.ToString();
                }
                
            }
            catch (Exception ex)
            {
                conexion.Close();
                return "error de base de datos" + ex.Message.ToString();
            }
        }

        public string EliminarUsuario(Persona prestamo)
        {
            try
            {
                conexion.Open();
                database.EliminarUsuario(prestamo);
                conexion.Close();
                return "Se eliminaron los datos del usuario";
            }
            catch (Exception ex)
            {
                conexion.Close();
                return ex.Message.ToString();
            }
        }


    }//no tocar
}
