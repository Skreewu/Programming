namespace Programming.View
{
    partial class WeekdayParsing
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
            TextBoxParsing = new TextBox();
            ParseButton = new Button();
            labelParsing = new Label();
            labelResultParsing = new Label();
            SuspendLayout();
            // 
            // TextBoxParsing
            // 
            TextBoxParsing.Location = new Point(3, 18);
            TextBoxParsing.Name = "TextBoxParsing";
            TextBoxParsing.Size = new Size(141, 23);
            TextBoxParsing.TabIndex = 14;
            TextBoxParsing.TextChanged += TextBoxParsing_TextChanged;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(162, 17);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(88, 23);
            ParseButton.TabIndex = 13;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // labelParsing
            // 
            labelParsing.AutoSize = true;
            labelParsing.Location = new Point(3, 0);
            labelParsing.Name = "labelParsing";
            labelParsing.Size = new Size(125, 15);
            labelParsing.TabIndex = 11;
            labelParsing.Text = "Type value for parsing:";
            // 
            // labelResultParsing
            // 
            labelResultParsing.AutoSize = true;
            labelResultParsing.Location = new Point(3, 56);
            labelResultParsing.Name = "labelResultParsing";
            labelResultParsing.Size = new Size(36, 15);
            labelResultParsing.TabIndex = 12;
            labelResultParsing.Text = "None";
            // 
            // WeekdayParsing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TextBoxParsing);
            Controls.Add(ParseButton);
            Controls.Add(labelParsing);
            Controls.Add(labelResultParsing);
            Name = "WeekdayParsing";
            Size = new Size(265, 82);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxParsing;
        private Button ParseButton;
        private Label labelParsing;
        private Label labelResultParsing;
    }
}
