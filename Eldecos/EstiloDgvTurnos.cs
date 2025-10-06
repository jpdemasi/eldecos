using System.Drawing;
using System.Windows.Forms;

namespace Eldecos
{
    public static class EstiloDgvTurnos
    {
        public static void AplicarEstilo(DataGridView dgv)
        {
            // Ocultar columnas que no son relevantes para el usuario
            if (dgv.Columns.Contains("id"))
            {
                dgv.Columns["id"].Visible = false;
            }
            if (dgv.Columns.Contains("medico_id"))
            {
                dgv.Columns["medico_id"].Visible = false;
            }
            if (dgv.Columns.Contains("paciente_id"))
            {
                dgv.Columns["paciente_id"].Visible = false;
            }

            // Opcional: Renombrar encabezados de columnas
            if (dgv.Columns.Contains("fecha"))
            {
                dgv.Columns["fecha"].HeaderText = "Fecha";
            }
            if (dgv.Columns.Contains("hora"))
            {
                dgv.Columns["hora"].HeaderText = "Hora";
            }
            // Agrega más columnas según tu modelo de datos si es necesario
            // Por ejemplo, para mostrar el nombre del paciente y médico
            // dgv.Columns["paciente_nombre"].HeaderText = "Paciente";
            // dgv.Columns["medico_nombre"].HeaderText = "Médico";

            // Configurar el estilo del DataGridView
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo de las filas
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
        }
    }
}