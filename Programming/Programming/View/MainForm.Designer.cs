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
            Enums.SuspendLayout();
            SeasonHandle.SuspendLayout();
            WeekdayParsing.SuspendLayout();
            tabControl1.SuspendLayout();
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
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(792, 422);
            Classes.TabIndex = 1;
            Classes.Text = "tabPage1";
            Classes.UseVisualStyleBackColor = true;
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
    }
}