using System.Windows.Forms;
using System;

namespace MiProyecto.ControlesPersonalizados
{
    public class TabControlSinTabs : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328) // TCM_ADJUSTRECT
            {
                if (!DesignMode)
                {
                    m.Result = (IntPtr)1;
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}
