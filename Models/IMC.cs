using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion.Models
{
    [Table("imc")]
    public class IMC
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public float Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
