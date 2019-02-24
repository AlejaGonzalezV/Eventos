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

        
        [Required]
        public string nombre { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string correo { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        public string telefono { get; set; }

        
        [Required]
        public string necesidad { get; set; }

        
        [Required]
        public string tipoDeEvento { get; set; }

        
        [Required]
        public string ubicacion { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [Required]
        public string fecha { get; set; }
        public int invitados { get; set; }

        [StringLength(500, MinimumLength = 30)]
        public string detalles { get; set; }

    }
}
