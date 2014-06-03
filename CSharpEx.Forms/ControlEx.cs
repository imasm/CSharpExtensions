using System;
using System.Windows.Forms;

namespace CSharpEx.Forms
{
    public static class ControlEx
    {
        /// <summary>
        /// Invoke action if Invoke is requiered.
        /// </summary>
        public static void InvokeIfRequired<T>(this T c, Action<T> action) where T : Control
        {
            if (c.InvokeRequired)
            {
                c.Invoke(new Action(() => action(c)));
            }
            else
            {
                action(c);
            }
        }
    }
}
