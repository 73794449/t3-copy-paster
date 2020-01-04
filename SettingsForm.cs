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
            if (SupportModule.AutoRunKey.GetValue("T3pyRYster") != null &&
                SupportModule.AutoRunKey.GetValue("T3pyRYster").ToString() == Application.ExecutablePath)
            { Autorun.Checked = true; }
            else { Autorun.Checked = false; }
            #endregion AutoRun
            #region Checkers
            if (SupportModule.Key.GetValue("CtrlMod") != null &&
                SupportModule.Key.GetValue("CtrlMod").ToString() == "1")
            { CheckCtrl.Checked = true; }
            else { CheckCtrl.Checked = false; }
            if (SupportModule.Key.GetValue("AltMod") != null &&
                SupportModule.Key.GetValue("AltMod").ToString() == "1")
            { CheckAlt.Checked = true; }
            else { CheckAlt.Checked = false; }
            if (SupportModule.Key.GetValue("ShiftMod") != null &&
                SupportModule.Key.GetValue("ShiftMod").ToString() == "1")
            { CheckShift.Checked = true; }
            else { CheckShift.Checked = false; }
            #endregion Checkers
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
            CheckCtrl.BackColor = SupportModule.ColorOne;
            CheckCtrl.ForeColor = SupportModule.ColorTwo;
            CheckCtrl.Font = SupportModule.AppFont;
            CheckAlt.BackColor = SupportModule.ColorOne;
            CheckAlt.ForeColor = SupportModule.ColorTwo;
            CheckAlt.Font = SupportModule.AppFont;
            CheckShift.BackColor = SupportModule.ColorOne;
            CheckShift.ForeColor = SupportModule.ColorTwo;
            CheckShift.Font = SupportModule.AppFont;
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
        private void ComboFonts_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.Key.SetValue("Font",
            (Int32)ComboFonts.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord);
        private void ComboColorOne_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.Key.SetValue("ColorOne",
            (Int32)ComboColorOne.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord);
        private void ComboColorTwo_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.Key.SetValue("ColorTwo",
            (Int32)ComboColorTwo.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord);
        private void CheckShift_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckShift.Checked)
            {
                SupportModule.Key.SetValue("ShiftMod", "1");
            }
            else
            {
                SupportModule.Key.SetValue("ShiftMod", "0");
            }
        }
        private void CheckCtrl_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCtrl.Checked)
            {
                SupportModule.Key.SetValue("CtrlMod", "1");
            }
            else
            {
                SupportModule.Key.SetValue("CtrlMod", "0");
            }
        }
        private void CheckAlt_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAlt.Checked)
            {
                SupportModule.Key.SetValue("AltMod", "1");
            }
            else
            {
                SupportModule.Key.SetValue("AltMod", "0");
            }
        }
    }
}