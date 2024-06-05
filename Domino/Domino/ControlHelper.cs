using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domino
{
    internal class ControlHelper
    {
        public static void SetControlText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.Text = text));
            }
            else
            {
                control.Text = text;
            }
        }

        public static void SetControlVisibility(Control control, bool isVisible)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => control.Visible = isVisible));
            }
            else
            {
                control.Visible = isVisible;
            }
        }
    }
}
