using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Agenda.DTO;
using System.Windows.Forms;

namespace Agenda.Presentacion
{
    public partial class EventosABMPresentacion : Form
    {
        public EventosABMPresentacion()
        {
            InitializeComponent();
        }


        public void Nuevo()
        {
            Text = "Nuevo Evento";
        }
        public void Modificar(EventoDTO eventoDTO)
        {
            Text = "Modificar Evento";
            dtpDia.Value = eventoDTO.FechaHora;
            dtpHora.Value = eventoDTO.FechaHora;
            txtDescripcion.Text = eventoDTO.Descripcion;
            txtPersona.Text = eventoDTO.PersonaNombreApellido;
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

        private void EventosABMPresentacion_Load(object sender, EventArgs e)
        {
            ActiveControl = lblTitulo;
        }
    }
}
