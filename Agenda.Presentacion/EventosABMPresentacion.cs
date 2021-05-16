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

        public bool Modificacion { get; set; }
        
        public EventoDTO EventoSeleccionado { get; set; }

        EventosNegocio eventosNegocio = new EventosNegocio();

        public EventosABMPresentacion()
        {
            InitializeComponent();
            Modificacion = false;
        }

        private void EventosABMPresentacion_Load(object sender, EventArgs e)
        {
            ActiveControl = lblTitulo;
        }

        public void CargarForm(EventoDTO eventoDTO)
        {
            EventoSeleccionado = eventoDTO;
            PersonaSeleccionada = new PersonaDTO();
            if (Modificacion)
            {
                Text = "Modificar Evento";
                dtpDia.Value = eventoDTO.FechaHora;
                dtpHora.Value = eventoDTO.FechaHora;
                txtDescripcion.Text = eventoDTO.Descripcion;
                txtPersona.Text = eventoDTO.PersonaNombreApellido;
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
            else
            {
                Text = "Crear Evento";
                txtDescripcion.Text = string.Empty;
                txtPersona.Text = string.Empty;
            }
        }
        public void Modificar(EventoDTO eventoDTO)
        {
            Modificacion = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //ToDo: Validar entradas.
            try
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
                if (Modificacion)
                {
                    MessageBox.Show(
                                    $"{eventosNegocio.ModificarEvento(EventoSeleccionado)} registro /s actualizados correctamente",
                                    "Actualización completada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show($"{eventosNegocio.NuevoEvento(EventoSeleccionado)} registros creados correctamente",
                        "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PersonasPresentacion personasPresentacion = new PersonasPresentacion(true);
            personasPresentacion.ShowDialog();
            PersonaSeleccionada = personasPresentacion.PersonaSeleccionada;
            txtPersona.Text = PersonaSeleccionada.Nombre + PersonaSeleccionada.Apellido;
        }
    }
}
