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
    public partial class PersonasPresentacion : Form
    {
        PersonasNegocio personasNegocio = new PersonasNegocio();
        public PersonasPresentacion(bool seleccionar)
        {
            InitializeComponent();
            if (seleccionar)
            {
                btnSeleccionar.Visible = true;
            }
            else
            { 
                btnSeleccionar.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try 
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonasPresentacion_Load(object sender, EventArgs e)
        {
            try
            {
                gvPersonas.DataSource = personasNegocio.CargarPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
