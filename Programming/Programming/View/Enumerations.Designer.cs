namespace Programming.View
{
    partial class Enumerations
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ChooseValue = new Label();
            ChooseEnumeration = new Label();
            labelIntValue = new Label();
            intValue = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            SuspendLayout();
            // 
            // ChooseValue
            // 
            ChooseValue.AutoSize = true;
            ChooseValue.Location = new Point(193, 0);
            ChooseValue.Name = "ChooseValue";
            ChooseValue.Size = new Size(81, 15);
            ChooseValue.TabIndex = 11;
            ChooseValue.Text = "Choose value:";
            // 
            // ChooseEnumeration
            // 
            ChooseEnumeration.AutoSize = true;
            ChooseEnumeration.Location = new Point(3, 0);
            ChooseEnumeration.Name = "ChooseEnumeration";
            ChooseEnumeration.Size = new Size(121, 15);
            ChooseEnumeration.TabIndex = 10;
            ChooseEnumeration.Text = "Choose enumeration:";
            // 
            // labelIntValue
            // 
            labelIntValue.AutoSize = true;
            labelIntValue.Location = new Point(386, 0);
            labelIntValue.Name = "labelIntValue";
            labelIntValue.Size = new Size(52, 15);
            labelIntValue.TabIndex = 9;
            labelIntValue.Text = "int value";
            labelIntValue.Click += labelIntValue_Click;
            // 
            // intValue
            // 
            intValue.Location = new Point(386, 18);
            intValue.Name = "intValue";
            intValue.Size = new Size(100, 23);
            intValue.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(193, 18);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(147, 214);
            ValuesListBox.TabIndex = 7;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Colour", "FormOfEducation", "Genre", "Season", "SmartphoneManufacturer", "Weekday" });
            EnumsListBox.Location = new Point(3, 18);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(147, 214);
            EnumsListBox.TabIndex = 6;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // Enumerations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChooseValue);
            Controls.Add(ChooseEnumeration);
            Controls.Add(labelIntValue);
            Controls.Add(intValue);
            Controls.Add(ValuesListBox);
            Controls.Add(EnumsListBox);
            Name = "Enumerations";
            Size = new Size(780, 239);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseValue;
        private Label ChooseEnumeration;
        private Label labelIntValue;
        private TextBox intValue;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}
