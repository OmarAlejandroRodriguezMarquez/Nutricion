using System.ComponentModel.DataAnnotations;

namespace Nutricion.API.Models
{
    public class IMC
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="La {0} es requerida")]
        public float Altura { get; set; }
        public float Peso { get; set; }
        public float Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
