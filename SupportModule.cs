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

        public static void MoveForm(MouseEventArgs e, Form form)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0xA1, 0x2, 0);
            }
        }

        #endregion MoveForm

        public static RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\T3Settings\T3pyRyster");
        public static RegistryKey AutoRunKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public static Color ColorOne;
        public static Color ColorTwo;
        public static FontFamily FontFam;
        public static Font AppFont;
        public static string FileName;
        public const string TXT = ".txt";
        public static int NumOfStrokes;
        public static bool NewFile = false;
        //Black - 0
        //Gray - 1
        //White - 2
        //Yellow - 3
        //Orange - 4
        //Red - 5
        //Green - 6
        //Blue - 7
        //Pink - 8
        //Violet - 9
        public static void UpdateTheme()
        {
            switch (Key.GetValue("ColorOne"))
            {
                case 0:
                    ColorOne = Color.Black;
                    break;
                case 1:
                    ColorOne = Color.Gray;
                    break;
                case 2:
                    ColorOne = Color.White;
                    break;
                case 3:
                    ColorOne = Color.Yellow;
                    break;
                case 4:
                    ColorOne = Color.Orange;
                    break;
                case 5:
                    ColorOne = Color.Red;
                    break;
                case 6:
                    ColorOne = Color.Green;
                    break;
                case 7:
                    ColorOne = Color.Blue;
                    break;
                case 8:
                    ColorOne = Color.Pink;
                    break;
                case 9:
                    ColorOne = Color.Violet;
                    break;
                case null:
                    break;
            }
            switch (Key.GetValue("ColorTwo"))
            {
                case 0:
                    ColorTwo = Color.Black;
                    break;
                case 1:
                    ColorTwo = Color.Gray;
                    break;
                case 2:
                    ColorTwo = Color.White;
                    break;
                case 3:
                    ColorTwo = Color.Yellow;
                    break;
                case 4:
                    ColorTwo = Color.Orange;
                    break;
                case 5:
                    ColorTwo = Color.Red;
                    break;
                case 6:
                    ColorTwo = Color.Green;
                    break;
                case 7:
                    ColorTwo = Color.Blue;
                    break;
                case 8:
                    ColorTwo = Color.Pink;
                    break;
                case 9:
                    ColorTwo = Color.Violet;
                    break;
                case null:
                    break;
            }
            switch (Key.GetValue("Font"))
            {
                case 0:
                    FontFam = new FontFamily("Arial");
                    break;
                case 1:
                    FontFam = new FontFamily("Calibri");
                    break;
                case 2:
                    FontFam = new FontFamily(System.Drawing.Text.GenericFontFamilies.SansSerif);
                    break;
                case null:
                    break;
            }
            AppFont = new Font(FontFam, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            FileName = Key.GetValue("FileName").ToString();
            NumOfStrokes = (Int32)Key.GetValue("NumOfStrokes");
        }
        public static void CheckOnMiss()
        {
            if (Key.GetValue("ColorOne") == null)
            {
                Key.CreateSubKey("ColorOne");
                Key.SetValue("ColorOne", 0);
            }
            if (Key.GetValue("ColorTwo") == null)
            {
                Key.CreateSubKey("ColorTwo");
                Key.SetValue("ColorTwo", 2);
            }
            if (Key.GetValue("Font") == null)
            {
                Key.CreateSubKey("Font");
                Key.SetValue("Font", 0);
            }
            if (Key.GetValue("datahere") == null)
            {
                Key.CreateSubKey("datahere");
                Key.SetValue("datahere", "data\\");
            }
            if (Key.GetValue("FileName") == null)
            {
                Key.CreateSubKey("FileName");
                Key.SetValue("FileName", "File");
            }
            if (Key.GetValue("NumOfStrokes") == null)
            {
                Key.CreateSubKey("NumOfStrokes");
                Key.SetValue("NumOfStrokes", 10);
            }
            if (!Directory.Exists(Key.GetValue("datahere").ToString()))
            {
                Directory.CreateDirectory(Key.GetValue("datahere").ToString());
            }
            for (int i = 0; i < (Int32)Key.GetValue("NumOfStrokes"); i++)
            {
                if (!File.Exists(Key.GetValue("datahere").ToString() + Key.GetValue("FileName").ToString() + i.ToString() + TXT))
                {
                    File.Create(Key.GetValue("datahere").ToString() + Key.GetValue("FileName").ToString() + i.ToString() + TXT);
                }
            }
        }
        public static void CopyMe(TextBox textBox)
        {
            if (textBox.Text != "")
            { Clipboard.SetText(textBox.Text); }
        }
        public static string GetValue(int id)
        {
            if (id < NumOfStrokes && id >= 0)
            {
                return File.ReadAllText(Key.GetValue("datahere").ToString() + Key.GetValue("FileName").ToString() + id + TXT);
            }
            else
            {
                return null;
            }
        }
        public static void SetValue(int id, string value)
        {
            if (id < NumOfStrokes && id >= 0)
            {
                File.WriteAllText(Key.GetValue("datahere").ToString() + Key.GetValue("FileName").ToString() + id + TXT, value);
            }
        }
    }
}