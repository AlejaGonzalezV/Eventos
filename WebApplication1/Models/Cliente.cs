using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string necesidad { get; set; }
        public string tipoDeEvento { get; set; }
        public string ubicacion { get; set; }
        public string fecha { get; set; }
        public int invitados { get; set; }
        public string detalles { get; set; }

    }
}
