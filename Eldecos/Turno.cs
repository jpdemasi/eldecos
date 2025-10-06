using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldecos
{
    public class Turno
    {
        public int id { get; set; }
        public int medico_id { get; set; }
        public int paciente_id { get; set; }
        public string fecha { get; set; } // Formato 'YYYY-MM-DD'
        public string hora { get; set; }  // Formato 'HH:mm'
    }
}
