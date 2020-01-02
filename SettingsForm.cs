using Supply;
using System;
using System.Windows.Forms;

namespace T3pyRYster
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            #region AutoRun
            if (SupportModule.AutoRunKey.GetValue("T3pyRYster") != null && SupportModule.AutoRunKey.GetValue("T3pyRYster").ToString() == Application.ExecutablePath)
            { Autorun.Checked = true; }
            else { Autorun.Checked = false; }
            #endregion AutoRun
            #region Set Theme
            NameLabel.BackColor = SupportModule.ColorOne;
            NameLabel.ForeColor = SupportModule.ColorTwo;
            NameLabel.Font = SupportModule.AppFont;
            ComboColorOne.BackColor = SupportModule.ColorOne;
            ComboColorOne.ForeColor = SupportModule.ColorTwo;
            ComboColorOne.Font = SupportModule.AppFont;
            ComboColorTwo.BackColor = SupportModule.ColorOne;
            ComboColorTwo.ForeColor = SupportModule.ColorTwo;
            ComboColorTwo.Font = SupportModule.AppFont;
            CloseButton.BackColor = SupportModule.ColorOne;
            CloseButton.ForeColor = SupportModule.ColorTwo;
            CloseButton.Font = SupportModule.AppFont;
            ForeColor = SupportModule.ColorTwo;
            BackColor = SupportModule.ColorOne;
            Font = SupportModule.AppFont;
            Autorun.BackColor = SupportModule.ColorOne;
            Autorun.ForeColor = SupportModule.ColorTwo;
            Autorun.Font = SupportModule.AppFont;
            ComboFonts.BackColor = SupportModule.ColorOne;
            ComboFonts.ForeColor = SupportModule.ColorTwo;
            ComboFonts.Font = SupportModule.AppFont;
            #endregion Set Theme
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();
        private void MoveMe(object sender, MouseEventArgs e) => SupportModule.MoveForm(e, this);
        private void Autorun_CheckedChanged(object sender, EventArgs e)
        {
            if (Autorun.Checked)
            {
                SupportModule.AutoRunKey.SetValue("T3pyRYster", Application.ExecutablePath);
            }
            else
            {
                SupportModule.AutoRunKey.DeleteValue("T3pyRYster", false);
            }
        }
        private void ComboFonts_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.Key.SetValue("Font", (Int32)ComboFonts.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord);
        private void ComboColorOne_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.Key.SetValue("ColorOne", (Int32)ComboColorOne.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord);
        private void ComboColorTwo_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.Key.SetValue("ColorTwo", (Int32)ComboColorTwo.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord);
    }
}