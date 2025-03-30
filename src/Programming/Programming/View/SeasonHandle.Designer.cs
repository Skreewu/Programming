namespace Programming.View
{
    partial class SeasonHandle
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
            ChooseSeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            labelInSeasonHandle = new Label();
            SuspendLayout();
            // 
            // ChooseSeasonButton
            // 
            ChooseSeasonButton.Location = new Point(156, 18);
            ChooseSeasonButton.Name = "ChooseSeasonButton";
            ChooseSeasonButton.Size = new Size(75, 23);
            ChooseSeasonButton.TabIndex = 5;
            ChooseSeasonButton.Text = "Go!";
            ChooseSeasonButton.UseVisualStyleBackColor = true;
            ChooseSeasonButton.Click += ChooseSeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonComboBox.Location = new Point(3, 18);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(134, 23);
            SeasonComboBox.TabIndex = 4;
            // 
            // labelInSeasonHandle
            // 
            labelInSeasonHandle.AutoSize = true;
            labelInSeasonHandle.Location = new Point(3, 0);
            labelInSeasonHandle.Name = "labelInSeasonHandle";
            labelInSeasonHandle.Size = new Size(90, 15);
            labelInSeasonHandle.TabIndex = 3;
            labelInSeasonHandle.Text = "Choose Season:";
            // 
            // SeasonHandle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChooseSeasonButton);
            Controls.Add(SeasonComboBox);
            Controls.Add(labelInSeasonHandle);
            Name = "SeasonHandle";
            Size = new Size(235, 52);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChooseSeasonButton;
        private ComboBox SeasonComboBox;
        private Label labelInSeasonHandle;
    }
}
