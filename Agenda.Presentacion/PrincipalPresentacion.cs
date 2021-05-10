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
        private List<DateTime> Fecha { get; set; }

        public PrincipalPresentacion()
        {
            InitializeComponent();
        }

        private void cldFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                List<DateTime> fecha = new List<DateTime>();
                fecha.Add(cldFecha.SelectionStart);
                fecha.Add(cldFecha.SelectionEnd);
                gvEventos.DataSource = eventosNegocio.CargarEventos(fecha[0], fecha[1]);
                Fecha = fecha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal al seleccionar la fecha:" +
                  ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEventos.SelectedRows.Count == 1)
                {
                    EventosABMPresentacion eventosABM = new EventosABMPresentacion();
                    eventosABM.Modificacion = true;
                    eventosABM.CargarForm((EventoDTO)gvEventos.SelectedRows[0].DataBoundItem);
                    eventosABM.ShowDialog();
                    gvEventos.DataSource = eventosNegocio.CargarEventos(Fecha[0], Fecha[1]);
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
            try
            {
                EventosABMPresentacion eventosABM = new EventosABMPresentacion();
                eventosABM.Modificacion = false;
                eventosABM.CargarForm(new EventoDTO());
                eventosABM.ShowDialog();
                gvEventos.DataSource = eventosNegocio.CargarEventos(Fecha[0], Fecha[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
