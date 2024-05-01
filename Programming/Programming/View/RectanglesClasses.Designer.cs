namespace Programming.View
{
    partial class RectanglesClasses
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
            RectangleIDLabel = new Label();
            XCoordinateTextBox = new TextBox();
            YCoordinateTextBox = new TextBox();
            XCoordinateLabel = new Label();
            YCoordinateLabel = new Label();
            FindButton = new Button();
            RectanglesListBox = new ListBox();
            ColourTextBox = new TextBox();
            LengthLabel = new Label();
            ColourLabel = new Label();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            WidthLabel = new Label();
            SuspendLayout();
            // 
            // RectangleIDLabel
            // 
            RectangleIDLabel.AutoSize = true;
            RectangleIDLabel.Location = new Point(156, 3);
            RectangleIDLabel.Name = "RectangleIDLabel";
            RectangleIDLabel.Size = new Size(75, 15);
            RectangleIDLabel.TabIndex = 24;
            RectangleIDLabel.Text = "Rectangle Id:";
            // 
            // XCoordinateTextBox
            // 
            XCoordinateTextBox.Location = new Point(10, 271);
            XCoordinateTextBox.Name = "XCoordinateTextBox";
            XCoordinateTextBox.ReadOnly = true;
            XCoordinateTextBox.Size = new Size(117, 23);
            XCoordinateTextBox.TabIndex = 20;
            // 
            // YCoordinateTextBox
            // 
            YCoordinateTextBox.Location = new Point(157, 271);
            YCoordinateTextBox.Name = "YCoordinateTextBox";
            YCoordinateTextBox.ReadOnly = true;
            YCoordinateTextBox.Size = new Size(122, 23);
            YCoordinateTextBox.TabIndex = 22;
            // 
            // XCoordinateLabel
            // 
            XCoordinateLabel.AutoSize = true;
            XCoordinateLabel.Location = new Point(27, 253);
            XCoordinateLabel.Name = "XCoordinateLabel";
            XCoordinateLabel.Size = new Size(74, 15);
            XCoordinateLabel.TabIndex = 21;
            XCoordinateLabel.Text = "X coordinate";
            // 
            // YCoordinateLabel
            // 
            YCoordinateLabel.AutoSize = true;
            YCoordinateLabel.Location = new Point(182, 253);
            YCoordinateLabel.Name = "YCoordinateLabel";
            YCoordinateLabel.Size = new Size(74, 15);
            YCoordinateLabel.TabIndex = 23;
            YCoordinateLabel.Text = "Y coordinate";
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.Transparent;
            FindButton.FlatStyle = FlatStyle.System;
            FindButton.Location = new Point(157, 215);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(99, 23);
            FindButton.TabIndex = 19;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(3, 3);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(120, 244);
            RectanglesListBox.TabIndex = 12;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // ColourTextBox
            // 
            ColourTextBox.Location = new Point(157, 165);
            ColourTextBox.Name = "ColourTextBox";
            ColourTextBox.Size = new Size(100, 23);
            ColourTextBox.TabIndex = 18;
            ColourTextBox.TextChanged += ColourListBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(156, 39);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(47, 15);
            LengthLabel.TabIndex = 13;
            LengthLabel.Text = "Length:";
            // 
            // ColourLabel
            // 
            ColourLabel.AutoSize = true;
            ColourLabel.Location = new Point(157, 147);
            ColourLabel.Name = "ColourLabel";
            ColourLabel.Size = new Size(46, 15);
            ColourLabel.TabIndex = 15;
            ColourLabel.Text = "Colour:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(156, 112);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 17;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(156, 57);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 16;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(156, 94);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 14;
            WidthLabel.Text = "Width:";
            // 
            // RectanglesClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleIDLabel);
            Controls.Add(XCoordinateTextBox);
            Controls.Add(YCoordinateTextBox);
            Controls.Add(XCoordinateLabel);
            Controls.Add(YCoordinateLabel);
            Controls.Add(FindButton);
            Controls.Add(RectanglesListBox);
            Controls.Add(ColourTextBox);
            Controls.Add(LengthLabel);
            Controls.Add(ColourLabel);
            Controls.Add(WidthTextBox);
            Controls.Add(LengthTextBox);
            Controls.Add(WidthLabel);
            Name = "RectanglesClasses";
            Size = new Size(284, 298);
            Load += RectanglesClasses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RectangleIDLabel;
        private TextBox XCoordinateTextBox;
        private TextBox YCoordinateTextBox;
        private Label XCoordinateLabel;
        private Label YCoordinateLabel;
        private Button FindButton;
        private ListBox RectanglesListBox;
        private TextBox ColourTextBox;
        private Label LengthLabel;
        private Label ColourLabel;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Label WidthLabel;
    }
}
