using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        public static List<Usuario> ObtenerUsuarioData(int IdUsuarioData)
        {

            List<Usuario> list = new List<Usuario>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail  From Usuario Where Id=@IdVentaData";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdUsuarioData";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdUsuarioData;

                    comando.Parameters.Add(parametro);
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Contraseña = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();

                                list.Add(usuario);

                            }
                        }


                    }
                }
                return list;
            }
        }
        public static List<Usuario> ListarUsuarioData()
        {

            List<Usuario> list = new List<Usuario>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail  From Usuario";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {


                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Contraseña = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();

                                list.Add(usuario);

                            }
                        }


                    }
                }
                return list;
            }
        }
        public static bool CrearUsuarioData(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
           
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" +
             "VALUES(@Nombre,@Apellido,@NombreUsuario,@Contraseña,@Mail)";

                SqlCommand comando = new SqlCommand(query, conexion);
                
                    comando.Parameters.AddWithValue("Nombre", usuario.Nombre );
                    comando.Parameters.AddWithValue("Apellido", usuario.Apellido );
                    comando.Parameters.AddWithValue("NombreUsuario",usuario.NombreUsuario );
                    comando.Parameters.AddWithValue("Contraseña", usuario.Contraseña );
                    comando.Parameters.AddWithValue("Mail" ,usuario.Mail );
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }

        }
        public static bool ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
          

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                var query = "UPDATE Usuario" +
                          "SET Nombre = @Nombre"
                          + ", Apellido = @Apellido"
                          + ", NombreUsuario = @NombreUsuario"
                          + ", Contraseña = @Contraseña "
                          + ", Mail= @Mail  WHERE Id = @Id";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("Id", usuario.Id);
                comando.Parameters.AddWithValue("Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("Apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("NombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("Contraseña", usuario.Contraseña);
                comando.Parameters.AddWithValue("Mail", usuario.Mail);
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }

        }
        public static bool EliminarUsuario(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                var query = "DELETE FROM Usuario WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("id", id);
                    return comando.ExecuteNonQuery() > 0;
                }

            }
        }


    }
}
