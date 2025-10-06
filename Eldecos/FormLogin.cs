using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net; // Necesario para EnsureSuccessStatusCode

namespace Eldecos
{
    // --- Modelos de comunicación con la API ---
    // Estructura de la petición que se envía a la API
    public class LoginRequest
    {
        public string nombre { get; set; }
        public string pass { get; set; }
    }

    // Estructura de la respuesta que se recibe de la API
    public class LoginResponse
    {
        // El rol es opcional en la respuesta si el login falla (401)
        public int rol { get; set; }
        public string message { get; set; }
        public string error { get; set; }
    }
    // --- Fin de Modelos ---


    public partial class FormLogin : Form
    {
        public FormMain MainForm { get; set; }
        private readonly HttpClient _httpClient;

        // Usamos la URL base del API de Render más el endpoint de login
        private const string ApiUrl = "https://api-eldecos.onrender.com/usuarios/login";

        public FormLogin()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string pass = txtPass.Text;

            // 1. Preparar la petición JSON
            var loginData = new LoginRequest { nombre = usuario, pass = pass };
            var jsonContent = JsonConvert.SerializeObject(loginData);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                // 2. Enviar la petición POST a la API
                var response = await _httpClient.PostAsync(ApiUrl, httpContent);
                var jsonResponse = await response.Content.ReadAsStringAsync();

                // 3. Deserializar la respuesta
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(jsonResponse);

                if (response.IsSuccessStatusCode)
                {
                    // Código 200 OK: Autenticación exitosa
                    if (loginResponse.rol == 2)
                    {
                        FormGestion siguiente = new FormGestion();
                        siguiente.MdiParent = MainForm;
                        siguiente.StartPosition = FormStartPosition.CenterParent;
                        siguiente.Show();
                        this.Close();
                    }
                    else
                    {
                        // Usuario autenticado, pero rol no autorizado
                        MessageBox.Show("Acceso denegado para este rol.", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    // Código 401 Unauthorized: Usuario o contraseña incorrectos
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Manejar otros errores 4xx o 5xx del servidor
                    string errorMessage = loginResponse?.error ?? loginResponse?.message ?? "Error desconocido del servidor.";
                    MessageBox.Show("Error en la conexión o el servidor: " + errorMessage, "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar contactar la API.\n" + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
