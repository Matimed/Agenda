using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agenda.DTO;
using Agenda.DAO;

namespace Agenda.Negocio
{
    public class EventosNegocio
    {
        EventosDAO eventosDAO = new EventosDAO();

        public List<EventoDTO> CargarEventos(List<DateTime> fecha)
        {
            return eventosDAO.CargarEventos(fecha);
        }

        public int ModificarEvento (EventoDTO nuevoEvento)
        {
            return eventosDAO.ModificarEvento(nuevoEvento);
        }

        public int NuevoEvento(EventoDTO nuevoEvento)
        {
            return eventosDAO.NuevoEvento(nuevoEvento);
        }
    }
}
