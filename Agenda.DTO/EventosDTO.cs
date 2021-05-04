using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.DTO
{
    public class EventosDTO
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; }
        public int Prioridad { get; set; }
        public string PrioridadTexto { get; set; }
        public int IdPersona { get; set; }
        public string PersonaNombreApellido { get; set; }
    }
}
