
using Supply;
using System;
using System.Windows.Forms;

namespace T3pyRYster
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();

            #region SetValuesAfterRestart

            TextOne.Text      = Settings.Default.Value1;
            TextTwo.Text      = Settings.Default.Value2;
            TextThree.Text    = Settings.Default.Value3;
            TextFour.Text     = Settings.Default.Value4;
            TextFive.Text     = Settings.Default.Value5;
            TextSix.Text      = Settings.Default.Value6;
            TextSeven.Text    = Settings.Default.Value7;
            TextEight.Text    = Settings.Default.Value8;
            TextNine.Text     = Settings.Default.Value9;
            TextTen.Text      = Settings.Default.Value10;

            #endregion SetValuesAfterRestart

            #region Bind hotkeys

            SupportModule.HKF[0].Pressed += delegate { SupportModule.CopyMe(TextOne); SendKeys.Send("^{v}"); };
            SupportModule.HKF[0].Register(this);
            SupportModule.HKF[1].Pressed += delegate { SupportModule.CopyMe(TextTwo); SendKeys.Send("^{v}"); };
            SupportModule.HKF[1].Register(this);
            SupportModule.HKF[2].Pressed += delegate { SupportModule.CopyMe(TextThree); SendKeys.Send("^{v}"); };
            SupportModule.HKF[2].Register(this);
            SupportModule.HKF[3].Pressed += delegate { SupportModule.CopyMe(TextFour); SendKeys.Send("^{v}"); };
            SupportModule.HKF[3].Register(this);
            SupportModule.HKF[4].Pressed += delegate { SupportModule.CopyMe(TextFive); SendKeys.Send("^{v}"); };
            SupportModule.HKF[4].Register(this);
            SupportModule.HKF[5].Pressed += delegate { SupportModule.CopyMe(TextSix); SendKeys.Send("^{v}"); };
            SupportModule.HKF[5].Register(this);
            SupportModule.HKF[6].Pressed += delegate { SupportModule.CopyMe(TextSeven); SendKeys.Send("^{v}"); };
            SupportModule.HKF[6].Register(this);
            SupportModule.HKF[7].Pressed += delegate { SupportModule.CopyMe(TextEight); SendKeys.Send("^{v}"); };
            SupportModule.HKF[7].Register(this);
            SupportModule.HKF[8].Pressed += delegate { SupportModule.CopyMe(TextNine); SendKeys.Send("^{v}"); };
            SupportModule.HKF[8].Register(this);
            SupportModule.HKF[9].Pressed += delegate { SupportModule.CopyMe(TextTen); SendKeys.Send("^{v}"); };
            SupportModule.HKF[9].Register(this);

            #endregion Bind hotkeys

            #region Theme

            CloseButton.BackColor = SupportModule.ColorOne;
            CloseButton.ForeColor = SupportModule.ColorTwo;
            CloseButton.Font = SupportModule.AppFont;
            CopyOne.BackColor = SupportModule.ColorOne;
            CopyOne.ForeColor = SupportModule.ColorTwo;
            CopyOne.Font = SupportModule.AppFont;
            CopyTwo.BackColor = SupportModule.ColorOne;
            CopyTwo.ForeColor = SupportModule.ColorTwo;
            CopyTwo.Font = SupportModule.AppFont;
            CopyThree.BackColor = SupportModule.ColorOne;
            CopyThree.ForeColor = SupportModule.ColorTwo;
            CopyThree.Font = SupportModule.AppFont;
            CopyFour.BackColor = SupportModule.ColorOne;
            CopyFour.ForeColor = SupportModule.ColorTwo;
            CopyFour.Font = SupportModule.AppFont;
            CopyFive.BackColor = SupportModule.ColorOne;
            CopyFive.ForeColor = SupportModule.ColorTwo;
            CopyFive.Font = SupportModule.AppFont;
            CopySix.BackColor = SupportModule.ColorOne;
            CopySix.ForeColor = SupportModule.ColorTwo;
            CopySix.Font = SupportModule.AppFont;
            CopySeven.BackColor = SupportModule.ColorOne;
            CopySeven.ForeColor = SupportModule.ColorTwo;
            CopySeven.Font = SupportModule.AppFont;
            CopyEight.BackColor = SupportModule.ColorOne;
            CopyEight.ForeColor = SupportModule.ColorTwo;
            CopyEight.Font = SupportModule.AppFont;
            CopyNine.ForeColor = SupportModule.ColorTwo;
            CopyNine.BackColor = SupportModule.ColorOne;
            CopyNine.Font = SupportModule.AppFont;
            CopyTen.ForeColor = SupportModule.ColorTwo;
            CopyTen.BackColor = SupportModule.ColorOne;
            CopyTen.Font = SupportModule.AppFont;
            NameLabel.BackColor = SupportModule.ColorOne;
            NameLabel.ForeColor = SupportModule.ColorTwo;
            NameLabel.Font = SupportModule.AppFont;
            TextOne.BackColor = SupportModule.ColorOne;
            TextOne.ForeColor = SupportModule.ColorTwo;
            TextOne.Font = SupportModule.AppFont;
            TextTwo.BackColor = SupportModule.ColorOne;
            TextTwo.ForeColor = SupportModule.ColorTwo;
            TextTwo.Font = SupportModule.AppFont;
            TextThree.BackColor = SupportModule.ColorOne;
            TextThree.ForeColor = SupportModule.ColorTwo;
            TextThree.Font = SupportModule.AppFont;
            TextFour.BackColor = SupportModule.ColorOne;
            TextFour.ForeColor = SupportModule.ColorTwo;
            TextFour.Font = TextThree.Font = SupportModule.AppFont;
            TextFive.BackColor = SupportModule.ColorOne;
            TextFive.ForeColor = SupportModule.ColorTwo;
            TextFive.Font = TextThree.Font = SupportModule.AppFont;
            TextSix.BackColor = SupportModule.ColorOne;
            TextSix.ForeColor = SupportModule.ColorTwo;
            TextSix.Font = TextThree.Font = SupportModule.AppFont;
            TextSeven.BackColor = SupportModule.ColorOne;
            TextSeven.ForeColor = SupportModule.ColorTwo;
            TextSeven.Font = TextThree.Font = SupportModule.AppFont;
            TextEight.BackColor = SupportModule.ColorOne;
            TextEight.ForeColor = SupportModule.ColorTwo;
            TextEight.Font = TextThree.Font = SupportModule.AppFont;
            TextNine.BackColor = SupportModule.ColorOne;
            TextNine.ForeColor = SupportModule.ColorTwo;
            TextNine.Font = TextThree.Font = SupportModule.AppFont;
            TextTen.BackColor = SupportModule.ColorOne;
            TextTen.ForeColor = SupportModule.ColorTwo;
            TextTen.Font = SupportModule.AppFont;
            HideButton.BackColor = SupportModule.ColorOne;
            HideButton.ForeColor = SupportModule.ColorTwo;
            HideButton.Font = SupportModule.AppFont;
            SettingsButton.BackColor = SupportModule.ColorOne;
            SettingsButton.ForeColor = SupportModule.ColorTwo;
            SettingsButton.Font = SupportModule.AppFont;
            BackColor = SupportModule.ColorOne;
            ForeColor = SupportModule.ColorTwo;
            Font = SupportModule.AppFont;

            #endregion Theme

        }

        private void MoveMe(object sender, MouseEventArgs e) => SupportModule.MoveForm(e, this);

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void Hide_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (!SupportModule.SettingsOpenned)
            {
                SettingsForm settingsForm = new SettingsForm();
                    settingsForm.Show();
                SupportModule.SettingsOpenned = true;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            Show();
        }

        #region TextChangeSave

        private void TextOne_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(1, TextOne.Text);

        private void TextTwo_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(2, TextTwo.Text);

        private void TextThree_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(3, TextThree.Text);

        private void TextFour_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(4, TextFour.Text);

        private void TextFive_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(5, TextFive.Text);

        private void TextSix_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(6, TextSix.Text);

        private void TextSeven_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(7, TextSeven.Text);

        private void TextEight_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(8, TextEight.Text);

        private void TextNine_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(9, TextNine.Text);

        private void TextTen_TextChanged(object sender, EventArgs e) => SupportModule.SetValue(10, TextTen.Text);

        #endregion TextChangeSave

        #region CopyClick

        private void CopyOne_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextOne);

        private void CopyTwo_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextTwo);

        private void CopyThree_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextThree);

        private void CopyFour_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextFour);

        private void CopyFive_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextFive);

        private void CopySix_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextSix);

        private void CopySeven_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextSeven);

        private void CopyEight_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextEight);

        private void CopyNine_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextNine);

        private void CopyTen_Click(object sender, EventArgs e) => SupportModule.CopyMe(TextTen);

        #endregion CopyClick

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (SupportModule.MinimizedStart)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
    }
}