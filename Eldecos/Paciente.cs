using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Eldecos
{
    internal class Paciente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public string DNI { get; set; }

        public bool CamposVacios()
        {
            return !string.IsNullOrWhiteSpace(nombre) &&
                   !string.IsNullOrWhiteSpace(apellido) &&
                   !string.IsNullOrWhiteSpace(direccion) &&
                   !string.IsNullOrWhiteSpace(telefono) &&
                   !string.IsNullOrWhiteSpace(mail) &&
                   !string.IsNullOrWhiteSpace(DNI);
        }


    }

    }
