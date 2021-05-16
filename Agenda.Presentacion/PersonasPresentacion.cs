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
        public PersonasPresentacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void PersonasPresentacion_Load(object sender, EventArgs e)
        {
            gvPersonas.DataSource = personasNegocio.CargarPersonas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
