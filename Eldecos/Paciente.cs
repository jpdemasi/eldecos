using System;
using System.Linq;

namespace Eldecos
{
    // Hacemos la clase pública para que sea accesible por la clase GestorPacientes.
    public class Paciente
    {
        // Propiedades del paciente. Nota: 'dni' está en minúsculas para coincidir con la API de Node.js.
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public string dni { get; set; }

        /// <summary>
        /// Verifica si todos los campos requeridos tienen contenido (no nulo ni espacios en blanco).
        /// Devuelve TRUE si NINGÚN campo está vacío.
        /// </summary>
        public bool CamposVacios()
        {
            return !string.IsNullOrWhiteSpace(nombre) &&
                   !string.IsNullOrWhiteSpace(apellido) &&
                   !string.IsNullOrWhiteSpace(direccion) &&
                   !string.IsNullOrWhiteSpace(telefono) &&
                   !string.IsNullOrWhiteSpace(mail) &&
                   !string.IsNullOrWhiteSpace(dni);
        }
    }
}
