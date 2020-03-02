using Supply;
using System;
using System.Drawing;
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
            if(SupportModule.MinimizedStart)
            {
                CheckMinimize.Checked = true;
            }
            #endregion AutoRun
            #region Fonts
            ComboFonts.Text = SupportModule.AppFont.Name;
            foreach (FontFamily ff in FontFamily.Families)
            {
                ComboFonts.Items.Add(ff.Name);
            }
            #endregion Fonts
            #region KeyMods
            if (SupportModule.CtrlMod)
            {
                CheckCtrl.Checked = true;
            }
            if (SupportModule.AltMod)
            {
                CheckAlt.Checked = true;
            }
            if (SupportModule.ShiftMod)
            {
                CheckShift.Checked = true;
            }
            #endregion KeyMods
            #region Keys
            ComboHK1.Text = SupportModule.KeyName(SupportModule.Key1);
            ComboHK2.Text = SupportModule.KeyName(SupportModule.Key2);
            ComboHK3.Text = SupportModule.KeyName(SupportModule.Key3);
            ComboHK4.Text = SupportModule.KeyName(SupportModule.Key4);
            ComboHK5.Text = SupportModule.KeyName(SupportModule.Key5);
            ComboHK6.Text = SupportModule.KeyName(SupportModule.Key6);
            ComboHK7.Text = SupportModule.KeyName(SupportModule.Key7);
            ComboHK8.Text = SupportModule.KeyName(SupportModule.Key8);
            ComboHK9.Text = SupportModule.KeyName(SupportModule.Key9);
            ComboHK10.Text = SupportModule.KeyName(SupportModule.Key10);
            #endregion Keys
            #region Colors
            ComboColorOne.Text = SupportModule.ColorOne.ToString();
            ComboColorTwo.Text = SupportModule.ColorTwo.ToString();
            #endregion Colors
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
            ComboHK1.BackColor = SupportModule.ColorOne;
            ComboHK1.ForeColor = SupportModule.ColorTwo;
            ComboHK1.Font = SupportModule.AppFont;
            ComboHK2.BackColor = SupportModule.ColorOne;
            ComboHK2.ForeColor = SupportModule.ColorTwo;
            ComboHK2.Font = SupportModule.AppFont;
            ComboHK3.BackColor = SupportModule.ColorOne;
            ComboHK3.ForeColor = SupportModule.ColorTwo;
            ComboHK3.Font = SupportModule.AppFont;
            ComboHK4.BackColor = SupportModule.ColorOne;
            ComboHK4.ForeColor = SupportModule.ColorTwo;
            ComboHK4.Font = SupportModule.AppFont;
            ComboHK5.BackColor = SupportModule.ColorOne;
            ComboHK5.ForeColor = SupportModule.ColorTwo;
            ComboHK5.Font = SupportModule.AppFont;
            ComboHK6.BackColor = SupportModule.ColorOne;
            ComboHK6.ForeColor = SupportModule.ColorTwo;
            ComboHK6.Font = SupportModule.AppFont;
            ComboHK7.BackColor = SupportModule.ColorOne;
            ComboHK7.ForeColor = SupportModule.ColorTwo;
            ComboHK7.Font = SupportModule.AppFont;
            ComboHK8.BackColor = SupportModule.ColorOne;
            ComboHK8.ForeColor = SupportModule.ColorTwo;
            ComboHK8.Font = SupportModule.AppFont;
            ComboHK9.BackColor = SupportModule.ColorOne;
            ComboHK9.ForeColor = SupportModule.ColorTwo;
            ComboHK9.Font = SupportModule.AppFont;
            ComboHK10.BackColor = SupportModule.ColorOne;
            ComboHK10.ForeColor = SupportModule.ColorTwo;
            ComboHK10.Font = SupportModule.AppFont;
            AuthorLabel.BackColor = SupportModule.ColorOne;
            AuthorLabel.ForeColor = SupportModule.ColorTwo;
            AuthorLabel.Font = SupportModule.AppFont;
            EditionLabel.BackColor = SupportModule.ColorOne;
            EditionLabel.ForeColor = SupportModule.ColorTwo;
            EditionLabel.Font = SupportModule.AppFont;
            CheckMinimize.BackColor = SupportModule.ColorOne;
            CheckMinimize.ForeColor = SupportModule.ColorTwo;
            CheckMinimize.Font = SupportModule.AppFont;
            #endregion Set Theme
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SupportModule.SettingsOpenned = false;
            Close();
        }

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
        private void ComboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.Font = new Font(ComboFonts.SelectedItem.ToString(), 9.0f);
            Settings.Default.Save();
        }

        private void ComboColorOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.ColorOne = SupportModule.ColorSelector(ComboColorOne.SelectedItem.ToString());
            Settings.Default.Save();
        }

        private void ComboColorTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.ColorTwo = SupportModule.ColorSelector(ComboColorTwo.SelectedItem.ToString());
            Settings.Default.Save();
        }

        private void CheckCtrl_CheckedChanged(object sender, EventArgs e) => SupportModule.AutoSaveHKMods(CheckCtrl, 1);
        private void CheckShift_CheckedChanged(object sender, EventArgs e) => SupportModule.AutoSaveHKMods(CheckShift, 2);
        private void CheckAlt_CheckedChanged(object sender, EventArgs e) => SupportModule.AutoSaveHKMods(CheckAlt, 3);
        private void ComboHK1_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK1, 1);
        private void ComboHK2_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK2, 2);
        private void ComboHK3_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK3, 3);
        private void ComboHK4_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK4, 4);
        private void ComboHK5_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK5, 5);
        private void ComboHK6_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK6, 6);
        private void ComboHK7_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK7, 7);
        private void ComboHK8_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK8, 8);
        private void ComboHK9_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK9, 9);
        private void ComboHK10_SelectedIndexChanged(object sender, EventArgs e) => SupportModule.AutoSaveHK(ComboHK10, 10);

        private void CheckMinimize_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.StartMin = CheckMinimize.Checked;
            Settings.Default.Save();
        }
    }
}