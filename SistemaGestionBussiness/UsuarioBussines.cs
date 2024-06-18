using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;
namespace SistemaGestionBussiness
{
    public class UsuarioBussines
    {
        public static List<Usuario> ObtenerUsuario(int usuarioData)
        {
            return UsuarioData.ObtenerUsuarioData(usuarioData);
        }

        public static List<Usuario> ListarUsuarios() 
        {
            return UsuarioData.ListarUsuarioData();
        }
        public static bool CrearUsuario(Usuario usuario)
        {
            return UsuarioData.CrearUsuarioData(usuario);
        }
        public static bool EliminarUsuario(int id)
        {
            return UsuarioData.EliminarUsuario(id);
        }
        public static bool ModificarUsuario(Usuario usuario) 
        {
            return UsuarioData.ModificarUsuario(usuario);
        }
    }
}
