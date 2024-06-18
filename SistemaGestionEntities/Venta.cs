using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }


        public Venta(int id, string comentarios, int idUsuario)
        {
            id = Id;
            comentarios = Comentarios;
            idUsuario = IdUsuario;

        }
        public Venta() { }
    }
}
