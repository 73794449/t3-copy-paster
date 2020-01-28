namespace T3pyRYster
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Autorun = new System.Windows.Forms.CheckBox();
            this.ComboFonts = new System.Windows.Forms.ComboBox();
            this.ComboColorOne = new System.Windows.Forms.ComboBox();
            this.ComboColorTwo = new System.Windows.Forms.ComboBox();
            this.CheckShift = new System.Windows.Forms.CheckBox();
            this.CheckCtrl = new System.Windows.Forms.CheckBox();
            this.CheckAlt = new System.Windows.Forms.CheckBox();
            this.ComboHK2 = new System.Windows.Forms.ComboBox();
            this.ComboHK3 = new System.Windows.Forms.ComboBox();
            this.ComboHK4 = new System.Windows.Forms.ComboBox();
            this.ComboHK5 = new System.Windows.Forms.ComboBox();
            this.ComboHK6 = new System.Windows.Forms.ComboBox();
            this.ComboHK7 = new System.Windows.Forms.ComboBox();
            this.ComboHK8 = new System.Windows.Forms.ComboBox();
            this.ComboHK9 = new System.Windows.Forms.ComboBox();
            this.ComboHK10 = new System.Windows.Forms.ComboBox();
            this.ComboHK1 = new System.Windows.Forms.ComboBox();
            this.AuthorLabel = new System.Windows.Forms.TextBox();
            this.EditionLabel = new System.Windows.Forms.TextBox();
            this.CheckMinimize = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(11, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Settings";
            this.NameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveMe);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(240, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Autorun
            // 
            this.Autorun.Appearance = System.Windows.Forms.Appearance.Button;
            this.Autorun.AutoSize = true;
            this.Autorun.BackColor = System.Drawing.Color.Black;
            this.Autorun.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Autorun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Autorun.ForeColor = System.Drawing.Color.White;
            this.Autorun.Location = new System.Drawing.Point(156, 56);
            this.Autorun.Name = "Autorun";
            this.Autorun.Size = new System.Drawing.Size(87, 23);
            this.Autorun.TabIndex = 5;
            this.Autorun.Text = "Run on startup";
            this.Autorun.UseVisualStyleBackColor = false;
            this.Autorun.CheckedChanged += new System.EventHandler(this.Autorun_CheckedChanged);
            // 
            // ComboFonts
            // 
            this.ComboFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboFonts.FormattingEnabled = true;
            this.ComboFonts.Location = new System.Drawing.Point(6, 85);
            this.ComboFonts.Name = "ComboFonts";
            this.ComboFonts.Size = new System.Drawing.Size(144, 21);
            this.ComboFonts.TabIndex = 6;
            this.ComboFonts.Text = "Select font";
            this.ComboFonts.SelectedIndexChanged += new System.EventHandler(this.ComboFonts_SelectedIndexChanged);
            // 
            // ComboColorOne
            // 
            this.ComboColorOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboColorOne.FormattingEnabled = true;
            this.ComboColorOne.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Gray",
            "Green",
            "Orange",
            "Pink",
            "Red",
            "Violet",
            "White",
            "Yellow"});
            this.ComboColorOne.Location = new System.Drawing.Point(6, 31);
            this.ComboColorOne.Name = "ComboColorOne";
            this.ComboColorOne.Size = new System.Drawing.Size(144, 21);
            this.ComboColorOne.TabIndex = 7;
            this.ComboColorOne.Text = "Select first color";
            this.ComboColorOne.SelectedIndexChanged += new System.EventHandler(this.ComboColorOne_SelectedIndexChanged);
            // 
            // ComboColorTwo
            // 
            this.ComboColorTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboColorTwo.FormattingEnabled = true;
            this.ComboColorTwo.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Gray",
            "Green",
            "Orange",
            "Pink",
            "Red",
            "Violet",
            "White",
            "Yellow"});
            this.ComboColorTwo.Location = new System.Drawing.Point(6, 58);
            this.ComboColorTwo.Name = "ComboColorTwo";
            this.ComboColorTwo.Size = new System.Drawing.Size(144, 21);
            this.ComboColorTwo.TabIndex = 8;
            this.ComboColorTwo.Text = "Select second color";
            this.ComboColorTwo.SelectedIndexChanged += new System.EventHandler(this.ComboColorTwo_SelectedIndexChanged);
            // 
            // CheckShift
            // 
            this.CheckShift.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckShift.AutoSize = true;
            this.CheckShift.BackColor = System.Drawing.Color.Black;
            this.CheckShift.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.CheckShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckShift.ForeColor = System.Drawing.Color.White;
            this.CheckShift.Location = new System.Drawing.Point(156, 137);
            this.CheckShift.Name = "CheckShift";
            this.CheckShift.Size = new System.Drawing.Size(62, 23);
            this.CheckShift.TabIndex = 5;
            this.CheckShift.Text = "Bind Shift";
            this.CheckShift.UseVisualStyleBackColor = false;
            this.CheckShift.CheckedChanged += new System.EventHandler(this.CheckShift_CheckedChanged);
            // 
            // CheckCtrl
            // 
            this.CheckCtrl.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckCtrl.AutoSize = true;
            this.CheckCtrl.BackColor = System.Drawing.Color.Black;
            this.CheckCtrl.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.CheckCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckCtrl.ForeColor = System.Drawing.Color.White;
            this.CheckCtrl.Location = new System.Drawing.Point(156, 110);
            this.CheckCtrl.Name = "CheckCtrl";
            this.CheckCtrl.Size = new System.Drawing.Size(56, 23);
            this.CheckCtrl.TabIndex = 5;
            this.CheckCtrl.Text = "Bind Ctrl";
            this.CheckCtrl.UseVisualStyleBackColor = false;
            this.CheckCtrl.CheckedChanged += new System.EventHandler(this.CheckCtrl_CheckedChanged);
            // 
            // CheckAlt
            // 
            this.CheckAlt.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckAlt.AutoSize = true;
            this.CheckAlt.BackColor = System.Drawing.Color.Black;
            this.CheckAlt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.CheckAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckAlt.ForeColor = System.Drawing.Color.White;
            this.CheckAlt.Location = new System.Drawing.Point(156, 83);
            this.CheckAlt.Name = "CheckAlt";
            this.CheckAlt.Size = new System.Drawing.Size(53, 23);
            this.CheckAlt.TabIndex = 5;
            this.CheckAlt.Text = "Bind Alt";
            this.CheckAlt.UseVisualStyleBackColor = false;
            this.CheckAlt.CheckedChanged += new System.EventHandler(this.CheckAlt_CheckedChanged);
            // 
            // ComboHK2
            // 
            this.ComboHK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK2.Location = new System.Drawing.Point(56, 112);
            this.ComboHK2.Name = "ComboHK2";
            this.ComboHK2.Size = new System.Drawing.Size(44, 21);
            this.ComboHK2.TabIndex = 9;
            this.ComboHK2.Text = "2";
            this.ComboHK2.SelectedIndexChanged += new System.EventHandler(this.ComboHK2_SelectedIndexChanged);
            // 
            // ComboHK3
            // 
            this.ComboHK3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK3.Location = new System.Drawing.Point(106, 112);
            this.ComboHK3.Name = "ComboHK3";
            this.ComboHK3.Size = new System.Drawing.Size(44, 21);
            this.ComboHK3.TabIndex = 9;
            this.ComboHK3.Text = "3";
            this.ComboHK3.SelectedIndexChanged += new System.EventHandler(this.ComboHK3_SelectedIndexChanged);
            // 
            // ComboHK4
            // 
            this.ComboHK4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK4.Location = new System.Drawing.Point(6, 139);
            this.ComboHK4.Name = "ComboHK4";
            this.ComboHK4.Size = new System.Drawing.Size(44, 21);
            this.ComboHK4.TabIndex = 9;
            this.ComboHK4.Text = "4";
            this.ComboHK4.SelectedIndexChanged += new System.EventHandler(this.ComboHK4_SelectedIndexChanged);
            // 
            // ComboHK5
            // 
            this.ComboHK5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK5.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK5.Location = new System.Drawing.Point(56, 139);
            this.ComboHK5.Name = "ComboHK5";
            this.ComboHK5.Size = new System.Drawing.Size(44, 21);
            this.ComboHK5.TabIndex = 9;
            this.ComboHK5.Text = "5";
            this.ComboHK5.SelectedIndexChanged += new System.EventHandler(this.ComboHK5_SelectedIndexChanged);
            // 
            // ComboHK6
            // 
            this.ComboHK6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK6.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK6.Location = new System.Drawing.Point(106, 139);
            this.ComboHK6.Name = "ComboHK6";
            this.ComboHK6.Size = new System.Drawing.Size(44, 21);
            this.ComboHK6.TabIndex = 9;
            this.ComboHK6.Text = "6";
            this.ComboHK6.SelectedIndexChanged += new System.EventHandler(this.ComboHK6_SelectedIndexChanged);
            // 
            // ComboHK7
            // 
            this.ComboHK7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK7.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK7.Location = new System.Drawing.Point(6, 166);
            this.ComboHK7.Name = "ComboHK7";
            this.ComboHK7.Size = new System.Drawing.Size(44, 21);
            this.ComboHK7.TabIndex = 9;
            this.ComboHK7.Text = "7";
            this.ComboHK7.SelectedIndexChanged += new System.EventHandler(this.ComboHK7_SelectedIndexChanged);
            // 
            // ComboHK8
            // 
            this.ComboHK8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK8.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK8.Location = new System.Drawing.Point(56, 166);
            this.ComboHK8.Name = "ComboHK8";
            this.ComboHK8.Size = new System.Drawing.Size(44, 21);
            this.ComboHK8.TabIndex = 9;
            this.ComboHK8.Text = "8";
            this.ComboHK8.SelectedIndexChanged += new System.EventHandler(this.ComboHK8_SelectedIndexChanged);
            // 
            // ComboHK9
            // 
            this.ComboHK9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK9.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK9.Location = new System.Drawing.Point(106, 166);
            this.ComboHK9.Name = "ComboHK9";
            this.ComboHK9.Size = new System.Drawing.Size(44, 21);
            this.ComboHK9.TabIndex = 9;
            this.ComboHK9.Text = "9";
            this.ComboHK9.SelectedIndexChanged += new System.EventHandler(this.ComboHK9_SelectedIndexChanged);
            // 
            // ComboHK10
            // 
            this.ComboHK10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK10.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK10.Location = new System.Drawing.Point(6, 193);
            this.ComboHK10.Name = "ComboHK10";
            this.ComboHK10.Size = new System.Drawing.Size(44, 21);
            this.ComboHK10.TabIndex = 9;
            this.ComboHK10.Text = "10";
            this.ComboHK10.SelectedIndexChanged += new System.EventHandler(this.ComboHK10_SelectedIndexChanged);
            // 
            // ComboHK1
            // 
            this.ComboHK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHK1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.ComboHK1.Location = new System.Drawing.Point(6, 112);
            this.ComboHK1.Name = "ComboHK1";
            this.ComboHK1.Size = new System.Drawing.Size(44, 21);
            this.ComboHK1.TabIndex = 9;
            this.ComboHK1.Text = "1";
            this.ComboHK1.SelectedIndexChanged += new System.EventHandler(this.ComboHK1_SelectedIndexChanged);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorLabel.Location = new System.Drawing.Point(156, 34);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(114, 13);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Created by T3RY4";
            // 
            // EditionLabel
            // 
            this.EditionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditionLabel.Location = new System.Drawing.Point(56, 196);
            this.EditionLabel.Name = "EditionLabel";
            this.EditionLabel.Size = new System.Drawing.Size(214, 13);
            this.EditionLabel.TabIndex = 11;
            this.EditionLabel.Text = "2020 edition v2.0";
            // 
            // CheckMinimize
            // 
            this.CheckMinimize.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckMinimize.AutoSize = true;
            this.CheckMinimize.BackColor = System.Drawing.Color.Black;
            this.CheckMinimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.CheckMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckMinimize.ForeColor = System.Drawing.Color.White;
            this.CheckMinimize.Location = new System.Drawing.Point(156, 164);
            this.CheckMinimize.Name = "CheckMinimize";
            this.CheckMinimize.Size = new System.Drawing.Size(87, 23);
            this.CheckMinimize.TabIndex = 5;
            this.CheckMinimize.Text = "Start minimized";
            this.CheckMinimize.UseVisualStyleBackColor = false;
            this.CheckMinimize.CheckedChanged += new System.EventHandler(this.CheckMinimize_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(272, 221);
            this.Controls.Add(this.EditionLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.ComboHK1);
            this.Controls.Add(this.ComboHK10);
            this.Controls.Add(this.ComboHK9);
            this.Controls.Add(this.ComboHK8);
            this.Controls.Add(this.ComboHK7);
            this.Controls.Add(this.ComboHK6);
            this.Controls.Add(this.ComboHK5);
            this.Controls.Add(this.ComboHK4);
            this.Controls.Add(this.ComboHK3);
            this.Controls.Add(this.ComboHK2);
            this.Controls.Add(this.ComboColorTwo);
            this.Controls.Add(this.ComboColorOne);
            this.Controls.Add(this.ComboFonts);
            this.Controls.Add(this.CheckAlt);
            this.Controls.Add(this.CheckCtrl);
            this.Controls.Add(this.CheckMinimize);
            this.Controls.Add(this.CheckShift);
            this.Controls.Add(this.Autorun);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckBox Autorun;
        private System.Windows.Forms.ComboBox ComboFonts;
        private System.Windows.Forms.ComboBox ComboColorOne;
        private System.Windows.Forms.ComboBox ComboColorTwo;
        private System.Windows.Forms.CheckBox CheckShift;
        private System.Windows.Forms.CheckBox CheckCtrl;
        private System.Windows.Forms.CheckBox CheckAlt;
        private System.Windows.Forms.ComboBox ComboHK2;
        private System.Windows.Forms.ComboBox ComboHK3;
        private System.Windows.Forms.ComboBox ComboHK4;
        private System.Windows.Forms.ComboBox ComboHK5;
        private System.Windows.Forms.ComboBox ComboHK6;
        private System.Windows.Forms.ComboBox ComboHK7;
        private System.Windows.Forms.ComboBox ComboHK8;
        private System.Windows.Forms.ComboBox ComboHK9;
        private System.Windows.Forms.ComboBox ComboHK10;
        private System.Windows.Forms.ComboBox ComboHK1;
        private System.Windows.Forms.TextBox AuthorLabel;
        private System.Windows.Forms.TextBox EditionLabel;
        private System.Windows.Forms.CheckBox CheckMinimize;

        public bool CurrTheme { get; private set; }
    }
}