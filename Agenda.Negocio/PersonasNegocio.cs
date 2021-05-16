using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agenda.DAO;
using Agenda.DTO;

namespace Agenda.Negocio
{
    public class PersonasNegocio
    {
        PersonasDAO personasDAO = new PersonasDAO();
        public List<PersonaDTO> CargarPersonas()
        {
            return personasDAO.CargarPersonas();
        }
    }
}
