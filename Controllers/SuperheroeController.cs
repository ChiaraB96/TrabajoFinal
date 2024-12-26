using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrabajoFinal.Model;
using TrabajoFinal.Request;

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
        [HttpGet("visitarEnfermeria")]
        public ActionResult VisitarEnfermeria([FromQuery] EnfermeriaRequest request)
        {
            var enfermeria = EnfermeriaSingleton.Instancia;
            int saludActual = request.saludActual;
            bool atencion = enfermeria.VisitarEnfermeria(ref saludActual, request.cantidadVisitas);

            if (atencion)
            {
                return Ok(new
                {
                    Salud = saludActual,
                    AtencionesRestantes = enfermeria.GetVisitasRestantes()
                });
            }
            else
            {
                return BadRequest("Limite de visitas alcanzado");
            }
        }
    }
}
