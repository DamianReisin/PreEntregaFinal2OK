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
    public class ProductoVendidoData
    {

        public static List<ProductoVendido> ObtenerProductoVendidoData(int IdProductoVendido)
        {

            List<ProductoVendido> list = new List<ProductoVendido>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "SELECT Id, Stock, IdProducto, IdVenta From ProductoVendido Where Id=@IdProductoVendido";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProductoVendido";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdProductoVendido;

                    comando.Parameters.Add(parametro);
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                list.Add(productoVendido);

                            }
                        }


                    }
                }
                return list;
            }
        }
        public static List<ProductoVendido> ListarProductoVendidoData()
        {

            List<ProductoVendido> list = new List<ProductoVendido>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "SELECT Id, Descripciones,Costo, PrecioVenta, Stock, IdUsuario From ProductoVendido";
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
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                list.Add(productoVendido);

                            }
                        }


                    }



                }
                return list;
            }


        }
        public static bool CrearProductoVendidoData(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta)" +
          "VALUES(@Stock, @IdProducto, @IdVenta)";


                SqlCommand comando = new SqlCommand(query, conexion);
                
                    comando.Parameters.AddWithValue("Stock",productoVendido.Stock);
                    comando.Parameters.AddWithValue("IdProducto",productoVendido.IdProducto);
                    comando.Parameters.AddWithValue("IdVenta",productoVendido.IdVenta );
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
                
            }

        }
        public static bool ModificarProductoVendidoData(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
 
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                var query = "UPDATE ProductoVendido" +
                       "SET Stock = @Stock" +
                       ", IdProducto = @IdProducto" +
                       ",IdVenta = @IdVenta WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("Id", productoVendido.Id);
                comando.Parameters.AddWithValue("Stock", productoVendido.Stock);
                comando.Parameters.AddWithValue("IdProducto", productoVendido.IdProducto);
                comando.Parameters.AddWithValue("IdVenta", productoVendido.IdVenta);
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }


        }
        public static bool EliminarProductoVendidoData(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                var query = "DELETE FROM ProductoVendido WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("id", id);
                    return comando.ExecuteNonQuery() > 0;
                }

            }
        }

    }
}
