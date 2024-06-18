using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussines
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int productoVendidoData)
        {
            return ProductoVendidoData.ObtenerProductoVendidoData(productoVendidoData);
        }

        public static List<ProductoVendido> ListarProductoVendido()
        {
            return ProductoVendidoData.ListarProductoVendidoData();
        }
        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            return ProductoVendidoData.CrearProductoVendidoData(productoVendido);
        }
        public static bool EliminarProductoVendido(int id)
        {
           return ProductoVendidoData.EliminarProductoVendidoData(id);
        }
        public static bool ModificarProductoVendido(ProductoVendido productoVendido)
        {
           return ProductoVendidoData.ModificarProductoVendidoData(productoVendido);
        }
    }
}
