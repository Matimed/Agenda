using System;
using System.Windows.Forms;
using Agenda.DTO;
using Agenda.Negocio;

namespace Agenda.Presentacion
{
    public partial class PersonasPresentacion : Form
    {
        public PersonaDTO PersonaSeleccionada { get; set; }

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
                PersonasABMPresentacion personasABMPresentacion = new PersonasABMPresentacion(false);
                personasABMPresentacion.ShowDialog();
                gvPersonas.DataSource = personasNegocio.CargarPersonas();
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PersonaSeleccionada = (PersonaDTO)gvPersonas.SelectedRows[0].DataBoundItem;
            DialogResult = DialogResult.OK;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonasABMPresentacion personasABMPresentacion = new PersonasABMPresentacion(true);
                personasABMPresentacion.CargarPersona((PersonaDTO)gvPersonas.SelectedRows[0].DataBoundItem);
                personasABMPresentacion.ShowDialog();
                gvPersonas.DataSource = personasNegocio.CargarPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gvPersonas.DataSource = personasNegocio.BuscarPersonas(txtFiltro.Text);
                txtFiltro.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            try
            {
                gvPersonas.DataSource = personasNegocio.CargarPersonas();
                txtFiltro.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}