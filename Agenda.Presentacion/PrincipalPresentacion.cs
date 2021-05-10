using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Agenda.DTO;
using Agenda.Negocio;

namespace Agenda.Presentacion
{
    public partial class PrincipalPresentacion : Form
    {
        EventosNegocio eventosNegocio = new EventosNegocio();
        public PrincipalPresentacion()
        {
            InitializeComponent();
        }

        private void cldFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            gvEventos.DataSource = eventosNegocio.CargarEventos(cldFecha.SelectionStart, cldFecha.SelectionEnd);
        }
    }
}
