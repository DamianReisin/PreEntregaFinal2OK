using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public  IEnumerable<Usuario> usuarios() 
        {
           return UsuarioBussines.ListarUsuarios().ToArray();
        }
        [HttpDelete(Name = "EliminarUsuario")]
        public string Delete([FromBody] int id)
        {
            bool status = UsuarioBussines.EliminarUsuario(id);
            if (status)
            {
                return "Eliminacion correcta";

            }
            else
            {
                return "No se pudo eliminar";

            }

        }
        [HttpPut(Name = "ModificarUsuario")]
        public bool Put([FromBody] Usuario usuario)
        {
            return UsuarioBussines.ModificarUsuario(usuario);
        }
        [HttpPost(Name = "AltaUsuario")]
        public bool Post([FromBody] Usuario usuario)
        {
            return UsuarioBussines.CrearUsuario(usuario);
        }


    }
}
