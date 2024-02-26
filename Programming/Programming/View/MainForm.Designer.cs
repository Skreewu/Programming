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
            ChooseEnumeration = new Label();
            labelIntValue = new Label();
            intValue = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1 = new TabControl();
            ChooseValue = new Label();
            Enums.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
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
            ValuesListBox.Size = new Size(147, 244);
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
            EnumsListBox.Size = new Size(147, 244);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Enums.ResumeLayout(false);
            Enums.PerformLayout();
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
    }
}