using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrabajoFinal.Model;

namespace TrabajoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroeController : ControllerBase
    {
        [HttpGet("crearSuperheroe")]
        public ActionResult CrearSuperheroe(string tipo, string name)
        {
            ISuperheroe superheroe;
            try
            {
                superheroe = SuperheroeFactory.CrearSuperheroe(tipo, name);
            }
            catch (ArgumentException)
            {
                return BadRequest("Tipo de héroe inválido");
            }
            return Ok(new
            {
                Nombre = superheroe.Nombre,
                Fuerza = superheroe.Fuerza,
                Salud = superheroe.Salud,
                PoderEspecial = superheroe.PoderEspecial
            });
        }
    }
}
