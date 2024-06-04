
using Data;
using Microsoft.AspNetCore.Mvc;
using Models.Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            
            return ProductoData.listaProducto;
        }

    }
}