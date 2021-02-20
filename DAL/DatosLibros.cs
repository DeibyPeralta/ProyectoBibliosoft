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
    public class DatosLibros
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Libro> ListaLibros = new List<Libro>();

        public DatosLibros(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void GuardarLibro(Libro librox)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "insert into LibroNuevo values (@Codigo, @Area, @Autor, @Autor2, @Nombre, @Ciudad, @Pais, @NumPaginas, @FechaImpresion, @Id, @NombreEditorial, @Direccion, @Telefono, @Estado, @Cantidad)";
                
                          comando.Parameters.AddWithValue("@Codigo", librox.Codigo);
                          comando.Parameters.AddWithValue("@Area", librox.Area);
                          comando.Parameters.AddWithValue("@Autor", librox.Autor);
                          comando.Parameters.AddWithValue("@Autor2", librox.Autor2);
                          comando.Parameters.AddWithValue("@Nombre", librox.Nombre);
                          comando.Parameters.AddWithValue("@Ciudad", librox.Ciudad);
                          comando.Parameters.AddWithValue("@Pais", librox.Pais);
                          comando.Parameters.AddWithValue("@NumPaginas", librox.NumeroPaginas);
                          comando.Parameters.AddWithValue("@FechaImpresion", librox.FechaImpresion);
                          comando.Parameters.AddWithValue("@Id", librox.Id);
                          comando.Parameters.AddWithValue("@NombreEditorial", librox.NombreEditorial);
                          comando.Parameters.AddWithValue("@Direccion", librox.Direccion);
                          comando.Parameters.AddWithValue("@Telefono", librox.Telefono);
                          comando.Parameters.AddWithValue("@Estado", librox.Estado);
                          comando.Parameters.AddWithValue("@Cantidad", librox.Cantidad);

                comando.ExecuteNonQuery();
            }
        }

        public void CambiarEstado(string codigo)
        {

            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "update LibroNuevo set Estado = @Estado where Codigo = @Codigo, Candidad=@Cantidad";

                comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "Prestado";

                comando.ExecuteNonQuery();
            }

        }

        public Boolean ActualizarCantidadGuardar(string codigo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                Libro libros = new Libro();                

                libros = BuscarCodigo(codigo);
                int prueba = libros.Cantidad;

                if (prueba == 0)
                {
                    return false;
                }
                else
                {
                    int datos = prueba - 1;
                    comando.CommandText = "update LibroNuevo set Cantidad=@Cantidad where Codigo='" + codigo + "'";

                    comando.Parameters.AddWithValue("@Cantidad", datos);

                    comando.ExecuteNonQuery();

                    return true;
                }
            }
        }

        public void ActualizarCantidadEliminar(string codigo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                Libro libros = new Libro();
                comando.CommandText = "update LibroNuevo set Cantidad=@Cantidad where Codigo='" + codigo + "'";

                libros = BuscarCodigo(codigo);

                int datos = libros.Cantidad + 1;
                comando.Parameters.AddWithValue("@Cantidad", datos);

                comando.ExecuteNonQuery();
            }
        }
        public void Actualizar(Libro librox)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText = "update LibroNuevo set Nombre = @Nombre, Area=@Area, Autor = @Autor, Autor2=@Autor2, NumPaginas = @NumPaginas where Codigo='"+librox.Codigo+"'";

                comando.Parameters.AddWithValue("@Codigo", librox.Codigo);
                comando.Parameters.AddWithValue("@Area", librox.Area);
                comando.Parameters.AddWithValue("@Autor", librox.Autor);
                comando.Parameters.AddWithValue("@Autor2", librox.Autor2);
                comando.Parameters.AddWithValue("@Nombre", librox.Nombre);
                comando.Parameters.AddWithValue("@Ciudad", librox.Ciudad);
                comando.Parameters.AddWithValue("@Pais", librox.Pais);
                comando.Parameters.AddWithValue("@NumPaginas", librox.NumeroPaginas);
                comando.Parameters.AddWithValue("@FechaImpresion", librox.FechaImpresion);
                comando.Parameters.AddWithValue("@Id", librox.Id);
                comando.Parameters.AddWithValue("@NombreEditorial", librox.NombreEditorial);
                comando.Parameters.AddWithValue("@Direccion", librox.Direccion);
                comando.Parameters.AddWithValue("@Telefono", librox.Telefono);

                comando.Parameters.AddWithValue("@Cantidad", librox.Cantidad);
                

                comando.ExecuteNonQuery();
            }
        }

        public IList<Libro> Consultar()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * From LibroNuevo";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    Libro librito = new Libro();
                    librito = Map(Reader);
                    ListaLibros.Add(librito);
                }
            }
            return ListaLibros;
        }
        
        public Libro Map(SqlDataReader reader)
        {
            Libro RetornarLibro = new Libro();

            RetornarLibro.Codigo = (string)reader["Codigo"];
            RetornarLibro.Area = (string)reader["Area"];
            RetornarLibro.Autor = (string)reader["Autor"];
            RetornarLibro.Autor2 = (string)reader["Autor2"];
            RetornarLibro.Nombre = (string)reader["Nombre"];
            RetornarLibro.Ciudad = (string)reader["Ciudad"];
            RetornarLibro.Pais = (string)reader["Pais"];
            RetornarLibro.NumeroPaginas = (string)reader["NumPaginas"];
            RetornarLibro.FechaImpresion = (string)reader["FechaImpresion"];
            RetornarLibro.Id = (string)reader["Id"];
            RetornarLibro.NombreEditorial = (string)reader["NombreEditorial"];
            RetornarLibro.Direccion = (string)reader["Direccion"];
            RetornarLibro.Telefono = (string)reader["Telefono"];
            RetornarLibro.Cantidad = (int)reader["Cantidad"];
            RetornarLibro.Estado = (string)reader["Estado"];

            return RetornarLibro;
        }

        public void EliminarLibro(Libro librox)
        {
            using (var comando = Conexion.CreateCommand())
            {
                comando.CommandText= "delete from LibroNuevo where Codigo='" + librox.Codigo + "'";
                comando.ExecuteNonQuery();
            }
        }

        

        public Libro BuscarCodigo(string codigo)
        {
            using (var comando = Conexion.CreateCommand())
            {
                Libro LibroConsul = new Libro();
                comando.CommandText = "select * from LibroNuevo where Codigo='" + codigo + "' ";

                Reader = comando.ExecuteReader();

                if (Reader.Read()==true)
                {
                    LibroConsul.Codigo = Reader["Codigo"].ToString();
                    LibroConsul.Area = Reader["Area"].ToString();
                    LibroConsul.Autor = Reader["Autor"].ToString();
                    LibroConsul.Autor2 = Reader["Autor2"].ToString();
                    LibroConsul.Nombre = Reader["Nombre"].ToString();
                    LibroConsul.Ciudad = Reader["Ciudad"].ToString();
                    LibroConsul.Pais = Reader["Pais"].ToString();
                    LibroConsul.NumeroPaginas = Reader["NumPaginas"].ToString();
                    LibroConsul.FechaImpresion=Reader["FechaImpresion"].ToString();
                    LibroConsul.Id = Reader["Id"].ToString();
                    LibroConsul.NombreEditorial = Reader["NombreEditorial"].ToString();
                    LibroConsul.Direccion = Reader["Direccion"].ToString();
                    LibroConsul.Telefono = Reader["Telefono"].ToString();
                    LibroConsul.Estado = Reader["Estado"].ToString();
                    LibroConsul.Cantidad = Convert.ToInt32(Reader["Cantidad"]);
                    
                }
                else
                {
                    LibroConsul = null;                   
                }
                Reader.Close();
                return LibroConsul;
            }
        }



    }// no tocar
}
