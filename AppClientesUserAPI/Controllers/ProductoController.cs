using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> productos()
        {
            return ProductoBussines.ListarProducto().ToArray();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public string Delete([FromBody] int id)
        {
            bool status = ProductoBussines.EliminarProducto(id);
            if (status)
            {
                return "Eliminacion correcta";

            }
            else
            {
                return "No se pudo eliminar";

            }
        }
        [HttpPut(Name = "ModificarProducto")]
        public bool Put([FromBody] Producto producto)
        {
            return ProductoBussines.ModificarProducto(producto);
        }
        [HttpPost(Name = "AltaProducto")]
        public bool Post([FromBody] Producto producto)
        {
           return ProductoBussines.CrearProducto(producto);
        }

    }
}
