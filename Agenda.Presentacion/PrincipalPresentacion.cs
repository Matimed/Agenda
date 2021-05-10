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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEventos.SelectedRows.Count == 1)
                {
                    EventosABMPresentacion eventosABM = new EventosABMPresentacion();
                    eventosABM.Modificar((EventoDTO)gvEventos.SelectedRows[0].DataBoundItem);
                    eventosABM.ShowDialog();
                }
                else
                {
                    throw new Exception("Debe seleccionar un elemento para modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EventosABMPresentacion eventosABM = new EventosABMPresentacion();
            eventosABM.Nuevo();
            eventosABM.ShowDialog();
        }
    }
}
