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
using System.Net;
using System.Globalization;


namespace Eldecos
{

    public partial class FormGestion : Form
    {

        private GestorPacientes gestorPacientes;
        private DateTime fechaActual;
        public FormGestion()
        {
            InitializeComponent();
            fechaActual = DateTime.Now;
            CargarDias();

            gestorPacientes = new GestorPacientes();

            //Me aseguro que el evento se asocie al DGV.
            dgvPacientes.CellClick += dgvPacientes_CellClick;



            string pnombre = txtNombrePaciente.Text;
            string papellido = txtApellidoPaciente.Text;
            string pdireccion = txtDireccionPaciente.Text;
            string ptelefono = txtTelefonoPaciente.Text;
            string pmail = txtMailPaciente.Text;
            string pdni = txtDni.Text;

            try
            {
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

                tbRecepcion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                cd.SetDia(0, fechaActual); // Aunque no se use, mantenemos la firma
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente
            {
                nombre = txtNombrePaciente.Text,
                apellido = txtApellidoPaciente.Text,
                direccion = txtDireccionPaciente.Text,
                telefono = txtTelefonoPaciente.Text,
                mail = txtMailPaciente.Text,
                DNI = txtDni.Text
            };

            if (!p.CamposVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conexion = ConexionSQLite.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO pacientes (pnombre, papellido, pdireccion, ptelefono, pmail, pdni) " +
                                   "VALUES (@nombre, @apellido, @direccion, @telefono, @mail, @dni)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", p.nombre);
                    cmd.Parameters.AddWithValue("@apellido", p.apellido);
                    cmd.Parameters.AddWithValue("@direccion", p.direccion);
                    cmd.Parameters.AddWithValue("@telefono", p.telefono);
                    cmd.Parameters.AddWithValue("@mail", p.mail);
                    cmd.Parameters.AddWithValue("@dni", p.DNI);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Paciente agregado correctamente.", "Éxito");
                    LimpiarCampos();

                    dgvPacientes.DataSource = gestorPacientes.CargarDatos();
                    EstiloDgvPacientes.AplicarEstilo(dgvPacientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar paciente: " + ex.Message, "Error");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                DNI = txtDni.Text
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
                try
                {
                    using (var conexion = ConexionSQLite.ObtenerConexion())
                    {
                        conexion.Open();
                        string query = "UPDATE pacientes SET pnombre = @nombre, papellido = @apellido, pdireccion = @direccion, " +
                                       "ptelefono = @telefono, pmail = @mail, pdni = @dni WHERE id = @id";

                        SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nombre", p.nombre);
                        cmd.Parameters.AddWithValue("@apellido", p.apellido);
                        cmd.Parameters.AddWithValue("@direccion", p.direccion);
                        cmd.Parameters.AddWithValue("@telefono", p.telefono);
                        cmd.Parameters.AddWithValue("@mail", p.mail);
                        cmd.Parameters.AddWithValue("@dni", p.DNI);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Paciente modificado correctamente.");
                            dgvPacientes.DataSource = gestorPacientes.CargarDatos();
                            EstiloDgvPacientes.AplicarEstilo(dgvPacientes);
                            LimpiarCampos();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar paciente: " + ex.Message, "Error");
                    dgvPacientes.DataSource = gestorPacientes.CargarDatos();
                    EstiloDgvPacientes.AplicarEstilo(dgvPacientes);
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
    
