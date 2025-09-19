using System;
using System.Windows.Forms;


namespace Eldecos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Habilita el modo MDI
            this.Load += new EventHandler(FormMain_Load); // Conecta el evento Load
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.MdiParent = this;
            login.MainForm = this; // Le pasás la referencia al MDI padre
            login.StartPosition = FormStartPosition.CenterParent;
            login.Show();
        }
    }
}