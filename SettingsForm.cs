using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace T3pyRYster
{
    public partial class SettingsForm : Form
    {
        //MoveForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //MoveForm
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
            LoadThemeThatNow();
            CurrTheme = LoadThemeThatNow();
            if (CurrTheme)
            {
                black = System.Drawing.Color.Black;
                white = System.Drawing.Color.White;
            }
            else
            {
                black = System.Drawing.Color.White;
                white = System.Drawing.Color.Black;
            }
            NameLabel.BackColor = black;
            NameLabel.ForeColor = white;
            BlackButton.BackColor = black;
            BlackButton.ForeColor = white;
            WhiteButton.BackColor = white;
            WhiteButton.ForeColor = black;
            CloseButton.BackColor = black;
            CloseButton.ForeColor = white;
            ForeColor = white;
            BackColor = black;
        }

        private RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\T3Settings\T3pyRyster");

        private bool LoadThemeThatNow()
        {
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

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void BlackButton_Click(object sender, EventArgs e)
        {
            key.CreateSubKey("Theme");
            key.SetValue("Theme", "0");
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            key.CreateSubKey("Theme");
            key.SetValue("Theme", "1");
        }
    }
}