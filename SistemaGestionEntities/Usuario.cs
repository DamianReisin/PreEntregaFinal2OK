using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }


        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            id = Id;
            nombre = Nombre;
            apellido = Apellido;
            nombreUsuario = NombreUsuario;
            contraseña = Contraseña;
            mail = Mail;

        }
        public Usuario() { }
    }
}
