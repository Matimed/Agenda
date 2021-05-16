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

        public List<PersonaDTO> BuscarPersonas(string filtro)
        {
            return personasDAO.BuscarPersonas(filtro);
        }

        public int NuevaPersona(PersonaDTO personaDTO)
        {
            return personasDAO.NuevaPersona(personaDTO);
        }

        public int ModificarPersona(PersonaDTO personaDTO)
        {
            return personasDAO.ModificarPersona(personaDTO);
        }
    }
}
