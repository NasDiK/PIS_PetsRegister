using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApplication.Utils
{
    static internal class Utils
    {
        internal static void Notify(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK);
        }

        internal static bool Confirm (string text, string caption) =>
            MessageBox.Show(text, caption, MessageBoxButtons.YesNo) == DialogResult.OK;
    }
}
