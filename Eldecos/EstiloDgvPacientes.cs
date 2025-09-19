using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eldecos
{
    internal class EstiloDgvPacientes
    {
        public static void AplicarEstilo(DataGridView dgvPacientes)
        {
            // Ocultar la columna 'id' que no es relevante para el usuario
            dgvPacientes.Columns["id"].Visible = false;

            // Cambiar los nombres de las columnas para que sean más legibles
            dgvPacientes.Columns["pnombre"].HeaderText = "Nombre";
            dgvPacientes.Columns["papellido"].HeaderText = "Apellido";
            dgvPacientes.Columns["pdireccion"].HeaderText = "Dirección";
            dgvPacientes.Columns["ptelefono"].HeaderText = "Teléfono";
            dgvPacientes.Columns["pdni"].HeaderText = "DNI";
            dgvPacientes.Columns["pmail"].HeaderText = "E-Mail";

            //Elegimos un campo entero y evitamos que se haga un seleccion multiple.
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.MultiSelect = false;

            // Aseguramos que las columnas se ajusten automáticamente al contenido
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilos visuales.
            dgvPacientes.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            dgvPacientes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            dgvPacientes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
        }
    }
}
