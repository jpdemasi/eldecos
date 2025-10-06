using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eldecos;
using System.Net;
using System.Globalization;
using System.Net.Http;
using Newtonsoft.Json;

namespace Eldecos
{
    public partial class FormTurnosDelDia : Form
    {
        private DateTime fechaSeleccionada;
        private GestorTurnos gestorTurnos;
        private GestorMedicos gestorMedicos;
        private GestorPacientes gestorPacientes;
        private int turnoSeleccionadoId;

        public FormTurnosDelDia(DateTime fecha)
        {
            InitializeComponent();
            this.fechaSeleccionada = fecha;
            this.gestorTurnos = new GestorTurnos();
            this.gestorMedicos = new GestorMedicos();
            this.gestorPacientes = new GestorPacientes();
            this.dgvTurnos.CellClick += dgvTurnos_CellClick;
        }

        private async void FormTurnosDelDia_Load(object sender, EventArgs e)
        {
            this.Text = $"Turnos del {fechaSeleccionada.ToShortDateString()}";
            await CargarDatos();
            ConfigurarHoras();
        }

        private void ConfigurarHoras()
        {
            cmbHora.Items.Clear();
            for (int h = 8; h <= 12; h++)
            {
                cmbHora.Items.Add($"{h:00}:00");
                cmbHora.Items.Add($"{h:00}:30");
            }
            cmbHora.Items.Add("13:00");
            cmbHora.SelectedIndex = 0;
        }

        private async Task CargarDatos()
        {
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");
            dgvTurnos.DataSource = await gestorTurnos.ObtenerTurnosPorFechaAsync(fechaFormateada);
            EstiloDgvTurnos.AplicarEstilo(dgvTurnos);

            try
            {
                cmbMedicos.DataSource = await gestorMedicos.CargarDatosAsync();
                cmbMedicos.DisplayMember = "nombre";
                cmbMedicos.ValueMember = "id";

                cmbPacientes.DataSource = await gestorPacientes.CargarDatosAsync();
                cmbPacientes.DisplayMember = "pnombre";
                cmbPacientes.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos o pacientes: {ex.Message}", "Error de Carga");
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbMedicos.SelectedValue == null || cmbPacientes.SelectedValue == null || cmbHora.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un médico, un paciente y una hora.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Turno nuevoTurno = new Turno
            {
                medico_id = Convert.ToInt32(cmbMedicos.SelectedValue),
                paciente_id = Convert.ToInt32(cmbPacientes.SelectedValue),
                fecha = fechaSeleccionada.ToString("yyyy-MM-dd"),
                hora = cmbHora.SelectedItem.ToString()
            };

            bool agregado = await gestorTurnos.AgregarTurnoAsync(nuevoTurno);
            if (agregado)
            {
                MessageBox.Show("Turno agregado correctamente.", "Éxito");
                await CargarDatos(); // Vuelve a cargar los turnos
            }
            else
            {
                MessageBox.Show("No se pudo agregar el turno.", "Error");
            }
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvTurnos.Rows[e.RowIndex];

                turnoSeleccionadoId = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                if (filaSeleccionada.Cells["medico_id"].Value != null)
                {
                    cmbMedicos.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["medico_id"].Value);
                }
                if (filaSeleccionada.Cells["paciente_id"].Value != null)
                {
                    cmbPacientes.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["paciente_id"].Value);
                }
                if (filaSeleccionada.Cells["hora"].Value != null)
                {
                    cmbHora.SelectedItem = filaSeleccionada.Cells["hora"].Value.ToString();
                }
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (turnoSeleccionadoId == 0)
            {
                MessageBox.Show("Selecciona un turno para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Turno turnoModificado = new Turno
            {
                medico_id = Convert.ToInt32(cmbMedicos.SelectedValue),
                paciente_id = Convert.ToInt32(cmbPacientes.SelectedValue),
                fecha = fechaSeleccionada.ToString("yyyy-MM-dd"),
                hora = cmbHora.SelectedItem.ToString()
            };

            bool modificado = await gestorTurnos.ModificarTurnoAsync(turnoSeleccionadoId, turnoModificado);
            if (modificado)
            {
                MessageBox.Show("Turno modificado correctamente.");
                await CargarDatos();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (turnoSeleccionadoId == 0)
            {
                MessageBox.Show("Selecciona un turno para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro que deseas eliminar este turno?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                bool eliminado = await gestorTurnos.EliminarTurnoAsync(turnoSeleccionadoId);
                if (eliminado)
                {
                    MessageBox.Show("Turno eliminado correctamente.", "Éxito");
                    await CargarDatos();
                    turnoSeleccionadoId = 0;
                }
            }
        }
    }
}