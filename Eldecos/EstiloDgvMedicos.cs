using System;
using System.Windows.Forms;

namespace Eldecos
{
    internal class EstiloDgvMedicos
    {
        public static void AplicarEstilo(DataGridView dgvMedicos)
        {
            
            dgvMedicos.Columns["id"].Visible = false;

            
            dgvMedicos.Columns["nombre"].HeaderText = "Nombre";
            dgvMedicos.Columns["apellido"].HeaderText = "Apellido";
            dgvMedicos.Columns["dni"].HeaderText = "DNI";
            dgvMedicos.Columns["matricula"].HeaderText = "Matrícula";
            dgvMedicos.Columns["especialidad"].HeaderText = "Especialidad";
            dgvMedicos.Columns["telefono"].HeaderText = "Teléfono";
            dgvMedicos.Columns["email"].HeaderText = "E-Mail";
            dgvMedicos.Columns["estado"].HeaderText = "Estado"; // ← agregado

            // Selección de fila completa y sin selección múltiple
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.MultiSelect = false;

            // Ajuste automático de columnas
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilos visuales
            dgvMedicos.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
            dgvMedicos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvMedicos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
        }
    }
}
