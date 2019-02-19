using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cliente
    {

        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string nombre { get; set; }

        [Required]
        public string correo { get; set; }

        public string telefono { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string necesidad { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string tipoDeEvento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string ubicacion { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public string fecha { get; set; }
        public int invitados { get; set; }

        [StringLength(500, MinimumLength = 30)]
        public string detalles { get; set; }

    }
}
