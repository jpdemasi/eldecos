using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Eldecos
{
    public partial class FormLogin : Form
    {
        // Propiedad pública para recibir el MDI padre
        public FormMain MainForm { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string pass = txtPass.Text;
            int rol = -1;

            try
            {
                using (var conexion = ConexionSQLite.ObtenerConexion())
                {
                    conexion.Open();
                    // Consulta para obtener el rol del usuario si las credenciales son correctas
                    string query = "SELECT rol FROM usuarios WHERE nombre = @nombre AND pass = @pass";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", usuario);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        rol = Convert.ToInt32(resultado);

                        if (rol == 2)
                        {
                            FormGestion siguiente = new FormGestion();
                            siguiente.MdiParent = MainForm;
                            siguiente.StartPosition = FormStartPosition.CenterParent;
                            siguiente.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Acceso denegado para este rol.", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al conectar con la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Opcional: Verificar conexión al iniciar
            /*
            try
            {
                using (var conexion = ConexionSQLite.ObtenerConexion())
                {
                    MessageBox.Show("Conexión exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
            */
        }
    }
}
