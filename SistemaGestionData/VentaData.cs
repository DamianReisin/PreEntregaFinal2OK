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
    public class VentaData
    {
        public static List<Venta> ObtenerVentaData(int IdVentaData)
        {

            List<Venta> list = new List<Venta>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion;Trusted_Connection= True;";
            var query = "SELECT Id, Comentarios, IdUsuario From Venta Where Id=@IdVentaData";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdVentaData";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdVentaData;

                    comando.Parameters.Add(parametro);
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(dr["Id"]);
                                venta.Comentarios = dr["Comentarios"].ToString(); ;
                                venta.IdUsuario = Convert.ToInt32(dr["IdProducto"]);
                                list.Add(venta);

                            }
                        }


                    }
                }
                return list;
            }
        }
        public static List<Venta> ListarVentaData()
        {



            List<Venta> list = new List<Venta>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "SELECT Id, Comentarios, IdUsuario From Venta";
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
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(dr["Id"]);
                                venta.Comentarios = dr["Comentarios"].ToString(); ;
                                venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                list.Add(venta);

                            }
                        }


                    }
                }
                return list;
            }
        }
        public static bool CrearVentaData(Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
           
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                
                var query = "INSERT INTO Venta (Comentarios, IdUsuario)" +
           "VALUES(@Comentarios, @IdUsuario)";


                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("Comentarios", venta.Comentarios);
                comando.Parameters.AddWithValue("IdUsuario", venta.IdUsuario);
                conexion.Open();
                return comando.ExecuteNonQuery() > 0; 
            }

        }
        public static bool ModificarVentaData(Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
               
                var query = "UPDATE Venta SET Comentarios =@Comentarios, IdUsuario = @IdUsuario WHERE Id = @Id"; 
           
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("Id", venta.Id );
                comando.Parameters.AddWithValue("Comentarios",venta.Comentarios);
                comando.Parameters.AddWithValue("IdUsuario", venta.IdUsuario );
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }

        }
        public static bool EliminarVentaData(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
           
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                var query = "DELETE FROM Venta WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("id",id);
                    return comando.ExecuteNonQuery() > 0;
                }
                
            }
        }
    }
}
