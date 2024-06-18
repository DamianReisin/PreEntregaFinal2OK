using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> ventas()
        {
            return VentaBussines.ListarVenta().ToArray();
        }
        
        [HttpDelete(Name = "EliminarVenta")]
        public string Delete([FromBody] int id)
        {   
            bool status = VentaBussines.EliminarVenta(id);
            if(status) 
            {
                return "Eliminacion correcta";
            
            }
            else
            {
                return "No se pudo eliminar";
                    
            }
        }
       
        [HttpPut(Name = "ModificarVenta")]
        public bool Put([FromBody] Venta venta)
        {
           return VentaBussines.ModificarVenta(venta);
        }
        
        [HttpPost(Name = "AltaVenta")]
        public void Post(Venta venta)
        {
            VentaBussines.CrearVenta(venta);
        }

    }
}
