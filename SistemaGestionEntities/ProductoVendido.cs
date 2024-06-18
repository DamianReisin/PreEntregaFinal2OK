using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {

        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public ProductoVendido(int id, int stock, int idProducto, int idVenta)
        {
            id = Id;
            stock = Stock;
            idProducto = IdProducto;
            idVenta = IdVenta;
        }
        public ProductoVendido() { }
    }
}
