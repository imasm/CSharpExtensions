#region LICENSE

//    Copyright 2014 Ivan Masmità
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#endregion

using System;
using System.Drawing;
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


        /// <summary> Center control </summary>
        public static void CenterInParent(this Control control, Control parent)
        {
            int x = (parent.Width - control.Width) / 2;
            int y = (parent.Height - control.Height) / 2;

            control.Location = new Point(parent.Location.X + x, parent.Location.Y + y);
        }

        /// <summary> Center control </summary>
        public static void CenterInParent(this Control control)
        {
            if (control.Parent != null)
                CenterInParent(control, control.Parent);
        }
    }
}
