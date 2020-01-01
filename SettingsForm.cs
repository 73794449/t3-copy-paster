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
            if (SupportModule.AutoRunKey.GetValue("T3pyRYster") != null && SupportModule.AutoRunKey.GetValue("T3pyRYster").ToString() == Application.ExecutablePath) 
            { Autorun.Checked = true; }
            else { Autorun.Checked = false; }
            #region Set Theme
            NameLabel.BackColor = SupportModule.ColorOne;
            NameLabel.ForeColor = SupportModule.ColorTwo;
            NameLabel.Font = SupportModule.AppFont;
            BlackButton.BackColor = SupportModule.ColorOne;
            BlackButton.ForeColor = SupportModule.ColorTwo;
            BlackButton.Font = SupportModule.AppFont;
            WhiteButton.BackColor = SupportModule.ColorTwo;
            WhiteButton.ForeColor = SupportModule.ColorOne;
            WhiteButton.Font = SupportModule.AppFont;
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

        private void BlackButton_Click(object sender, EventArgs e)
        {
            SupportModule.Key.CreateSubKey("Theme");
            SupportModule.Key.SetValue("Theme", "0");
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            SupportModule.Key.CreateSubKey("Theme");
            SupportModule.Key.SetValue("Theme", "1");
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
            switch (ComboFonts.SelectedIndex)
            {
                case 0:
                    SupportModule.fontfam = new FontFamily("Arial");
                    break;
                case 1:
                    SupportModule.fontfam = new FontFamily("Calibri");
                    break;
                case 2:
                    SupportModule.fontfam = new FontFamily(System.Drawing.Text.GenericFontFamilies.SansSerif);
                    break;
            }
            SupportModule.Key.CreateSubKey("Font");
            SupportModule.Key.SetValue("Font", SupportModule.fontfam.Name);
        }

        private void AnimateName(object sender, EventArgs e) => NameLabel.ForeColor = SupportModule.ColorTwo;
    }
}