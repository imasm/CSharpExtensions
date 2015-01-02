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

using System.Windows.Forms;

namespace CSharpEx.Forms
{
    /// <summary> Message box helper class</summary>
    public static class MessageBoxEx
    {
        public static readonly MessageBoxIcon ErrorIcon = MessageBoxIcon.Warning;

        public static void Show(string text)
        {
            MessageBox.Show(text);
        }

        public static void Show(string text, string caption)
        {
            MessageBox.Show(text, caption);
        }


        public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
                                MessageBoxDefaultButton defaultButton)
        {
            MessageBox.Show(
                text,
                caption,
                buttons,
                icon,
                defaultButton);
        }


        public static void Show(string text, string caption, MessageBoxButtons buttons)
        {
            MessageBox.Show(text, caption, buttons);
        }

        public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(text, caption, buttons, icon);
        }

        public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,
                                MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        {
            MessageBox.Show(text, caption, buttons, icon, defaultButton, options);
        }

        public static void ShowError(string text)
        {
            ShowError(text, "Error");
        }

        public static void ShowError(string text, string caption)
        {
            Show(
                text,
                caption,
                MessageBoxButtons.OK,
                ErrorIcon,
                MessageBoxDefaultButton.Button1);
        }

        public static bool Ask(string question, string caption)
        {
            return
                MessageBox.Show(
                    question,
                    caption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes;
        }

        public static bool AskAlert(string question, string caption)
        {
            return
                MessageBox.Show(
                    question,
                    caption,
                    MessageBoxButtons.YesNo,
                    ErrorIcon,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes;
        }
    }
}