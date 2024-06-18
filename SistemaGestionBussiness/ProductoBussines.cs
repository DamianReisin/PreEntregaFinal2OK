using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussines
    {
        public static List<Producto> ObtenerProducto(int productoData)
        {
            return ProductoData.ObtenerProductoData(productoData);
        }

        public static List<Producto> ListarProducto()
        {
            return ProductoData.ListarProductoData();
        }
        public static bool CrearProducto(Producto producto)
        {
            return ProductoData.CrearProductoData(producto);
        }
        public static bool EliminarProducto(int id)
        {
            return ProductoData.EliminarProductoData(id);
        }
        public static bool ModificarProducto(Producto producto)
        {
            return ProductoData.ModificarProductoData(producto);
        }

    }
}

