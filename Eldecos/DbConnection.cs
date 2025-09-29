using System;
using System.Data.SQLite;
using System.IO;

public static class ConexionSQLite
{
    private static string cadena;

    static ConexionSQLite()
    {
        // Obtiene la ruta donde se ejecuta el programa
        string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
        string rutaDb = Path.Combine(rutaBase, "eldecos.db");

        cadena = $"Data Source={rutaDb};Version=3;";
    }

    public static SQLiteConnection ObtenerConexion()
    {
        var conexion = new SQLiteConnection(cadena);

    

        return conexion;
    }
}
