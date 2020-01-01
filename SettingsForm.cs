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

            #region Set Theme

            NameLabel.BackColor = SupportModule.ColorOne;
            NameLabel.ForeColor = SupportModule.ColorTwo;
            BlackButton.BackColor = SupportModule.ColorOne;
            BlackButton.ForeColor = SupportModule.ColorTwo;
            WhiteButton.BackColor = SupportModule.ColorTwo;
            WhiteButton.ForeColor = SupportModule.ColorOne;
            CloseButton.BackColor = SupportModule.ColorOne;
            CloseButton.ForeColor = SupportModule.ColorTwo;
            ForeColor = SupportModule.ColorTwo;
            BackColor = SupportModule.ColorOne;

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

        private void MoveMe(object sender, MouseEventArgs e) => SupportModule.MoveForm(sender, e, this);
    }
}