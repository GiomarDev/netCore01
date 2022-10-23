using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() {
                new Autor() { id = 1, nombre = "Giomar"},
                new Autor() { id = 2, nombre = "Gerson"}
            };
        }
    }
}
