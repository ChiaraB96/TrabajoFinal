using System.ComponentModel.DataAnnotations;

namespace TrabajoFinal.Request
{
    public class EnfermeriaRequest
    {
        [Required]
        public string tipo { get; set; }
        [Required]
        public int saludActual { get; set; }
        [Required]
        public int cantidadVisitas { get; set; }
    }
}
