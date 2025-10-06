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
                if (cantidadTurnos > 0)
                {
                    // Se crea una instancia del nuevo formulario, pasándole la fecha.
                    FormTurnosDelDia formTurnos = new FormTurnosDelDia(Fecha);
                    formTurnos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay turnos agendados para este día.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}