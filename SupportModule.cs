using Binder;
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
        public static Keys[] HKeys = { 
            T3pyRYster.Settings.Default.Key1, T3pyRYster.Settings.Default.Key2, 
            T3pyRYster.Settings.Default.Key3, T3pyRYster.Settings.Default.Key4, 
            T3pyRYster.Settings.Default.Key5, T3pyRYster.Settings.Default.Key6,
            T3pyRYster.Settings.Default.Key7, T3pyRYster.Settings.Default.Key8,
            T3pyRYster.Settings.Default.Key9,T3pyRYster.Settings.Default.Key10 };

        public static bool MinimizedStart = T3pyRYster.Settings.Default.StartMin;
        public static bool SettingsOpenned = false;
        #region BindHotkeys
        readonly public static Hotkey[] HKF = { 
            new Hotkey(HKeys[0], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[1], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[2], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[3], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[4], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[5], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[6], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[7], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[8], ShiftMod, CtrlMod, AltMod, WinMod),
            new Hotkey(HKeys[9], ShiftMod, CtrlMod, AltMod, WinMod),
    };
        #endregion BindHotkeys

        public static Keys KeySelector(string name) => (Keys)Enum.Parse(typeof(Keys), name, true);
        public static Color ColorSelector(string name) => ColorTranslator.FromHtml(name);
        public static void CopyMe(TextBox textBox)
        {
            if (textBox.Text != "")
            { Clipboard.SetText(textBox.Text); }
            else
            { Clipboard.Clear(); }
        }
        private static bool ifnotlikeother(Keys key, int index)
        {
            for(int i = 0; i<10;i++)
            {
                if (HKF[i].KeyCode==key && index-1 != i)
                {
                    return false;
                }
            }
            return true;
            
        }
        public static void AutoSaveHK(ComboBox BOX, int index)
        {
            Keys kk = KeySelector(BOX.SelectedItem.ToString());
            if (ifnotlikeother(kk, index))
            {
                switch (index)
                {
                    case 1:

                        T3pyRYster.Settings.Default.Key1 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key1;

                        break;
                    case 2:
                        T3pyRYster.Settings.Default.Key2 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key2;
                        break;
                    case 3:
                        T3pyRYster.Settings.Default.Key3 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key3;
                        break;
                    case 4:
                        T3pyRYster.Settings.Default.Key4 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key4;
                        break;
                    case 5:
                        T3pyRYster.Settings.Default.Key5 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key5;
                        break;
                    case 6:
                        T3pyRYster.Settings.Default.Key6 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key6;
                        break;
                    case 7:
                        T3pyRYster.Settings.Default.Key7 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key7;
                        break;
                    case 8:
                        T3pyRYster.Settings.Default.Key8 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key8;
                        break;
                    case 9:
                        T3pyRYster.Settings.Default.Key9 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key9;
                        break;
                    case 10:
                        T3pyRYster.Settings.Default.Key10 = kk;
                        HKF[index - 1].KeyCode = T3pyRYster.Settings.Default.Key10;
                        break;
                    default:
                        break;

                }
            }
            else
            {
                MessageBox.Show("You cannot set same bind for two values, changes wont save.");
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
    }
}