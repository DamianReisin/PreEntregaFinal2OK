using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> productosVendidos()
        {
            return ProductoVendidoBussines.ListarProductoVendido().ToArray();
        }
        [HttpDelete(Name = "EliminarProductoVendido")]
        public string Delete([FromBody] int id)
        {
            bool status = ProductoVendidoBussines.EliminarProductoVendido(id);
            if (status)
            {
                return "Eliminacion correcta";

            }
            else
            {
                return "No se pudo eliminar";

            }
        }
        [HttpPut(Name = "ModificarProductoVendido")]
        public bool Put([FromBody] ProductoVendido productoVendido)
        {
            return ProductoVendidoBussines.ModificarProductoVendido(productoVendido);
        }
        [HttpPost(Name = "AltaCliente")]
        public bool Post([FromBody] ProductoVendido productoVendido) 
        {
            return ProductoVendidoBussines.CrearProductoVendido(productoVendido);
        }



    }
}
