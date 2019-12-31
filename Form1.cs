using Binder;
using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace T3pyRYster
{
    public partial class Form1 : Form
    {
        //MoveForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //MoveForm
        //foreground window
        [DllImport("User32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        //foreground window
        private class T3DATA
        {
            public T3DATA() => Load();

            private object Load()
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\T3Settings\T3pyRyster");
                if (key.GetValue("datahere") == null)
                {
                    key.CreateSubKey("datahere");
                    for (int i = 1; i < 11; i++)
                    {
                        if (!File.Exists("data\\SettingsNow" + i.ToString() + ".txt"))
                        {
                            Directory.CreateDirectory("data");
                            File.CreateText("data\\SettingsNow" + i.ToString() + ".txt");
                        }
                    }
                    key.SetValue("datahere", "data\\SettingsNow");
                }
                return key.GetValue("datahere");
            }

            internal string GetValue(int id)
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

            internal void SetValue(int id, string value)
            {
                if (id != 0 && id <= 10)
                {
                    File.WriteAllText(Load().ToString() + id.ToString() + ".txt", value);
                }
            }
        }

        private bool LoadThemeThatNow()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\T3Settings\T3pyRyster");
            if (key.GetValue("Theme") == null)
            {
                key.CreateSubKey("Theme");
                key.SetValue("Theme", "0");
            }
            if (key.GetValue("Theme").ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private readonly T3DATA Data = new T3DATA();
        private readonly Hotkey hkF1 = new Hotkey(Keys.F1, false, true, false, false);
        private readonly Hotkey hkF2 = new Hotkey(Keys.F2, false, true, false, false);
        private readonly Hotkey hkF3 = new Hotkey(Keys.F3, false, true, false, false);
        private readonly Hotkey hkF4 = new Hotkey(Keys.F4, false, true, false, false);
        private readonly Hotkey hkF5 = new Hotkey(Keys.F5, false, true, false, false);
        private readonly Hotkey hkF6 = new Hotkey(Keys.F6, false, true, false, false);
        private readonly Hotkey hkF7 = new Hotkey(Keys.F7, false, true, false, false);
        private readonly Hotkey hkF8 = new Hotkey(Keys.F8, false, true, false, false);
        private readonly Hotkey hkF9 = new Hotkey(Keys.F9, false, true, false, false);
        private readonly Hotkey hkF10 = new Hotkey(Keys.F10, false, true, false, false);

        public Form1()
        {
            InitializeComponent();
            LoadValues();
            hkF1.Pressed += delegate { Clipboard.SetText(TextOne.Text); SendKeys.Send("^{v}"); };
            hkF1.Register(this);
            hkF2.Pressed += delegate { Clipboard.SetText(TextTwo.Text); SendKeys.Send("^{v}"); };
            hkF2.Register(this);
            hkF3.Pressed += delegate { Clipboard.SetText(TextThree.Text); SendKeys.Send("^{v}"); };
            hkF3.Register(this);
            hkF4.Pressed += delegate { Clipboard.SetText(TextFour.Text); SendKeys.Send("^{v}"); };
            hkF4.Register(this);
            hkF5.Pressed += delegate { Clipboard.SetText(TextFive.Text); SendKeys.Send("^{v}"); };
            hkF5.Register(this);
            hkF6.Pressed += delegate { Clipboard.SetText(TextSix.Text); SendKeys.Send("^{v}"); };
            hkF6.Register(this);
            hkF7.Pressed += delegate { Clipboard.SetText(TextSeven.Text); SendKeys.Send("^{v}"); };
            hkF7.Register(this);
            hkF8.Pressed += delegate { Clipboard.SetText(TextEight.Text); SendKeys.Send("^{v}"); };
            hkF8.Register(this);
            hkF9.Pressed += delegate { Clipboard.SetText(TextNine.Text); SendKeys.Send("^{v}"); };
            hkF9.Register(this);
            hkF10.Pressed += delegate { Clipboard.SetText(TextTen.Text); SendKeys.Send("^{v}"); };
            hkF10.Register(this);
            CurrTheme = LoadThemeThatNow();
            if (CurrTheme == false)
            {
                black = System.Drawing.Color.Black;
                white = System.Drawing.Color.White;
            }
            else
            {
                black = System.Drawing.Color.White;
                white = System.Drawing.Color.Black;
            }
            CloseButton.BackColor = black;
            CloseButton.ForeColor = white;
            CopyOne.BackColor = black;
            CopyOne.ForeColor = white;
            CopyTwo.BackColor = black;
            CopyTwo.ForeColor = white;
            CopyThree.BackColor = black;
            CopyThree.ForeColor = white;
            CopyFour.BackColor = black;
            CopyFour.ForeColor = white;
            CopyFive.BackColor = black;
            CopyFive.ForeColor = white;
            CopySix.BackColor = black;
            CopySix.ForeColor = white;
            CopySeven.BackColor = black;
            CopySeven.ForeColor = white;
            CopyEight.BackColor = black;
            CopyEight.ForeColor = white;
            CopyNine.ForeColor = white;
            CopyNine.BackColor = black;
            CopyTen.ForeColor = white;
            CopyTen.BackColor = black;
            NameLabel.BackColor = black;
            NameLabel.ForeColor = white;
            TextOne.BackColor = black;
            TextOne.ForeColor = white;
            TextTwo.BackColor = black;
            TextTwo.ForeColor = white;
            TextThree.BackColor = black;
            TextThree.ForeColor = white;
            TextFour.BackColor = black;
            TextFour.ForeColor = white;
            TextFive.BackColor = black;
            TextFive.ForeColor = white;
            TextSix.BackColor = black;
            TextSix.ForeColor = white;
            TextSeven.BackColor = black;
            TextSeven.ForeColor = white;
            TextEight.BackColor = black;
            TextEight.ForeColor = white;
            TextNine.BackColor = black;
            TextNine.ForeColor = white;
            TextTen.BackColor = black;
            TextTen.ForeColor = white;
            HideButton.BackColor = black;
            HideButton.ForeColor = white;
            SettingsButton.BackColor = black;
            SettingsButton.ForeColor = white;
            BackColor = black;
            ForeColor = white;
        }

        private void LoadValues()
        {
            TextOne.Text = Data.GetValue(1);
            TextTwo.Text = Data.GetValue(2);
            TextThree.Text = Data.GetValue(3);
            TextFour.Text = Data.GetValue(4);
            TextFive.Text = Data.GetValue(5);
            TextSix.Text = Data.GetValue(6);
            TextSeven.Text = Data.GetValue(7);
            TextEight.Text = Data.GetValue(8);
            TextNine.Text = Data.GetValue(9);
            TextTen.Text = Data.GetValue(10);
        }

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            Show();
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void Hide_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void TextOne_TextChanged(object sender, EventArgs e) => Data.SetValue(1, TextOne.Text);

        private void TextTwo_TextChanged(object sender, EventArgs e) => Data.SetValue(2, TextTwo.Text);

        private void TextThree_TextChanged(object sender, EventArgs e) => Data.SetValue(3, TextThree.Text);

        private void TextFour_TextChanged(object sender, EventArgs e) => Data.SetValue(4, TextFour.Text);

        private void TextFive_TextChanged(object sender, EventArgs e) => Data.SetValue(5, TextFive.Text);

        private void TextSix_TextChanged(object sender, EventArgs e) => Data.SetValue(6, TextSix.Text);

        private void TextSeven_TextChanged(object sender, EventArgs e) => Data.SetValue(7, TextSeven.Text);

        private void TextEight_TextChanged(object sender, EventArgs e) => Data.SetValue(8, TextEight.Text);

        private void TextNine_TextChanged(object sender, EventArgs e) => Data.SetValue(9, TextNine.Text);

        private void TextTen_TextChanged(object sender, EventArgs e) => Data.SetValue(10, TextTen.Text);

        private void CopyOne_Click(object sender, EventArgs e) => Clipboard.SetText(TextOne.Text);

        private void CopyTwo_Click(object sender, EventArgs e) => Clipboard.SetText(TextTwo.Text);

        private void CopyThree_Click(object sender, EventArgs e) => Clipboard.SetText(TextThree.Text);

        private void CopyFour_Click(object sender, EventArgs e) => Clipboard.SetText(TextFour.Text);

        private void CopyFive_Click(object sender, EventArgs e) => Clipboard.SetText(TextFive.Text);

        private void CopySix_Click(object sender, EventArgs e) => Clipboard.SetText(TextSix.Text);

        private void CopySeven_Click(object sender, EventArgs e) => Clipboard.SetText(TextSeven.Text);

        private void CopyEight_Click(object sender, EventArgs e) => Clipboard.SetText(TextEight.Text);

        private void CopyNine_Click(object sender, EventArgs e) => Clipboard.SetText(TextNine.Text);

        private void CopyTen_Click(object sender, EventArgs e) => Clipboard.SetText(TextTen.Text);

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}