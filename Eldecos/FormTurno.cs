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
    public partial class FormTurno : Form
    {
        private DateTime fecha;

        public FormTurno(DateTime fechaSeleccionada)
        {
            InitializeComponent();
            fecha = fechaSeleccionada;
            lblFecha.Text = fecha.ToShortDateString(); // Mostrar la fecha
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string paciente = txtBusquedaPaciente.Text;
            string medico = txtBusquedaMedico.Text;
            string hora = cmbHora.SelectedItem.ToString();

            // Aquí podés guardar el turno en tu base de datos o lista
            MessageBox.Show($"Turno asignado:\nPaciente: {paciente}\nMédico: {medico}\nHora: {hora}");
            this.Close();
        }

        private void btnSalirTurno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Código para arrastrar la ventana.
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HT_CAPTION;
                return;
            }
            base.WndProc(ref m);
        }

    }

}
