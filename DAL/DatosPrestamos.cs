using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatosPrestamos    {

        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<PrestamoLibros> listaPrestamo = new List<PrestamoLibros>();

        public DatosPrestamos(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void ActualizarUsuario(Persona prestamo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "update NuevoUsuario set TipoUsuario=@TipoUsuario, TipoIdentidad=@TipoIdentidad, Nombre = @Nombre, Apellido = @Apellido where identidad=@identidad";

                comando.Parameters.Add("@TipoUsuario", SqlDbType.VarChar).Value = prestamo.TipoUsuario;
                comando.Parameters.Add("@TipoIdentidad", SqlDbType.VarChar).Value = prestamo.TipoIdentidad;
                comando.Parameters.Add("@identidad", SqlDbType.VarChar).Value = prestamo.Identificacion;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = prestamo.Nombre;
                comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = prestamo.Apellido;

                comando.ExecuteNonQuery();
            }
        }

        public void Actualizar(PrestamoLibros prestamo)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "update LibroPrestado set Nombre = @Nombre, Apellido = @Apellido";


                Comando.Parameters.Add("@identidad", SqlDbType.VarChar).Value = prestamo.Identificacion;
                Comando.Parameters.Add("@FechaPrestamo", SqlDbType.VarChar).Value = prestamo.Fechaprestamo;
                Comando.Parameters.Add("@FechaEntrega", SqlDbType.VarChar).Value = prestamo.Fechaentrega;
                Comando.Parameters.Add("@TipoUsuario", SqlDbType.VarChar).Value = prestamo.TipoUsuario;
                Comando.Parameters.Add("@TipoIdentidad", SqlDbType.VarChar).Value = prestamo.TipoIdentidad;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = prestamo.Nombre;
                Comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = prestamo.Apellido;
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = prestamo.Codigo;

                Comando.ExecuteNonQuery();

            }
        }

    
        public void GuardarPrestamo(PrestamoLibros prestamo)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into LibroPrestado values(@FechaPrestamo, @FechaEntrega, @TipoUsuario, @TipoIdentidad, @identidad, @Nombre, @Apellido, @codigo)";

                Comando.Parameters.AddWithValue("@FechaPrestamo", prestamo.Fechaprestamo);
                Comando.Parameters.AddWithValue("@FechaEntrega", prestamo.Fechaentrega);
                Comando.Parameters.AddWithValue("@TipoUsuario", prestamo.TipoUsuario); ;
                Comando.Parameters.AddWithValue("@TipoIdentidad", prestamo.TipoIdentidad);
                Comando.Parameters.AddWithValue("@identidad", prestamo.Identificacion);
                Comando.Parameters.AddWithValue("@Nombre", prestamo.Nombre);
                Comando.Parameters.AddWithValue("@Apellido", prestamo.Apellido);
                Comando.Parameters.AddWithValue("@codigo", prestamo.Codigo);
                /*              Comando.Parameters.Add("FechaPrestamo", SqlDbType.VarChar).Value = prestamo.Fechaprestamo;
                              Comando.Parameters.Add("FechaEntrega", SqlDbType.VarChar).Value = prestamo.Fechaentrega;
                              Comando.Parameters.Add("TipoUsuario", SqlDbType.VarChar).Value = prestamo.TipoUsuario;
                              Comando.Parameters.Add("TipoIdentidad", SqlDbType.VarChar).Value = prestamo.TipoIdentidad;
                              Comando.Parameters.Add("identidad", SqlDbType.VarChar).Value = prestamo.Identificacion;
                              Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = prestamo.Nombre;
                              Comando.Parameters.Add("Apellido", SqlDbType.VarChar).Value = prestamo.Apellido;
                              Comando.Parameters.Add("Codigo", SqlDbType.VarChar).Value = prestamo.Codigo;
                    */
                Comando.ExecuteNonQuery();
            }
        }

        public void GuardarUsuario(Persona prestamo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "insert into NuevoUsuario values(@TipoUsuario, @TipoIdentidad, @identidad, @Nombre, @Apellido)";

                comando.Parameters.AddWithValue("@TipoUsuario", prestamo.TipoUsuario); ;
                comando.Parameters.AddWithValue("@TipoIdentidad", prestamo.TipoIdentidad);
                comando.Parameters.AddWithValue("@identidad", prestamo.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", prestamo.Nombre);
                comando.Parameters.AddWithValue("@Apellido", prestamo.Apellido);

                comando.ExecuteNonQuery();
            }
        }
     
        public void Eliminar(PrestamoLibros prestamo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "delete from LibroPrestado where identidad ='" + prestamo.Identificacion + "'";

                comando.ExecuteNonQuery();
            }
        }

        public void EliminarUsuario(Persona pres)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "delete from NuevoUsuario where identidad ='" + pres.Identificacion + "'";

                comando.ExecuteNonQuery();
            }
        }



        public  PrestamoLibros BuscarCodigo(string codigo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                PrestamoLibros consultar = new PrestamoLibros();
                comando.CommandText = "select * from LibroPrestado where Codigo ='" + codigo + "' ";

                Reader = comando.ExecuteReader();

                string prueba;
                if (Reader.Read())
                {
                    //     consultar.Fechaprestamo = Reader["FechaPrestamo"].ToString();
                    //     consultar.Fechaentrega = Reader["FechaEntrega"].ToString();
                    prueba = Reader["Codigo"].ToString();                      // codigo

                    consultar.Codigo = Convert.ToString(prueba);
                    consultar.Identificacion = Reader["identidad"].ToString();
                    consultar.Nombre = Reader["Nombre"].ToString();
                    consultar.Apellido = Reader["Apellido"].ToString();
                    consultar.TipoIdentidad = Reader["TipoIdentidad"].ToString();
                    consultar.TipoUsuario = Reader["TipoUsuario"].ToString();

                    return consultar;
                }
                else
                {
                    consultar = null;
                    return consultar;
                }
            }

        }
        


        public Persona BuscarIdentificacionUsuario(string identidad)
        {
            using (var comando = Conexion.CreateCommand())
            {
                Persona ConsulLibro = new Persona();
                comando.CommandText = "select * from NuevoUsuario Where identidad ='" + identidad + "' ";

                Reader = comando.ExecuteReader();
              
                if (Reader.Read() == true)
                {
                    ConsulLibro.Identificacion = Reader["identidad"].ToString();
                    ConsulLibro.TipoUsuario = Reader["TipoUsuario"].ToString();
                    ConsulLibro.TipoIdentidad = Reader["TipoIdentidad"].ToString();
                    ConsulLibro.Nombre = Reader["Nombre"].ToString();
                    ConsulLibro.Apellido = Reader["Apellido"].ToString();

                    return ConsulLibro;
                }
                else
                {
                    ConsulLibro = null;
                    return ConsulLibro;
                }
            }
        }





        public PrestamoLibros BuscarIdentificacion(string identidad)
        {
            using (var comando = Conexion.CreateCommand())
            {                
                PrestamoLibros ConsulLibro = new PrestamoLibros();
                comando.CommandText = "select * from LibroPrestado Where identidad ='" + identidad+"' ";

                Reader = comando.ExecuteReader();
                string prueba;
                if (Reader.Read()==true)
                {
                    ConsulLibro.Identificacion = Reader["identidad"].ToString();
                    ConsulLibro.Fechaprestamo = Reader["FechaPrestamo"].ToString();
                    ConsulLibro.Fechaentrega = Reader["FechaEntrega"].ToString();
                    ConsulLibro.TipoUsuario = Reader["TipoUsuario"].ToString();
                    ConsulLibro.TipoIdentidad = Reader["TipoIdentidad"].ToString();
                    ConsulLibro.Nombre = Reader["Nombre"].ToString();
                    ConsulLibro.Apellido = Reader["Apellido"].ToString();
                     prueba = Reader["Codigo"].ToString();                      // codigo
                    ConsulLibro.Codigo = Convert.ToString(prueba);
                   // ConsulLibro.Estado = (string)Reader["Estado"].ToString();

                        return ConsulLibro;
                }
                else
                {
                    ConsulLibro = null;
                    return ConsulLibro;
                }                
            }
        }

       
        public void CambiarEstado(string codigo)
        {
            
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "update LibroNuevo set Estado = @Estado where Codigo = @Codigo";

                comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "Prestado";
  //              comando.Parameters.Add("@Cantidad",SqlDbType.Int).Value = prestamo.ca

                comando.ExecuteNonQuery();
            }

        }

        Libro Consulta = new Libro();
        public void CambiarEstadoDisponible(string codigo)
        {

            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "update LibroNuevo set Estado = @Estado where Codigo = @Codigo";

                comando.Parameters.AddWithValue("@Codigo", codigo);
                comando.Parameters.AddWithValue("@Estado", "Disponible");

                comando.ExecuteNonQuery();
            }

        }
        
        public Boolean Validar(string codigo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "select * from LibroNuevo where Codigo = @Codigo";
                comando.Parameters.AddWithValue("@Codigo", codigo);
                Reader = comando.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.Read();
                    Reader.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IList<Persona> personita = new List<Persona>();

        public IList<Persona> ConsultarUsuario()
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "select * from NuevoUsuario";

                Reader = comando.ExecuteReader();

                while (Reader.Read())
                {
                    Persona usuario = new Persona();
                    usuario = MapUsu(Reader);

                    personita.Add(usuario);
                }
            }
            return personita;
        }

        public Persona MapUsu(SqlDataReader reader)
        {
            Persona libros = new Persona();

            libros.Identificacion = (string)reader["identidad"];
            libros.TipoUsuario = (string)reader["TipoUsuario"];
            libros.TipoIdentidad = (string)reader["TipoIdentidad"];
            libros.Nombre = (string)reader["Nombre"];
            libros.Apellido = (string)reader["Apellido"];

            return libros;
        }


        public IList<PrestamoLibros> Consultar()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from LibroPrestado";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    PrestamoLibros prestamo = new PrestamoLibros();
                    prestamo = Map(Reader);
                    listaPrestamo.Add(prestamo);
                }
            }
            return listaPrestamo;
        }  

        public PrestamoLibros Map(SqlDataReader reader)
        {
            PrestamoLibros libros = new PrestamoLibros();

            libros.Identificacion = (string)reader["identidad"];
            libros.Fechaprestamo = (string)reader["FechaPrestamo"];
            libros.Fechaentrega = (string)reader["FechaEntrega"];
            libros.TipoUsuario = (string)reader["TipoUsuario"];
            libros.TipoIdentidad = (string)reader["TipoIdentidad"];
            libros.Nombre = (string)reader["Nombre"];
            libros.Apellido = (string)reader["Apellido"];
            libros.Codigo = (string)reader["Codigo"];
            libros.Estado = "Prestado";

            return libros;
        }



      
       







    }
}
