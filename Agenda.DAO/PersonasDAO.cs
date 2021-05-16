using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agenda.DTO;
using System.Data;

namespace Agenda.DAO
{
    public class PersonasDAO
    {
        
        public List<PersonaDTO> CargarListaDTOs(DataTable dataTable)
        {
            List<PersonaDTO> listaPersonas = new List<PersonaDTO>();
            try
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PersonaDTO personaDTO = new PersonaDTO();
                    personaDTO.Id = (int)dataRow["Id"];
                    personaDTO.FechaNacimiento = (DateTime)dataRow["FechaNacimiento"];
                    personaDTO.Nombre = (string)dataRow["Nombre"];
                    personaDTO.Apellido = (string)dataRow["Apellido"];
                    listaPersonas.Add(personaDTO);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al convertir los datos" + ex);
            }
            return listaPersonas;
        }

        public List<PersonaDTO> CargarPersonas()
        {
            return CargarListaDTOs(HelperDAO.CargarDataTable(
                $"SELECT Id, FechaNacimiento, Nombre, Apellido FROM Personas;"));
        }

        public List<PersonaDTO> BuscarPersonas(string filtro)
        {
            return CargarListaDTOs(HelperDAO.CargarDataTable(
                $"SELECT Id, Nombre, Apellido, FechaNacimiento FROM Personas " +
                $"WHERE Nombre LIKE '%{filtro}%' or Apellido LIKE '%{filtro}%'"));
        }

        public int NuevaPersona(PersonaDTO personaDTO)
        {
            return HelperDAO.EditarDB($"INSERT INTO Personas " +
                $"(FechaNacimiento, Nombre, Apellido) VALUES (" +
                $"'{personaDTO.FechaNacimiento.ToString("yyyyMMdd")}', " +
                $"'{personaDTO.Nombre}', '{personaDTO.Apellido}')");
        }
        public int ModificarPersona (PersonaDTO personaDTO)
        {
            return HelperDAO.EditarDB($"UPDATE Personas SET FechaNacimiento = " +
                $"'{personaDTO.FechaNacimiento.ToString("yyyyMMdd")}', " +
                $"Nombre = '{personaDTO.Nombre}', Apellido = '{personaDTO.Apellido}' " +
                $"WHERE Id = {personaDTO.Id}");
        }
    }
}
