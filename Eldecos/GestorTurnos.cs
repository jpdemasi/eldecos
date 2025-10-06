using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Eldecos
{
    public class GestorTurnos
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api-eldecos.onrender.com/turnos";

        public GestorTurnos()
        {
            _httpClient = new HttpClient();
        }

        public async Task<DataTable> ObtenerTurnosPorFechaAsync(string fecha)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseUrl}?fecha={fecha}");
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var turnos = JsonConvert.DeserializeObject<DataTable>(jsonResponse);
                return turnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los turnos: " + ex.Message, "Error");
                return null;
            }
        }

        // Nuevo método para obtener turnos en un rango de fechas
        public async Task<DataTable> ObtenerTurnosPorRangoAsync(string fechaInicio, string fechaFin)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseUrl}?fecha_inicio={fechaInicio}&fecha_fin={fechaFin}");
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var turnos = JsonConvert.DeserializeObject<DataTable>(jsonResponse);
                return turnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los turnos por rango: " + ex.Message, "Error");
                return null;
            }
        }

        public async Task<bool> AgregarTurnoAsync(Turno turno)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(turno);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(BaseUrl, content);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el turno: " + ex.Message, "Error");
                return false;
            }
        }

        public async Task<bool> ModificarTurnoAsync(int id, Turno turno)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(turno);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{BaseUrl}/{id}", content);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el turno en la API: " + ex.Message, "Error");
                return false;
            }
        }

        public async Task<bool> EliminarTurnoAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el turno en la API: " + ex.Message, "Error");
                return false;
            }
        }
    }
}