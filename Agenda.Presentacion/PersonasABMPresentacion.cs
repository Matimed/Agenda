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
    public partial class PersonasABMPresentacion : Form
    {
        public bool Modificacion { get; set; }
        public PersonaDTO PersonaSeleccionada {get; set; }

        PersonasNegocio personasNegocio = new PersonasNegocio();
        
        public PersonasABMPresentacion(bool modificar)
        {
            InitializeComponent();
            Modificacion = modificar;
        }

        private void PersonasABMPresentacion_Load(object sender, EventArgs e)
        {
            if (Modificacion)
            {
                Text = "Modificar Contacto";
            }
            else
            {
                PersonaSeleccionada = new PersonaDTO();
                Text = "Nuevo Contacto";
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
            }
            ActiveControl = label1;
        }


        public void CargarPersona(PersonaDTO personaDTO)
        {
            PersonaSeleccionada = personaDTO;
            dtpFechaNacimiento.Value = personaDTO.FechaNacimiento;
            txtNombre.Text = personaDTO.Nombre;
            txtApellido.Text = personaDTO.Apellido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                HelperPresentacion.ValidarTextosVacios(txtNombre.Text, txtApellido.Text);
                PersonaSeleccionada.Nombre = txtNombre.Text;
                PersonaSeleccionada.Apellido = txtApellido.Text;
                PersonaSeleccionada.FechaNacimiento = dtpFechaNacimiento.Value;
              
                if (Modificacion)
                {
                    MessageBox.Show(
                                    $"{personasNegocio.ModificarPersona(PersonaSeleccionada)} registro /s actualizados correctamente",
                                    "Actualización completada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show($"{personasNegocio.NuevaPersona(PersonaSeleccionada)} registros creados correctamente",
                        "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
