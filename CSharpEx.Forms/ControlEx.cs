using System;
using System.Windows.Forms;

namespace CSharpEx.Forms
{
    /// <summary>
    /// Control extensions
    /// </summary>
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

        /// <summary>
        /// Set DoubleBuffered property using reflection.
        /// Call this in the constructor just after InitializeComponent().
        /// </summary>
        public static void SetDoubleBuffered(this Control control, bool enabled)
        {
            typeof (Control).InvokeMember("DoubleBuffered",
                                          System.Reflection.BindingFlags.SetProperty |
                                          System.Reflection.BindingFlags.Instance |
                                          System.Reflection.BindingFlags.NonPublic,
                                          null,
                                          control,
                                          new object[] {enabled});
        }
    }
}
