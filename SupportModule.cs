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
        public static bool ShiftMod = false, CtrlMod = false, AltMod = false, WinMod = false;
        public static Keys Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9, Key10;

        #region Colors

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

        #endregion Colors

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

        public static void UpdateHotkeys()
        {
            if (Key.GetValue("ShiftMod").ToString() == "1")
            {
                ShiftMod = true;
            }
            if (Key.GetValue("CtrlMod").ToString() == "1")
            {
                CtrlMod = true;
            }
            if (Key.GetValue("AltMod").ToString() == "1")
            {
                AltMod = true;
            }

            Key1 = T3pyRYster.Settings.Default.Key1;
            Key2 = T3pyRYster.Settings.Default.Key2;
            Key3 = T3pyRYster.Settings.Default.Key3;
            Key4 = T3pyRYster.Settings.Default.Key4;
            Key5 = T3pyRYster.Settings.Default.Key5;
            Key6 = T3pyRYster.Settings.Default.Key6;
            Key7 = T3pyRYster.Settings.Default.Key7;
            Key8 = T3pyRYster.Settings.Default.Key8;
            Key9 = T3pyRYster.Settings.Default.Key9;
            Key10 = T3pyRYster.Settings.Default.Key10;
        }
        public static Keys KeySelector(string name)
        {
            Keys SelectedKey = Keys.None;
            switch (name)
            {
                case "A":
                    SelectedKey = Keys.A;
                    break;
                case "B":
                    SelectedKey = Keys.B;
                    break;
                case "C":
                    SelectedKey = Keys.C;
                    break;
                case "D":
                    SelectedKey = Keys.D;
                    break;
                case "E":
                    SelectedKey = Keys.E;
                    break;
                case "F":
                    SelectedKey = Keys.F;
                    break;
                case "G":
                    SelectedKey = Keys.G;
                    break;
                case "H":
                    SelectedKey = Keys.H;
                    break;
                case "I":
                    SelectedKey = Keys.I;
                    break;
                case "J":
                    SelectedKey = Keys.J;
                    break;
                case "K":
                    SelectedKey = Keys.K;
                    break;
                case "L":
                    SelectedKey = Keys.L;
                    break;
                case "M":
                    SelectedKey = Keys.M;
                    break;
                case "N":
                    SelectedKey = Keys.N;
                    break;
                case "O":
                    SelectedKey = Keys.O;
                    break;
                case "P":
                    SelectedKey = Keys.P;
                    break;
                case "Q":
                    SelectedKey = Keys.Q;
                    break;
                case "R":
                    SelectedKey = Keys.R;
                    break;
                case "S":
                    SelectedKey = Keys.S;
                    break;
                case "T":
                    SelectedKey = Keys.T;
                    break;
                case "U":
                    SelectedKey = Keys.U;
                    break;
                case "V":
                    SelectedKey = Keys.V;
                    break;
                case "W":
                    SelectedKey = Keys.W;
                    break;
                case "X":
                    SelectedKey = Keys.X;
                    break;
                case "Y":
                    SelectedKey = Keys.Y;
                    break;
                case "Z":
                    SelectedKey = Keys.Z;
                    break;
                case "0":
                    SelectedKey = Keys.D0;
                    break;
                case "1":
                    SelectedKey = Keys.D1;
                    break;
                case "2":
                    SelectedKey = Keys.D2;
                    break;
                case "3":
                    SelectedKey = Keys.D3;
                    break;
                case "4":
                    SelectedKey = Keys.D4;
                    break;
                case "5":
                    SelectedKey = Keys.D5;
                    break;
                case "6":
                    SelectedKey = Keys.D6;
                    break;
                case "7":
                    SelectedKey = Keys.D7;
                    break;
                case "8":
                    SelectedKey = Keys.D8;
                    break;
                case "9":
                    SelectedKey = Keys.D9;
                    break;
                case "F1":
                    SelectedKey = Keys.F1;
                    break;
                case "F2":
                    SelectedKey = Keys.F2;
                    break;
                case "F3":
                    SelectedKey = Keys.F3;
                    break;
                case "F4":
                    SelectedKey = Keys.F4;
                    break;
                case "F5":
                    SelectedKey = Keys.F5;
                    break;
                case "F6":
                    SelectedKey = Keys.F6;
                    break;
                case "F7":
                    SelectedKey = Keys.F7;
                    break;
                case "F8":
                    SelectedKey = Keys.F8;
                    break;
                case "F9":
                    SelectedKey = Keys.F9;
                    break;
                case "F10":
                    SelectedKey = Keys.F10;
                    break;
                case "F11":
                    SelectedKey = Keys.F11;
                    break;
                case "F12":
                    SelectedKey = Keys.F12;
                    break;
                default:
                    break;
            }
            return SelectedKey;
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
            for (int i = 0; i <= (Int32)Key.GetValue("NumOfStrokes"); i++)
            {
                if (!File.Exists(Key.GetValue("datahere").ToString() + Key.GetValue("FileName").ToString() + i.ToString() + TXT))
                {
                    File.Create(Key.GetValue("datahere").ToString() + Key.GetValue("FileName").ToString() + i.ToString() + TXT);
                }
            }
            if (Key.GetValue("ShiftMod") == null)
            {
                Key.CreateSubKey("ShiftMod");
                Key.SetValue("ShiftMod", "0");
            }
            if (Key.GetValue("CtrlMod") == null)
            {
                Key.CreateSubKey("CtrlMod");
                Key.SetValue("CtrlMod", "1");
            }
            if (Key.GetValue("AltMod") == null)
            {
                Key.CreateSubKey("AltMod");
                Key.SetValue("AltMod", "0");
            }
        }

        public static void CopyMe(TextBox textBox)
        {
            if (textBox.Text != "")
            { Clipboard.SetText(textBox.Text); }
        }

        public static string GetValue(int id)
        {
            if (id <= NumOfStrokes && id > 0)
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
            if (id <= NumOfStrokes && id > 0)
            {
                File.WriteAllText(Key.GetValue("datahere").ToString() + Key.GetValue("FileName").ToString() + id + TXT, value);
            }
        }
    }
}