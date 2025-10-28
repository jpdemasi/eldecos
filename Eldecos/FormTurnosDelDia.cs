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
        private GestorTurnos gestorTurnos = new GestorTurnos();
        private GestorMedicos gestorMedicos = new GestorMedicos();
        private GestorPacientes gestorPacientes = new GestorPacientes();
       

        private int turnoSeleccionadoId;

        public FormTurnosDelDia(DateTime fecha)
        {
            InitializeComponent();
            CargarListaTurnosPacientes();
            CargarMedicos();
          //  CargarDatosDesdeApiAsync();
            this.fechaSeleccionada = fecha;
            this.gestorTurnos = new GestorTurnos();
            this.gestorMedicos = new GestorMedicos();
            this.gestorPacientes = new GestorPacientes();
        }
/*
        private async Task CargarDatosDesdeApiAsync()
        {
            try
            {
                dgvTurnos.DataSource = await gestorTurnos.ObtenerTodosLosTurnosAsync();
              
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos iniciales desde la API: " + ex.Message, "Error");
            }
        }*/


        private async Task CargarListaTurnosPacientes()
        {
            try
            {
                dgvTurnos.DataSource = await gestorPacientes.CargarDatosAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos iniciales desde la API: " + ex.Message, "Error");
            }
        }

        private async Task CargarMedicos()
        {
            try
            {
                var listaMedicos = await gestorMedicos.CargarListaMedicosTurno();
              

                cmbMedicos.DataSource = listaMedicos;
              
                cmbMedicos.DisplayMember = "especialidad";
                cmbMedicos.ValueMember = "id";
                cmbMedicos.DataSource = listaMedicos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos iniciales desde la API: " + ex.Message, "Error");
            }
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


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos o pacientes: {ex.Message}", "Error de Carga");
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        
        

        private async void btnModificar_Click(object sender, EventArgs e)
        {

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

        private void mntCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFecha.Text = mntCalendario.SelectionStart.ToShortDateString();
        }

        private void FormTurnosDelDia_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dgvTurnos.CurrentRow.Cells["pnombre"].Value.ToString(); 
            string apellido = dgvTurnos.CurrentRow.Cells["papellido"].Value.ToString();

         
            object idValue = dgvTurnos.CurrentRow.Cells["id"].Value;
            int pacienteSeleccionadoId = 0;
            
            if (idValue != null && int.TryParse(idValue.ToString(), out int id))
            {
                pacienteSeleccionadoId = id; // <-- Guardar el ID
                txtPaciente.Text = nombre + " " + apellido;
            }
            else
            {
                pacienteSeleccionadoId = 0;
                txtPaciente.Text = "Error al obtener ID";
            }
        }
    }
}