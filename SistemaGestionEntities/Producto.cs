using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionEntities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripciones { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Stock { get; set; }
        public int IdUsuario { get; set; }
        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, decimal stock, int idUsario)
        {
            id = Id;
            descripcion = Descripciones;
            costo = Costo;
            precioVenta = PrecioVenta;
            stock = Stock;
            idUsario = IdUsuario;
        }
        public Producto() { }
    }
}
