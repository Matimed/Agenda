using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.DTO
{
    public class PersonasDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
