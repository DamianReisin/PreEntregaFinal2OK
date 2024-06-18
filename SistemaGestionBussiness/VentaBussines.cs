using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussines
    {
        public static List<Venta> ObtenerVenta(int ventaData)
        {
            return VentaData.ObtenerVentaData(ventaData);
        }

        public static List<Venta> ListarVenta()
        {
            return VentaData.ListarVentaData();
        }
        public static bool CrearVenta(Venta venta)
        {
           return VentaData.CrearVentaData(venta);
        }
        public static bool EliminarVenta(int id)
        {
            return VentaData.EliminarVentaData(id);
        }
        public static bool ModificarVenta(Venta venta)
        {
            return VentaData.ModificarVentaData(venta);
        }
    }
}
