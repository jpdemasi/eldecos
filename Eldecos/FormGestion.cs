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
    public partial class FormGestion : Form
    {
        private GestorPacientes gestorPacientes;
        private GestorMedicos gestorMedicos;
        private GestorTurnos gestorTurnos;
        private DateTime fechaActual;

        public FormGestion()
        {
            InitializeComponent();
            fechaActual = DateTime.Now;

            // 1. Inicializa todos los gestores primero.
            gestorPacientes = new GestorPacientes();
            gestorMedicos = new GestorMedicos();
            gestorTurnos = new GestorTurnos();

            dgvPacientes.CellClick += dgvPacientes_CellClick;

            // 2. Ahora, puedes llamar a los métodos que usan los gestores.
            CargarDatosDesdeApiAsync();
            CargarDias();

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

        }

        private async void CargarDias()
        {
            flpDias.Controls.Clear();
            DateTime primerDia = new DateTime(fechaActual.Year, fechaActual.Month, 1);
            int diasEnMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);
            int diaSemana = (int)primerDia.DayOfWeek;
            diaSemana = diaSemana == 0 ? 6 : diaSemana - 1;

            lblMes.Text = fechaActual.ToString("MMMM yyyy", new CultureInfo("es-ES")).ToUpper();

            // NUEVA LÓGICA: Carga todos los turnos del mes en una sola llamada.
            DateTime ultimoDia = new DateTime(fechaActual.Year, fechaActual.Month, diasEnMes);
            DataTable turnosDelMes = await gestorTurnos.ObtenerTurnosPorRangoAsync(
                primerDia.ToString("yyyy-MM-dd"), ultimoDia.ToString("yyyy-MM-dd")
            );

            // Crea un diccionario para contar los turnos por día.
            var turnosPorDia = new Dictionary<int, int>();
            if (turnosDelMes != null)
            {
                foreach (DataRow row in turnosDelMes.Rows)
                {
                    if (DateTime.TryParse(row["fecha"].ToString(), out DateTime fechaTurno))
                    {
                        int dia = fechaTurno.Day;
                        if (turnosPorDia.ContainsKey(dia))
                        {
                            turnosPorDia[dia]++;
                        }
                        else
                        {
                            turnosPorDia[dia] = 1;
                        }
                    }
                }
            }

            for (int i = 0; i < diaSemana; i++)
            {
                ControlDia cd = new ControlDia();
                cd.SetDia(0, fechaActual, 0);
                flpDias.Controls.Add(cd);
            }

            for (int dia = 1; dia <= diasEnMes; dia++)
            {
                ControlDia cd = new ControlDia();
                int cantidadTurnos = turnosPorDia.ContainsKey(dia) ? turnosPorDia[dia] : 0;
                cd.SetDia(dia, fechaActual, cantidadTurnos);
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

            int id = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["id"].Value);

            Paciente p = new Paciente
            {
                nombre = txtNombrePaciente.Text,
                apellido = txtApellidoPaciente.Text,
                direccion = txtDireccionPaciente.Text,
                telefono = txtTelefonoPaciente.Text,
                mail = txtMailPaciente.Text,
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