using System;

namespace Agenda.DTO
{
    public class EventoDTO
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
