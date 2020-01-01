using Binder;
using Supply;
using System;
using System.Windows.Forms;

namespace T3pyRYster
{
    public partial class Form1 : Form
    {
        #region BindHotkeys

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

        #endregion BindHotkeys

        public Form1()
        {
            InitializeComponent();

            #region SetValuesAfterRestart

            TextOne.Text = SupportModule.GetValue(1);
            TextTwo.Text = SupportModule.GetValue(2);
            TextThree.Text = SupportModule.GetValue(3);
            TextFour.Text = SupportModule.GetValue(4);
            TextFive.Text = SupportModule.GetValue(5);
            TextSix.Text = SupportModule.GetValue(6);
            TextSeven.Text = SupportModule.GetValue(7);
            TextEight.Text = SupportModule.GetValue(8);
            TextNine.Text = SupportModule.GetValue(9);
            TextTen.Text = SupportModule.GetValue(10);

            #endregion SetValuesAfterRestart

            #region Bind hotkeys

            hkF1.Pressed += delegate { SupportModule.CopyMe(TextOne); SendKeys.Send("^{v}"); };
            hkF1.Register(this);
            hkF2.Pressed += delegate { SupportModule.CopyMe(TextTwo); SendKeys.Send("^{v}"); };
            hkF2.Register(this);
            hkF3.Pressed += delegate { SupportModule.CopyMe(TextThree); SendKeys.Send("^{v}"); };
            hkF3.Register(this);
            hkF4.Pressed += delegate { SupportModule.CopyMe(TextFour); SendKeys.Send("^{v}"); };
            hkF4.Register(this);
            hkF5.Pressed += delegate { SupportModule.CopyMe(TextFive); SendKeys.Send("^{v}"); };
            hkF5.Register(this);
            hkF6.Pressed += delegate { SupportModule.CopyMe(TextSix); SendKeys.Send("^{v}"); };
            hkF6.Register(this);
            hkF7.Pressed += delegate { SupportModule.CopyMe(TextSeven); SendKeys.Send("^{v}"); };
            hkF7.Register(this);
            hkF8.Pressed += delegate { SupportModule.CopyMe(TextEight); SendKeys.Send("^{v}"); };
            hkF8.Register(this);
            hkF9.Pressed += delegate { SupportModule.CopyMe(TextNine); SendKeys.Send("^{v}"); };
            hkF9.Register(this);
            hkF10.Pressed += delegate { SupportModule.CopyMe(TextTen); SendKeys.Send("^{v}"); };
            hkF10.Register(this);

            #endregion Bind hotkeys

            #region Theme

            SupportModule.LoadThemeThatNow();
            CloseButton.BackColor = SupportModule.ColorOne;
            CloseButton.ForeColor = SupportModule.ColorTwo;
            CopyOne.BackColor = SupportModule.ColorOne;
            CopyOne.ForeColor = SupportModule.ColorTwo;
            CopyTwo.BackColor = SupportModule.ColorOne;
            CopyTwo.ForeColor = SupportModule.ColorTwo;
            CopyThree.BackColor = SupportModule.ColorOne;
            CopyThree.ForeColor = SupportModule.ColorTwo;
            CopyFour.BackColor = SupportModule.ColorOne;
            CopyFour.ForeColor = SupportModule.ColorTwo;
            CopyFive.BackColor = SupportModule.ColorOne;
            CopyFive.ForeColor = SupportModule.ColorTwo;
            CopySix.BackColor = SupportModule.ColorOne;
            CopySix.ForeColor = SupportModule.ColorTwo;
            CopySeven.BackColor = SupportModule.ColorOne;
            CopySeven.ForeColor = SupportModule.ColorTwo;
            CopyEight.BackColor = SupportModule.ColorOne;
            CopyEight.ForeColor = SupportModule.ColorTwo;
            CopyNine.ForeColor = SupportModule.ColorTwo;
            CopyNine.BackColor = SupportModule.ColorOne;
            CopyTen.ForeColor = SupportModule.ColorTwo;
            CopyTen.BackColor = SupportModule.ColorOne;
            NameLabel.BackColor = SupportModule.ColorOne;
            NameLabel.ForeColor = SupportModule.ColorTwo;
            TextOne.BackColor = SupportModule.ColorOne;
            TextOne.ForeColor = SupportModule.ColorTwo;
            TextTwo.BackColor = SupportModule.ColorOne;
            TextTwo.ForeColor = SupportModule.ColorTwo;
            TextThree.BackColor = SupportModule.ColorOne;
            TextThree.ForeColor = SupportModule.ColorTwo;
            TextFour.BackColor = SupportModule.ColorOne;
            TextFour.ForeColor = SupportModule.ColorTwo;
            TextFive.BackColor = SupportModule.ColorOne;
            TextFive.ForeColor = SupportModule.ColorTwo;
            TextSix.BackColor = SupportModule.ColorOne;
            TextSix.ForeColor = SupportModule.ColorTwo;
            TextSeven.BackColor = SupportModule.ColorOne;
            TextSeven.ForeColor = SupportModule.ColorTwo;
            TextEight.BackColor = SupportModule.ColorOne;
            TextEight.ForeColor = SupportModule.ColorTwo;
            TextNine.BackColor = SupportModule.ColorOne;
            TextNine.ForeColor = SupportModule.ColorTwo;
            TextTen.BackColor = SupportModule.ColorOne;
            TextTen.ForeColor = SupportModule.ColorTwo;
            HideButton.BackColor = SupportModule.ColorOne;
            HideButton.ForeColor = SupportModule.ColorTwo;
            SettingsButton.BackColor = SupportModule.ColorOne;
            SettingsButton.ForeColor = SupportModule.ColorTwo;
            BackColor = SupportModule.ColorOne;
            ForeColor = SupportModule.ColorTwo;

            #endregion Theme
        }

        private void MoveMe(object sender, MouseEventArgs e) => SupportModule.MoveForm(sender, e, this);

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void Hide_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            Show();
        }

        #region CopyPasterMain

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

        #endregion CopyPasterMain
    }
}