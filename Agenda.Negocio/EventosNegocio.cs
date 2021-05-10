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
        public List<EventoDTO> CargarEventos(DateTime fechaInicio, DateTime fechaFinal)
        {
            return eventosDAO.CargarEventos(fechaInicio, fechaFinal);
        }
    }
}
