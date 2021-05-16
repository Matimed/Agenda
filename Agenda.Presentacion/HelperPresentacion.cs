using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.Presentacion
{
    public static class HelperPresentacion
    {
        public static void ValidarTextosVacios(params string[] textosValidar)
        {
            try
            {
                foreach (string textoValidar in textosValidar)
                {
                    if (string.IsNullOrEmpty(textoValidar))
                    {
                        throw new Exception("No se pueden dejar campos sin completar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
