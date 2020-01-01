using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Supply
{
    internal class SupportModule
    {
        #region MoveForm

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void MoveForm(object sender, MouseEventArgs e, Form form)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0xA1, 0x2, 0);
            }
        }

        #endregion MoveForm

        public static RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\T3Settings\T3pyRyster");
        public static Color ColorOne;
        public static Color ColorTwo;

        public static void LoadThemeThatNow()
        {
            if (Key.GetValue("Theme") == null)
            {
                Key.CreateSubKey("Theme");
                Key.SetValue("Theme", "0");
            }
            if (Key.GetValue("Theme").ToString() == "0")
            {
                ColorOne = Color.Black;
                ColorTwo = Color.White;
            }
            else
            {
                ColorOne = Color.White;
                ColorTwo = Color.Black;
            }
        }

        public static void CopyMe(TextBox textBox)
        {
            if (textBox.Text != "")
            { Clipboard.SetText(textBox.Text); }
        }

        public static object Load()
        {
            string Data = "datahere";
            string SettingsNow = "data\\SettingsNow";
            string TXT = ".txt";
            if (Key.GetValue(Data) == null)
            {
                Key.CreateSubKey(Data);
                for (int i = 1; i < 11; i++)
                {
                    if (!File.Exists(SettingsNow + i.ToString() + TXT))
                    {
                        Directory.CreateDirectory("data");
                        File.CreateText(SettingsNow + i.ToString() + TXT);
                    }
                }
                Key.SetValue(Data, SettingsNow);
            }
            return Key.GetValue(Data);
        }

        public static string GetValue(int id)
        {
            if (id == 0 || id > 10)
            {
                return null;
            }
            else
            {
                return File.ReadAllText(Load().ToString() + id.ToString() + ".txt");
            }
        }

        public static void SetValue(int id, string value)
        {
            if (id != 0 && id <= 10)
            {
                File.WriteAllText(Load().ToString() + id.ToString() + ".txt", value);
            }
        }
    }
}