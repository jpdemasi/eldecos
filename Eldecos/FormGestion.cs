using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiProyecto.ControlesPersonalizados; // Asegúrate de que este namespace sea accesible
using System.Net;
using System.Globalization;
using System.Net.Http;
using Newtonsoft.Json;

namespace Eldecos
{
    public partial class FormGestion : Form
    {
        private GestorPacientes gestorPacientes;
        private GestorMedicos gestorMedicos;
        private DateTime fechaActual;

        public FormGestion()
        {
            InitializeComponent();
            fechaActual = DateTime.Now;
            CargarDias();
            gestorPacientes = new GestorPacientes();
            gestorMedicos = new GestorMedicos();
            dgvPacientes.CellClick += dgvPacientes_CellClick;

            // Inicia la carga de datos de forma asíncrona al iniciar
            CargarDatosDesdeApiAsync();

            tbRecepcion.SelectedIndex = 0;
        }

        private async Task CargarDatosDesdeApiAsync()
        {
            try
            {
                dgvPacientes.DataSource = await gestorPacientes.CargarDatosAsync();
                dgvMedicos.DataSource = await gestorMedicos.CargarDatosAsync();
                EstiloDgvPacientes.AplicarEstilo(dgvPacientes);
                EstiloDgvMedicos.AplicarEstilo(dgvMedicos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos iniciales desde la API: " + ex.Message, "Error");
            }
        }

        private void LimpiarCampos()
        {
            txtNombrePaciente.Text = "";
            txtApellidoPaciente.Text = "";
            txtDni.Text = "";
            txtDireccionPaciente.Text = "";
            txtTelefonoPaciente.Text = "";
            txtMailPaciente.Text = "";
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            // Lógica de carga eliminada de aquí, ahora está en CargarDatosDesdeApiAsync()
        }

        private void CargarDias()
        {
            flpDias.Controls.Clear();
            DateTime primerDia = new DateTime(fechaActual.Year, fechaActual.Month, 1);
            int diasEnMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);
            int diaSemana = (int)primerDia.DayOfWeek;
            diaSemana = diaSemana == 0 ? 6 : diaSemana - 1;

            lblMes.Text = fechaActual.ToString("MMMM yyyy", new CultureInfo("es-ES")).ToUpper();

            for (int i = 0; i < diaSemana; i++)
            {
                ControlDia cd = new ControlDia();
                cd.SetDia(0, fechaActual);
                flpDias.Controls.Add(cd);
            }
            for (int dia = 1; dia <= diasEnMes; dia++)
            {
                ControlDia cd = new ControlDia();
                cd.SetDia(dia, fechaActual);
                flpDias.Controls.Add(cd);
            }
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            tbRecepcion.SelectedIndex = 0;
        }

        private async void btnCargarPacientes_Click(object sender, EventArgs e)
        {
            tbRecepcion.SelectedIndex = 1;
            // Corregido: Ahora se puede usar await porque CargarDatosDesdeApiAsync devuelve Task
            await CargarDatosDesdeApiAsync();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            tbRecepcion.SelectedIndex = 2;
        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            tbRecepcion.SelectedIndex = 3;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.Trim();
            DataTable dt = await gestorPacientes.BuscarPacientesAsync(searchText);
            if (dt != null)
            {
                dgvPacientes.DataSource = dt;
                EstiloDgvPacientes.AplicarEstilo(dgvPacientes);
            }
        }

        private async void bntEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                // La columna 'id' debe existir en el DataGridView
                int id = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["id"].Value);

                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro que deseas eliminar este paciente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = await gestorPacientes.EliminarPacientePorIdAsync(id);
                    if (eliminado)
                    {
                        MessageBox.Show("Paciente eliminado correctamente.", "Éxito");
                        await CargarDatosDesdeApiAsync();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el paciente.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvPacientes.Rows[e.RowIndex];

                txtNombrePaciente.Text = filaSeleccionada.Cells["pnombre"].Value?.ToString() ?? "";
                txtApellidoPaciente.Text = filaSeleccionada.Cells["papellido"].Value?.ToString() ?? "";
                // La API devuelve 'pdni' pero lo asignamos a txtDni
                txtDni.Text = filaSeleccionada.Cells["pdni"].Value?.ToString() ?? "";
                txtTelefonoPaciente.Text = filaSeleccionada.Cells["ptelefono"].Value?.ToString() ?? "";
                txtDireccionPaciente.Text = filaSeleccionada.Cells["pdireccion"].Value?.ToString() ?? "";
                txtMailPaciente.Text = filaSeleccionada.Cells["pmail"].Value?.ToString() ?? "";
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente
            {
                nombre = txtNombrePaciente.Text,
                apellido = txtApellidoPaciente.Text,
                direccion = txtDireccionPaciente.Text,
                telefono = txtTelefonoPaciente.Text,
                mail = txtMailPaciente.Text,
                // CORREGIDO: Usar 'dni' en minúsculas
                dni = txtDni.Text
            };

            if (!p.CamposVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool agregado = await gestorPacientes.AgregarPacienteAsync(p);
            if (agregado)
            {
                MessageBox.Show("Paciente agregado correctamente.", "Éxito");
                LimpiarCampos();
                await CargarDatosDesdeApiAsync();
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un paciente para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtiene el ID del paciente seleccionado
            int id = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["id"].Value);

            Paciente p = new Paciente
            {
                nombre = txtNombrePaciente.Text,
                apellido = txtApellidoPaciente.Text,
                direccion = txtDireccionPaciente.Text,
                telefono = txtTelefonoPaciente.Text,
                mail = txtMailPaciente.Text,
                // CORREGIDO: Usar 'dni' en minúsculas
                dni = txtDni.Text
            };

            if (!p.CamposVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro que deseas modificar este paciente?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                bool modificado = await gestorPacientes.ModificarPacienteAsync(id, p);
                if (modificado)
                {
                    MessageBox.Show("Paciente modificado correctamente.");
                    await CargarDatosDesdeApiAsync();
                    LimpiarCampos();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(-1);
            CargarDias();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(1);
            CargarDias();
        }
    }
}
