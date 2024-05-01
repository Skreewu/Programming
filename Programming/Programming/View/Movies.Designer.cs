namespace Programming.View
{
    partial class Movies
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
            SuspendLayout();
            // 
            // FilmFindButton
            // 
            FilmFindButton.Location = new Point(306, 150);
            FilmFindButton.Name = "FilmFindButton";
            FilmFindButton.Size = new Size(109, 49);
            FilmFindButton.TabIndex = 19;
            FilmFindButton.Text = "Find";
            FilmFindButton.UseVisualStyleBackColor = true;
            FilmFindButton.Click += FilmFindButton_Click;
            // 
            // FilmRateLabel
            // 
            FilmRateLabel.AutoSize = true;
            FilmRateLabel.Location = new Point(157, 146);
            FilmRateLabel.Name = "FilmRateLabel";
            FilmRateLabel.Size = new Size(33, 15);
            FilmRateLabel.TabIndex = 30;
            FilmRateLabel.Text = "Rate:";
            // 
            // ReleaseYearLabel
            // 
            ReleaseYearLabel.AutoSize = true;
            ReleaseYearLabel.Location = new Point(306, 76);
            ReleaseYearLabel.Name = "ReleaseYearLabel";
            ReleaseYearLabel.Size = new Size(74, 15);
            ReleaseYearLabel.TabIndex = 29;
            ReleaseYearLabel.Text = "Release Year:";
            // 
            // FilmDurationLabel
            // 
            FilmDurationLabel.AutoSize = true;
            FilmDurationLabel.Location = new Point(157, 76);
            FilmDurationLabel.Name = "FilmDurationLabel";
            FilmDurationLabel.Size = new Size(56, 15);
            FilmDurationLabel.TabIndex = 28;
            FilmDurationLabel.Text = "Duration:";
            // 
            // FilmGenreLabel
            // 
            FilmGenreLabel.AutoSize = true;
            FilmGenreLabel.Location = new Point(306, 0);
            FilmGenreLabel.Name = "FilmGenreLabel";
            FilmGenreLabel.Size = new Size(41, 15);
            FilmGenreLabel.TabIndex = 27;
            FilmGenreLabel.Text = "Genre:";
            // 
            // FilmNameLabel
            // 
            FilmNameLabel.AutoSize = true;
            FilmNameLabel.Location = new Point(157, 0);
            FilmNameLabel.Name = "FilmNameLabel";
            FilmNameLabel.Size = new Size(42, 15);
            FilmNameLabel.TabIndex = 26;
            FilmNameLabel.Text = "Name:";
            // 
            // FilmNameTextBox
            // 
            FilmNameTextBox.Location = new Point(157, 18);
            FilmNameTextBox.Name = "FilmNameTextBox";
            FilmNameTextBox.Size = new Size(109, 23);
            FilmNameTextBox.TabIndex = 20;
            FilmNameTextBox.TextChanged += FilmNameTextBox_TextChanged;
            // 
            // FilmGenreTextBox
            // 
            FilmGenreTextBox.Location = new Point(306, 18);
            FilmGenreTextBox.Name = "FilmGenreTextBox";
            FilmGenreTextBox.Size = new Size(109, 23);
            FilmGenreTextBox.TabIndex = 22;
            FilmGenreTextBox.TextChanged += FilmGenreTextBox_TextChanged;
            // 
            // FilmDurationTextBox
            // 
            FilmDurationTextBox.Location = new Point(157, 94);
            FilmDurationTextBox.Name = "FilmDurationTextBox";
            FilmDurationTextBox.Size = new Size(109, 23);
            FilmDurationTextBox.TabIndex = 23;
            FilmDurationTextBox.TextChanged += FilmDurationTextBox_TextChanged;
            // 
            // ReleaseYearTextBox
            // 
            ReleaseYearTextBox.Location = new Point(306, 94);
            ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            ReleaseYearTextBox.Size = new Size(109, 23);
            ReleaseYearTextBox.TabIndex = 24;
            ReleaseYearTextBox.TextChanged += ReleaseYearTextBox_TextChanged;
            // 
            // FilmRateTextBox
            // 
            FilmRateTextBox.Location = new Point(157, 164);
            FilmRateTextBox.Name = "FilmRateTextBox";
            FilmRateTextBox.Size = new Size(109, 23);
            FilmRateTextBox.TabIndex = 25;
            FilmRateTextBox.TextChanged += FilmRateTextBox_TextChanged;
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 15;
            FilmsListBox.Location = new Point(0, 0);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(146, 199);
            FilmsListBox.TabIndex = 21;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // Movies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmFindButton);
            Controls.Add(FilmRateLabel);
            Controls.Add(ReleaseYearLabel);
            Controls.Add(FilmDurationLabel);
            Controls.Add(FilmGenreLabel);
            Controls.Add(FilmNameLabel);
            Controls.Add(FilmNameTextBox);
            Controls.Add(FilmGenreTextBox);
            Controls.Add(FilmDurationTextBox);
            Controls.Add(ReleaseYearTextBox);
            Controls.Add(FilmRateTextBox);
            Controls.Add(FilmsListBox);
            Name = "Movies";
            Size = new Size(416, 201);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FilmFindButton;
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
        private ListBox FilmsListBox;
    }
}
