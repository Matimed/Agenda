
namespace Agenda.Presentacion
{
    partial class PrincipalPresentacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvEventos = new System.Windows.Forms.DataGridView();
            this.cldFecha = new System.Windows.Forms.MonthCalendar();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioridadTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvEventos
            // 
            this.gvEventos.AllowUserToAddRows = false;
            this.gvEventos.AllowUserToDeleteRows = false;
            this.gvEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaHora,
            this.IdPersona,
            this.Persona,
            this.Descripcion,
            this.NroPrioridad,
            this.PrioridadTexto});
            this.gvEventos.Location = new System.Drawing.Point(278, 12);
            this.gvEventos.Name = "gvEventos";
            this.gvEventos.ReadOnly = true;
            this.gvEventos.Size = new System.Drawing.Size(493, 220);
            this.gvEventos.TabIndex = 0;
            // 
            // cldFecha
            // 
            this.cldFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cldFecha.Location = new System.Drawing.Point(18, 45);
            this.cldFecha.Name = "cldFecha";
            this.cldFecha.TabIndex = 1;
            // 
            // btnPersonas
            // 
            this.btnPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonas.Location = new System.Drawing.Point(278, 251);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(98, 25);
            this.btnPersonas.TabIndex = 2;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(673, 251);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 25);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(554, 251);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 25);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FechaHora
            // 
            this.FechaHora.DataPropertyName = "FechaHora";
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // IdPersona
            // 
            this.IdPersona.DataPropertyName = "IdPersona";
            this.IdPersona.HeaderText = "IdPersona";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.ReadOnly = true;
            this.IdPersona.Visible = false;
            // 
            // Persona
            // 
            this.Persona.DataPropertyName = "PersonaNombreApellido";
            this.Persona.HeaderText = "Persona";
            this.Persona.Name = "Persona";
            this.Persona.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // NroPrioridad
            // 
            this.NroPrioridad.DataPropertyName = "Prioridad";
            this.NroPrioridad.HeaderText = "NroPrioridad";
            this.NroPrioridad.Name = "NroPrioridad";
            this.NroPrioridad.ReadOnly = true;
            this.NroPrioridad.Visible = false;
            // 
            // PrioridadTexto
            // 
            this.PrioridadTexto.DataPropertyName = "PrioridadTexto";
            this.PrioridadTexto.HeaderText = "Prioridad";
            this.PrioridadTexto.Name = "PrioridadTexto";
            this.PrioridadTexto.ReadOnly = true;
            // 
            // PrincipalPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 288);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.cldFecha);
            this.Controls.Add(this.gvEventos);
            this.Name = "PrincipalPresentacion";
            this.Text = "Agenda - Principal";
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioridadTexto;
        private System.Windows.Forms.MonthCalendar cldFecha;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
    }
}