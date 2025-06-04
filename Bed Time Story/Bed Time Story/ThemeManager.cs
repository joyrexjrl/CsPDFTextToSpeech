using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bed_Time_Story
{
    public static class ThemeManager
    {
        public static bool IsDarkMode { get; private set; } = false;

        public static void SetDarkMode(bool enable) => IsDarkMode = enable;

        public static void ApplyTheme(Control control)
        {
            if (IsDarkMode) EnableDarkMode(control);
            else EnableLightMode(control);
        }

        private static void EnableDarkMode(Control control)
        {
            control.BackColor = Color.FromArgb(30, 30, 30);
            control.ForeColor = Color.White;
            foreach (Control child in control.Controls) EnableDarkMode(child);
        }

        private static void EnableLightMode(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;
            foreach (Control child in control.Controls) EnableLightMode(child);
        }
    }
}
