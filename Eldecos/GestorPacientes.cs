using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Eldecos
{
    public class GestorPacientes
    {
        public DataTable CargarDatos()
        {
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
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error");
                return null;
            }
        }

        public DataTable BuscarPacientes(string searchText)
        {
            try
            {
                using (var conexion = ConexionSQLite.ObtenerConexion())
                {
                    conexion.Open();

                    // Usamos parámetros para evitar inyección SQL
                    string query = "SELECT * FROM pacientes WHERE LOWER(pnombre) LIKE @searchText OR LOWER(papellido) LIKE @searchText OR LOWER(pdni) LIKE @searchText";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los datos: " + ex.Message, "Error");
                return null;
            }
        }

        public bool EliminarPacientePorId(int id)
        {
            try
            {
                using (var conexion = ConexionSQLite.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM pacientes WHERE id = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el paciente: " + ex.Message, "Error");
                return false;
            }
        }

    }
}