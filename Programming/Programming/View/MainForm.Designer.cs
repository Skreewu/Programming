namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Enums = new TabPage();
            SeasonHandle = new GroupBox();
            ChooseSeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            labelInSeasonHandle = new Label();
            WeekdayParsing = new GroupBox();
            TextBoxParsing = new TextBox();
            ParseButton = new Button();
            labelParsing = new Label();
            labelResultParsing = new Label();
            ChooseValue = new Label();
            ChooseEnumeration = new Label();
            labelIntValue = new Label();
            intValue = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1 = new TabControl();
            Classes = new TabPage();
            FilmsGroupBox = new GroupBox();
            FilmFindButton = new Button();
            FilmRateLabel = new Label();
            ReleaseYearLabel = new Label();
            FilmDurationLabel = new Label();
            FilmGenreLabel = new Label();
            FilmNameLabel = new Label();
            FilmNameTextBox = new TextBox();
            FilmGenreTextBox = new TextBox();
            FilmDurationTextBox = new TextBox();
            ReleaseYearTextBox = new TextBox();
            FilmRateTextBox = new TextBox();
            FilmsListBox = new ListBox();
            RectanglesGroupBox = new GroupBox();
            FindButton = new Button();
            RectanglesListBox = new ListBox();
            ColourTextBox = new TextBox();
            LengthLabel = new Label();
            ColourLabel = new Label();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            WidthLabel = new Label();
            Enums.SuspendLayout();
            SeasonHandle.SuspendLayout();
            WeekdayParsing.SuspendLayout();
            tabControl1.SuspendLayout();
            Classes.SuspendLayout();
            FilmsGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
            Enums.Controls.Add(SeasonHandle);
            Enums.Controls.Add(WeekdayParsing);
            Enums.Controls.Add(ChooseValue);
            Enums.Controls.Add(ChooseEnumeration);
            Enums.Controls.Add(labelIntValue);
            Enums.Controls.Add(intValue);
            Enums.Controls.Add(ValuesListBox);
            Enums.Controls.Add(EnumsListBox);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 422);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(ChooseSeasonButton);
            SeasonHandle.Controls.Add(SeasonComboBox);
            SeasonHandle.Controls.Add(labelInSeasonHandle);
            SeasonHandle.Location = new Point(377, 249);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(411, 173);
            SeasonHandle.TabIndex = 7;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // ChooseSeasonButton
            // 
            ChooseSeasonButton.Location = new Point(178, 54);
            ChooseSeasonButton.Name = "ChooseSeasonButton";
            ChooseSeasonButton.Size = new Size(75, 23);
            ChooseSeasonButton.TabIndex = 2;
            ChooseSeasonButton.Text = "Go!";
            ChooseSeasonButton.UseVisualStyleBackColor = true;
            ChooseSeasonButton.Click += ChooseSeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonComboBox.Location = new Point(25, 54);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(134, 23);
            SeasonComboBox.TabIndex = 1;
            // 
            // labelInSeasonHandle
            // 
            labelInSeasonHandle.AutoSize = true;
            labelInSeasonHandle.Location = new Point(25, 36);
            labelInSeasonHandle.Name = "labelInSeasonHandle";
            labelInSeasonHandle.Size = new Size(90, 15);
            labelInSeasonHandle.TabIndex = 0;
            labelInSeasonHandle.Text = "Choose Season:";
            // 
            // WeekdayParsing
            // 
            WeekdayParsing.Controls.Add(TextBoxParsing);
            WeekdayParsing.Controls.Add(ParseButton);
            WeekdayParsing.Controls.Add(labelParsing);
            WeekdayParsing.Controls.Add(labelResultParsing);
            WeekdayParsing.Location = new Point(15, 249);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Size = new Size(344, 173);
            WeekdayParsing.TabIndex = 6;
            WeekdayParsing.TabStop = false;
            WeekdayParsing.Text = "Weekday Parsing";
            // 
            // TextBoxParsing
            // 
            TextBoxParsing.Location = new Point(16, 54);
            TextBoxParsing.Name = "TextBoxParsing";
            TextBoxParsing.Size = new Size(141, 23);
            TextBoxParsing.TabIndex = 10;
            TextBoxParsing.TextChanged += TextBoxParsing_TextChanged;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(175, 53);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(88, 23);
            ParseButton.TabIndex = 9;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // labelParsing
            // 
            labelParsing.AutoSize = true;
            labelParsing.Location = new Point(16, 36);
            labelParsing.Name = "labelParsing";
            labelParsing.Size = new Size(125, 15);
            labelParsing.TabIndex = 7;
            labelParsing.Text = "Type value for parsing:";
            // 
            // labelResultParsing
            // 
            labelResultParsing.AutoSize = true;
            labelResultParsing.Location = new Point(16, 92);
            labelResultParsing.Name = "labelResultParsing";
            labelResultParsing.Size = new Size(36, 15);
            labelResultParsing.TabIndex = 8;
            labelResultParsing.Text = "None";
            // 
            // ChooseValue
            // 
            ChooseValue.AutoSize = true;
            ChooseValue.Location = new Point(209, 11);
            ChooseValue.Name = "ChooseValue";
            ChooseValue.Size = new Size(81, 15);
            ChooseValue.TabIndex = 5;
            ChooseValue.Text = "Choose value:";
            ChooseValue.Click += ChooseValue_Click;
            // 
            // ChooseEnumeration
            // 
            ChooseEnumeration.AutoSize = true;
            ChooseEnumeration.Location = new Point(19, 11);
            ChooseEnumeration.Name = "ChooseEnumeration";
            ChooseEnumeration.Size = new Size(121, 15);
            ChooseEnumeration.TabIndex = 4;
            ChooseEnumeration.Text = "Choose enumeration:";
            ChooseEnumeration.Click += ChooseEnumeration_Click;
            // 
            // labelIntValue
            // 
            labelIntValue.AutoSize = true;
            labelIntValue.Location = new Point(402, 11);
            labelIntValue.Name = "labelIntValue";
            labelIntValue.Size = new Size(52, 15);
            labelIntValue.TabIndex = 3;
            labelIntValue.Text = "int value";
            labelIntValue.Click += labelIntValue_Click;
            // 
            // intValue
            // 
            intValue.Location = new Point(402, 29);
            intValue.Name = "intValue";
            intValue.Size = new Size(100, 23);
            intValue.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(209, 29);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(147, 214);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Colour", "FormOfEducation", "Genre", "Season", "SmartphoneManufacturer", "Weekday" });
            EnumsListBox.Location = new Point(19, 29);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(147, 214);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(Classes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Classes
            // 
            Classes.BackColor = Color.White;
            Classes.Controls.Add(FilmsGroupBox);
            Classes.Controls.Add(RectanglesGroupBox);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(792, 422);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            // 
            // FilmsGroupBox
            // 
            FilmsGroupBox.Controls.Add(FilmFindButton);
            FilmsGroupBox.Controls.Add(FilmRateLabel);
            FilmsGroupBox.Controls.Add(ReleaseYearLabel);
            FilmsGroupBox.Controls.Add(FilmDurationLabel);
            FilmsGroupBox.Controls.Add(FilmGenreLabel);
            FilmsGroupBox.Controls.Add(FilmNameLabel);
            FilmsGroupBox.Controls.Add(FilmNameTextBox);
            FilmsGroupBox.Controls.Add(FilmGenreTextBox);
            FilmsGroupBox.Controls.Add(FilmDurationTextBox);
            FilmsGroupBox.Controls.Add(ReleaseYearTextBox);
            FilmsGroupBox.Controls.Add(FilmRateTextBox);
            FilmsGroupBox.Controls.Add(FilmsListBox);
            FilmsGroupBox.Location = new Point(348, 6);
            FilmsGroupBox.Name = "FilmsGroupBox";
            FilmsGroupBox.Size = new Size(436, 224);
            FilmsGroupBox.TabIndex = 8;
            FilmsGroupBox.TabStop = false;
            FilmsGroupBox.Text = "Films";
            // 
            // FilmFindButton
            // 
            FilmFindButton.Location = new Point(312, 169);
            FilmFindButton.Name = "FilmFindButton";
            FilmFindButton.Size = new Size(109, 49);
            FilmFindButton.TabIndex = 9;
            FilmFindButton.Text = "Find";
            FilmFindButton.UseVisualStyleBackColor = true;
            FilmFindButton.Click += FilmFindButton_Click;
            // 
            // FilmRateLabel
            // 
            FilmRateLabel.AutoSize = true;
            FilmRateLabel.Location = new Point(163, 165);
            FilmRateLabel.Name = "FilmRateLabel";
            FilmRateLabel.Size = new Size(33, 15);
            FilmRateLabel.TabIndex = 18;
            FilmRateLabel.Text = "Rate:";
            // 
            // ReleaseYearLabel
            // 
            ReleaseYearLabel.AutoSize = true;
            ReleaseYearLabel.Location = new Point(312, 95);
            ReleaseYearLabel.Name = "ReleaseYearLabel";
            ReleaseYearLabel.Size = new Size(74, 15);
            ReleaseYearLabel.TabIndex = 17;
            ReleaseYearLabel.Text = "Release Year:";
            // 
            // FilmDurationLabel
            // 
            FilmDurationLabel.AutoSize = true;
            FilmDurationLabel.Location = new Point(163, 95);
            FilmDurationLabel.Name = "FilmDurationLabel";
            FilmDurationLabel.Size = new Size(56, 15);
            FilmDurationLabel.TabIndex = 16;
            FilmDurationLabel.Text = "Duration:";
            // 
            // FilmGenreLabel
            // 
            FilmGenreLabel.AutoSize = true;
            FilmGenreLabel.Location = new Point(312, 19);
            FilmGenreLabel.Name = "FilmGenreLabel";
            FilmGenreLabel.Size = new Size(41, 15);
            FilmGenreLabel.TabIndex = 15;
            FilmGenreLabel.Text = "Genre:";
            // 
            // FilmNameLabel
            // 
            FilmNameLabel.AutoSize = true;
            FilmNameLabel.Location = new Point(163, 19);
            FilmNameLabel.Name = "FilmNameLabel";
            FilmNameLabel.Size = new Size(42, 15);
            FilmNameLabel.TabIndex = 14;
            FilmNameLabel.Text = "Name:";
            // 
            // FilmNameTextBox
            // 
            FilmNameTextBox.Location = new Point(163, 37);
            FilmNameTextBox.Name = "FilmNameTextBox";
            FilmNameTextBox.Size = new Size(109, 23);
            FilmNameTextBox.TabIndex = 9;
            FilmNameTextBox.TextChanged += FilmNameTextBox_TextChanged;
            // 
            // FilmGenreTextBox
            // 
            FilmGenreTextBox.Location = new Point(312, 37);
            FilmGenreTextBox.Name = "FilmGenreTextBox";
            FilmGenreTextBox.Size = new Size(109, 23);
            FilmGenreTextBox.TabIndex = 10;
            FilmGenreTextBox.TextChanged += FilmGenreTextBox_TextChanged;
            // 
            // FilmDurationTextBox
            // 
            FilmDurationTextBox.Location = new Point(163, 113);
            FilmDurationTextBox.Name = "FilmDurationTextBox";
            FilmDurationTextBox.Size = new Size(109, 23);
            FilmDurationTextBox.TabIndex = 11;
            FilmDurationTextBox.TextChanged += FilmDurationTextBox_TextChanged;
            // 
            // ReleaseYearTextBox
            // 
            ReleaseYearTextBox.Location = new Point(312, 113);
            ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            ReleaseYearTextBox.Size = new Size(109, 23);
            ReleaseYearTextBox.TabIndex = 12;
            ReleaseYearTextBox.TextChanged += ReleaseYearTextBox_TextChanged;
            // 
            // FilmRateTextBox
            // 
            FilmRateTextBox.Location = new Point(163, 183);
            FilmRateTextBox.Name = "FilmRateTextBox";
            FilmRateTextBox.Size = new Size(109, 23);
            FilmRateTextBox.TabIndex = 13;
            FilmRateTextBox.TextChanged += FilmRateTextBox_TextChanged;
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 15;
            FilmsListBox.Location = new Point(6, 19);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(146, 199);
            FilmsListBox.TabIndex = 9;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(FindButton);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Controls.Add(ColourTextBox);
            RectanglesGroupBox.Controls.Add(LengthLabel);
            RectanglesGroupBox.Controls.Add(ColourLabel);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Location = new Point(8, 6);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(304, 224);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.Transparent;
            FindButton.FlatStyle = FlatStyle.System;
            FindButton.Location = new Point(153, 195);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(99, 23);
            FindButton.TabIndex = 7;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(3, 19);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(120, 199);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // ColourTextBox
            // 
            ColourTextBox.Location = new Point(153, 145);
            ColourTextBox.Name = "ColourTextBox";
            ColourTextBox.Size = new Size(100, 23);
            ColourTextBox.TabIndex = 6;
            ColourTextBox.TextChanged += ColourListBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(152, 19);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(47, 15);
            LengthLabel.TabIndex = 1;
            LengthLabel.Text = "Length:";
            // 
            // ColourLabel
            // 
            ColourLabel.AutoSize = true;
            ColourLabel.Location = new Point(153, 127);
            ColourLabel.Name = "ColourLabel";
            ColourLabel.Size = new Size(46, 15);
            ColourLabel.TabIndex = 3;
            ColourLabel.Text = "Colour:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(152, 92);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(152, 37);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 4;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(152, 74);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 2;
            WidthLabel.Text = "Width:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            Enums.ResumeLayout(false);
            Enums.PerformLayout();
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            WeekdayParsing.ResumeLayout(false);
            WeekdayParsing.PerformLayout();
            tabControl1.ResumeLayout(false);
            Classes.ResumeLayout(false);
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage Enums;
        private TabControl tabControl1;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label labelIntValue;
        private TextBox intValue;
        private Label ChooseEnumeration;
        private Label ChooseValue;
        private GroupBox WeekdayParsing;
        private TextBox TextBoxParsing;
        private Button ParseButton;
        private Label labelParsing;
        private Label labelResultParsing;
        private GroupBox SeasonHandle;
        private Button ChooseSeasonButton;
        private ComboBox SeasonComboBox;
        private Label labelInSeasonHandle;
        private TabPage Classes;
        private Button FindButton;
        private TextBox ColourTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Label ColourLabel;
        private Label WidthLabel;
        private Label LengthLabel;
        private GroupBox RectanglesGroupBox;
        private ListBox RectanglesListBox;
        private GroupBox FilmsGroupBox;
        private ListBox FilmsListBox;
        private Label FilmRateLabel;
        private Label ReleaseYearLabel;
        private Label FilmDurationLabel;
        private Label FilmGenreLabel;
        private Label FilmNameLabel;
        private TextBox FilmNameTextBox;
        private TextBox FilmGenreTextBox;
        private TextBox FilmDurationTextBox;
        private TextBox ReleaseYearTextBox;
        private TextBox FilmRateTextBox;
        private Button FilmFindButton;
    }
}