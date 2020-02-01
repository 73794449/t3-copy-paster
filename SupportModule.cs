using Microsoft.Win32;
using System;
using System.Drawing;
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

        public static RegistryKey
            AutoRunKey = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public static Color
            ColorOne = T3pyRYster.Settings.Default.ColorOne,
            ColorTwo = T3pyRYster.Settings.Default.ColorTwo;
        public static Font
            AppFont = T3pyRYster.Settings.Default.Font;
        public static bool
            ShiftMod = T3pyRYster.Settings.Default.ShiftMod,
            CtrlMod = T3pyRYster.Settings.Default.CtrlMod,
            AltMod = T3pyRYster.Settings.Default.AltMod,
            WinMod = false; //because windows is system-wide button
        public static Keys
            Key1 = T3pyRYster.Settings.Default.Key1,
            Key2 = T3pyRYster.Settings.Default.Key2,
            Key3 = T3pyRYster.Settings.Default.Key3,
            Key4 = T3pyRYster.Settings.Default.Key4,
            Key5 = T3pyRYster.Settings.Default.Key5,
            Key6 = T3pyRYster.Settings.Default.Key6,
            Key7 = T3pyRYster.Settings.Default.Key7,
            Key8 = T3pyRYster.Settings.Default.Key8,
            Key9 = T3pyRYster.Settings.Default.Key9,
            Key10 = T3pyRYster.Settings.Default.Key10;
        public static bool MinimizedStart = T3pyRYster.Settings.Default.StartMin;
        public static bool SettingsOpenned = false;

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
        public static Color ColorSelector(string name)
        {
            Color selectedColor = Color.White;
            switch (name)
            {
                case "Black":
                    selectedColor = Color.Black;
                    break;
                case "Gray":
                    selectedColor = Color.Gray;
                    break;
                case "White":
                    selectedColor = Color.White;
                    break;
                case "Yellow":
                    selectedColor = Color.Yellow;
                    break;
                case "Orange":
                    selectedColor = Color.Orange;
                    break;
                case "Red":
                    selectedColor = Color.Red;
                    break;
                case "Green":
                    selectedColor = Color.Green;
                    break;
                case "Blue":
                    selectedColor = Color.Blue;
                    break;
                case "Pink":
                    selectedColor = Color.Pink;
                    break;
                case "Violet":
                    selectedColor = Color.Violet;
                    break;
                default:
                    break;
            }
            return selectedColor;
        }
        public static void CopyMe(TextBox textBox)
        {
            if (textBox.Text != "")
            { Clipboard.SetText(textBox.Text); }
            else
            { Clipboard.Clear(); }
        }
        public static void AutoSaveHK(ComboBox BOX, int index)
        {
            switch (index)
            {
                case 1:
                    T3pyRYster.Settings.Default.Key1 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 2:
                    T3pyRYster.Settings.Default.Key2 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 3:
                    T3pyRYster.Settings.Default.Key3 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 4:
                    T3pyRYster.Settings.Default.Key4 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 5:
                    T3pyRYster.Settings.Default.Key5 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 6:
                    T3pyRYster.Settings.Default.Key6 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 7:
                    T3pyRYster.Settings.Default.Key7 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 8:
                    T3pyRYster.Settings.Default.Key8 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 9:
                    T3pyRYster.Settings.Default.Key9 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                case 10:
                    T3pyRYster.Settings.Default.Key10 = KeySelector(BOX.SelectedItem.ToString());
                    break;
                default:
                    break;

            }
            T3pyRYster.Settings.Default.Save();
        }
        public static void SetValue(int index, string text)
        {
            switch (index)
            {
                case 1:
                    T3pyRYster.Settings.Default.Value1 = text;
                    break;
                case 2:
                    T3pyRYster.Settings.Default.Value2 = text;
                    break;
                case 3:
                    T3pyRYster.Settings.Default.Value3 = text;
                    break;
                case 4:
                    T3pyRYster.Settings.Default.Value4 = text;
                    break;
                case 5:
                    T3pyRYster.Settings.Default.Value5 = text;
                    break;
                case 6:
                    T3pyRYster.Settings.Default.Value6 = text;
                    break;
                case 7:
                    T3pyRYster.Settings.Default.Value7 = text;
                    break;
                case 8:
                    T3pyRYster.Settings.Default.Value8 = text;
                    break;
                case 9:
                    T3pyRYster.Settings.Default.Value9 = text;
                    break;
                case 10:
                    T3pyRYster.Settings.Default.Value10 = text;
                    break;
                default:
                    break;
            }
            T3pyRYster.Settings.Default.Save();
        }
        public static void AutoSaveHKMods(CheckBox checker, int index)
        {
            if (checker.Checked)
            {
                switch (index)
                {
                    case 1:
                        T3pyRYster.Settings.Default.CtrlMod = true;
                        break;
                    case 2:
                        T3pyRYster.Settings.Default.ShiftMod = true;
                        break;
                    case 3:
                        T3pyRYster.Settings.Default.AltMod = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    case 1:
                        T3pyRYster.Settings.Default.CtrlMod = false;
                        break;
                    case 2:
                        T3pyRYster.Settings.Default.ShiftMod = false;
                        break;
                    case 3:
                        T3pyRYster.Settings.Default.AltMod = false;
                        break;
                    default:
                        break;
                }
            }
            T3pyRYster.Settings.Default.Save();

        }
        public static string KeyName(Keys key)
        {
            switch (key)
            {
                case Keys.D0:
                    return "0";
                case Keys.D1:
                    return "1";
                case Keys.D2:
                    return "2";
                case Keys.D3:
                    return "3";
                case Keys.D4:
                    return "4";
                case Keys.D5:
                    return "5";
                case Keys.D6:
                    return "6";
                case Keys.D7:
                    return "7";
                case Keys.D8:
                    return "8";
                case Keys.D9:
                    return "9";
                default:
                    return key.ToString();
            }
        }
    }
}