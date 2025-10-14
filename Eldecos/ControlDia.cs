using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eldecos
{
    public partial class ControlDia : UserControl
    {
        public DateTime Fecha { get; private set; }
        private int cantidadTurnos;

        public ControlDia()
        {
            InitializeComponent();
            // Suscribe el evento Click una sola vez en el constructor.
            this.Click += ControlDia_Click;
            foreach (Control c in this.Controls)
            {
                c.Click += ControlDia_Click;
            }
        }

        public void SetDia(int dia, DateTime fechaBase, int turnosDelDia)
        {
            this.cantidadTurnos = turnosDelDia;

            if (dia == 0)
            {
                this.Visible = false;
                return;
            }

            Fecha = new DateTime(fechaBase.Year, fechaBase.Month, dia);
            lblDia.Text = dia.ToString();
            this.Visible = true;

            if (turnosDelDia > 0)
            {
                this.BackColor = Color.FromArgb(173, 216, 230); // Azul claro: hay turnos
            }
            else
            {
                this.BackColor = Color.FromArgb(220, 220, 220); // Gris claro: sin turnos
            }
        }

        private void ControlDia_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // 1. Mostrar la fecha seleccionada para depuración.
                MessageBox.Show($"Día seleccionado: {this.Fecha.ToShortDateString()}", "Día Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 2. Validar si el día es sábado o domingo.
                if (Fecha.DayOfWeek == DayOfWeek.Saturday || Fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("No se pueden agendar turnos los sábados ni los domingos.", "Día no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución para no abrir el formulario.
                }

                // 3. Si es un día hábil, se procede a abrir el formulario de turnos.
                FormTurnosDelDia formTurnos = new FormTurnosDelDia(Fecha);
                formTurnos.ShowDialog();
            }
        }
    }
}