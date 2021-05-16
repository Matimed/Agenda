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


        private void PrincipalPresentacion_Load(object sender, EventArgs e)
        {
            CargarEventos(DateTime.Now, DateTime.Now);
        }


        private void CargarEventos(DateTime fechaInicio, DateTime fechaFinal)
        {
            try
            {
                List<DateTime> fecha = new List<DateTime>();
                fecha.Add(fechaInicio);
                fecha.Add(fechaFinal);
                gvEventos.DataSource = eventosNegocio.CargarEventos(fecha);
                Fecha = fecha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal al seleccionar la fecha:" +
                  ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cldFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            CargarEventos(cldFecha.SelectionStart, cldFecha.SelectionEnd);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEventos.SelectedRows.Count == 1)
                {
                    EventosABMPresentacion eventosABM = new EventosABMPresentacion(true);
                    eventosABM.CargarEvento((EventoDTO)gvEventos.SelectedRows[0].DataBoundItem);
                    eventosABM.ShowDialog();
                    gvEventos.DataSource = eventosNegocio.CargarEventos(Fecha);
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
                EventosABMPresentacion eventosABM = new EventosABMPresentacion(false);
                eventosABM.ShowDialog();
                gvEventos.DataSource = eventosNegocio.CargarEventos(Fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                PersonasPresentacion personasPresentacion = new PersonasPresentacion(false);
                personasPresentacion.ShowDialog();
                gvEventos.DataSource = eventosNegocio.CargarEventos(Fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
