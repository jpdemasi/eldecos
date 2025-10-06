using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Eldecos
{
    public class GestorMedicos
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api-eldecos.onrender.com/medicos";

        public GestorMedicos()
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
                var medicos = JsonConvert.DeserializeObject<DataTable>(jsonResponse);

                return medicos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los médicos desde la API: " + ex.Message, "Error");
                return null;
            }
        }

        public async Task<DataTable> BuscarMedicosAsync(string searchText)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseUrl}/buscar?q={searchText}");
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var medicos = JsonConvert.DeserializeObject<DataTable>(jsonResponse);

                return medicos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar médicos en la API: " + ex.Message, "Error");
                return null;
            }
        }

        public async Task<bool> EliminarMedicoPorIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar médico en la API: " + ex.Message, "Error");
                return false;
            }
        }

        public async Task<bool> AgregarMedicoAsync(Medico m)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(m);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(BaseUrl, content);
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar médico a la API: " + ex.Message, "Error");
                return false;
            }
        }

        public async Task<bool> ModificarMedicoAsync(int id, Medico m)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(m);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{BaseUrl}/{id}", content);
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar médico en la API: " + ex.Message, "Error");
                return false;
            }
        }
    }
}
