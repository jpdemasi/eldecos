    using System;
    using System.Data;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Newtonsoft.Json;

    namespace Eldecos
    {
        public class GestorPacientes
        {
            private readonly HttpClient _httpClient;
            private const string BaseUrl = "https://api-eldecos.onrender.com/pacientes";

            public GestorPacientes()
            {
                _httpClient = new HttpClient();
            }

            public async Task<DataTable> CargarDatosAsync()
            {
                try
                {
                    var response = await _httpClient.GetAsync(BaseUrl);
                    response.EnsureSuccessStatusCode();

                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var pacientes = JsonConvert.DeserializeObject<DataTable>(jsonResponse);

                    return pacientes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos desde la API: " + ex.Message, "Error");
                    return null;
                }
            }

            public async Task<DataTable> BuscarPacientesAsync(string searchText)
            {
                try
                {
                    var response = await _httpClient.GetAsync($"{BaseUrl}/buscar?q={searchText}");
                    response.EnsureSuccessStatusCode();

                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var pacientes = JsonConvert.DeserializeObject<DataTable>(jsonResponse);

                    return pacientes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar los datos en la API: " + ex.Message, "Error");
                    return null;
                }
            }

            public async Task<bool> EliminarPacientePorIdAsync(int id)
            {
                try
                {
                    var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
                    response.EnsureSuccessStatusCode();

                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el paciente en la API: " + ex.Message, "Error");
                    return false;
                }
            }

            public async Task<bool> AgregarPacienteAsync(Paciente p)
            {
                try
                {
                    var jsonContent = JsonConvert.SerializeObject(p);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var response = await _httpClient.PostAsync(BaseUrl, content);
                    response.EnsureSuccessStatusCode();

                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar paciente a la API: " + ex.Message, "Error");
                    return false;
                }
            }

            public async Task<bool> ModificarPacienteAsync(int id, Paciente p)
            {
                try
                {
                    var jsonContent = JsonConvert.SerializeObject(p);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var response = await _httpClient.PutAsync($"{BaseUrl}/{id}", content);
                    response.EnsureSuccessStatusCode();

                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar paciente en la API: " + ex.Message, "Error");
                    return false;
                }
            }
        }
    }