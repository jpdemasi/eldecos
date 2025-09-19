using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiProyecto.ControlesPersonalizados;
using System.Data.SQLite;


namespace Eldecos
{
    public partial class FormGestion : Form
    {
        private GestorPacientes gestorPacientes;
        public FormGestion()
        {
            InitializeComponent();

            gestorPacientes = new GestorPacientes();

            // Ocultar pestañas al iniciar
            // tbRecepcion.Parent = null;
            // Si tienes `using Eldecos.ControlesPersonalizados;` al principio
            // this.tbRecepcion = new TabControlSinTabs();


            string pnombre = txtNombrePaciente.Text;
            string papellido = txtApellidoPaciente.Text;
            string pdireccion = txtDireccionPaciente.Text;
            string ptelefono = txtTelefonoPaciente.Text;
            string pmail = txtMailPaciente.Text;
            string pdni = txtDni.Text;

            using (var conexion = ConexionSQLite.ObtenerConexion())

            {
                conexion.Open();
                string query = "SELECT * FROM pacientes";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                SQLiteDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvPacientes.DataSource = dt;

                EstiloDgvPacientes.AplicarEstilo(dgvPacientes);



            }
            tbRecepcion.SelectedIndex = 1;


        }


        private void FormGestion_Load(object sender, EventArgs e)
        {


        }


        private void btnTurnos_Click(object sender, EventArgs e)
        {
            tbRecepcion.SelectedIndex = 0;
        }

        private void btnCargarPacientes_Click(object sender, EventArgs e)
        {
            tbRecepcion.SelectedIndex = 1;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.Trim();

            // Llamamos al método de búsqueda usando el objeto 'gestorPacientes'
            DataTable dt = gestorPacientes.BuscarPacientes(searchText);
            if (dt != null)
            {
                dgvPacientes.DataSource = dt;
                EstiloDgvPacientes.AplicarEstilo(dgvPacientes);

            }
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                // Cargamos el ID de la columna para eliminar los registros.
                int id = Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells["id"].Value);

                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro que deseas eliminar este paciente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = gestorPacientes.EliminarPacientePorId(id);
                    if (eliminado)
                    {
                        MessageBox.Show("Paciente eliminado correctamente.", "Éxito");
                        dgvPacientes.DataSource = gestorPacientes.CargarDatos();
                        EstiloDgvPacientes.AplicarEstilo(dgvPacientes);
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
            DataGridViewRow filaSeleccionada = dgvPacientes.SelectedRows[0];

            txtNombrePaciente.Text = filaSeleccionada.Cells["pnombre"].Value.ToString();
            txtApellidoPaciente.Text = filaSeleccionada.Cells["papellido"].Value.ToString();
            txtDni.Text = filaSeleccionada.Cells["pdni"].Value.ToString();
            txtTelefonoPaciente.Text = filaSeleccionada.Cells["ptelefono"].Value.ToString();
            txtDireccionPaciente.Text = filaSeleccionada.Cells["pdireccion"].Value.ToString();
            txtMailPaciente.Text = filaSeleccionada.Cells["pmail"].Value.ToString();
        }
    }
}
