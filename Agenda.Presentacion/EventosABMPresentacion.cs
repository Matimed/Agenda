using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Agenda.DTO;
using Agenda.Negocio;
using System.Windows.Forms;

namespace Agenda.Presentacion
{
    public partial class EventosABMPresentacion : Form
    {
        public PersonaDTO PersonaSeleccionada { get; set; }

        public EventoDTO EventoSeleccionado { get; set; }

        EventosNegocio EventosNegocio = new EventosNegocio();

        public EventosABMPresentacion()
        {
            InitializeComponent();
        }

        private void EventosABMPresentacion_Load(object sender, EventArgs e)
        {
            ActiveControl = lblTitulo;
        }

        public void Modificar(EventoDTO eventoDTO)
        {
            EventoSeleccionado = eventoDTO;
            Text = "Modificar Evento";
            dtpDia.Value = eventoDTO.FechaHora;
            dtpHora.Value = eventoDTO.FechaHora;
            txtDescripcion.Text = eventoDTO.Descripcion;
            txtPersona.Text = eventoDTO.PersonaNombreApellido;
            PersonaSeleccionada = new PersonaDTO();
            PersonaSeleccionada.Id = eventoDTO.IdPersona;
            switch (eventoDTO.Prioridad)
            {
                case 0:
                    rbtBaja.Checked = true;
                    break;
                case 1:
                    rbtMedia.Checked = true;
                    break;
                case 2:
                    rbtAlta.Checked = true;
                    break;
                default:
                    rbtBaja.Checked = false;
                    rbtMedia.Checked = false;
                    rbtAlta.Checked = false;
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EventoSeleccionado.Descripcion = txtDescripcion.Text;
            TimeSpan horario = dtpHora.Value - dtpHora.Value.Date;
            EventoSeleccionado.FechaHora = dtpDia.Value.Date.Add(horario);
            EventoSeleccionado.IdPersona = PersonaSeleccionada.Id;
            if (rbtAlta.Checked)
            {
                EventoSeleccionado.Prioridad = 2;
            }
            else if (rbtMedia.Checked)
            {
                EventoSeleccionado.Prioridad = 1;
            }
            else if (rbtBaja.Checked)
            {
                EventoSeleccionado.Prioridad = 0;
            }
            //Solo si es modificar
            MessageBox.Show(
                $"{EventosNegocio.ModificarEvento(EventoSeleccionado)} registro /s actualizados correctamente",
                "Actualización completada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
