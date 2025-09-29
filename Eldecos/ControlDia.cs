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

        public void SetDia(int dia, DateTime fechaBase)
        {


            if (dia == 0)
            {
                this.Visible = false;
                return;
            }

            Fecha = new DateTime(fechaBase.Year, fechaBase.Month, dia);
            lblDia.Text = dia.ToString();

            this.Click += ControlDia_Click;
            foreach (Control c in this.Controls)
            {
                c.Click += ControlDia_Click;
            }

            lblDia.Click += ControlDia_Click;



        }

        public ControlDia()
        {
            InitializeComponent(); 
        }

        private void ControlDia_Click(object sender, EventArgs e)
        {
            FormTurno formTurno = new FormTurno(Fecha);
            formTurno.ShowDialog();
        }
    }

}
