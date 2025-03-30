namespace Programming.View
{
    partial class RectanglesCollisionControl
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
            CanvasWidthTextBox = new TextBox();
            CanvasLengthTextBox = new TextBox();
            CanvasYTextBox = new TextBox();
            CanvasXTextBox = new TextBox();
            CanvasIdTextBox = new TextBox();
            CanvasWidthLabel = new Label();
            CanvasLengthLabel = new Label();
            CanvasYLabel = new Label();
            CanvasXLabel = new Label();
            CanvasIdLabel = new Label();
            SelectedRectangleLabel = new Label();
            DeleteRectangleButton = new Button();
            AddRectangleButton = new Button();
            CanvasRectangleListBox = new ListBox();
            Canvas = new Panel();
            SuspendLayout();
            // 
            // CanvasWidthTextBox
            // 
            CanvasWidthTextBox.Location = new Point(76, 377);
            CanvasWidthTextBox.Name = "CanvasWidthTextBox";
            CanvasWidthTextBox.Size = new Size(152, 23);
            CanvasWidthTextBox.TabIndex = 29;
            CanvasWidthTextBox.TextChanged += CanvasWidthTextBox_TextChanged;
            // 
            // CanvasLengthTextBox
            // 
            CanvasLengthTextBox.Location = new Point(76, 343);
            CanvasLengthTextBox.Name = "CanvasLengthTextBox";
            CanvasLengthTextBox.Size = new Size(152, 23);
            CanvasLengthTextBox.TabIndex = 28;
            CanvasLengthTextBox.TextChanged += CanvasLengthTextBox_TextChanged;
            // 
            // CanvasYTextBox
            // 
            CanvasYTextBox.Location = new Point(76, 310);
            CanvasYTextBox.Name = "CanvasYTextBox";
            CanvasYTextBox.Size = new Size(152, 23);
            CanvasYTextBox.TabIndex = 27;
            CanvasYTextBox.TextChanged += CanvasYTextBox_TextChanged;
            // 
            // CanvasXTextBox
            // 
            CanvasXTextBox.Location = new Point(76, 275);
            CanvasXTextBox.Name = "CanvasXTextBox";
            CanvasXTextBox.Size = new Size(152, 23);
            CanvasXTextBox.TabIndex = 26;
            CanvasXTextBox.TextChanged += CanvasXTextBox_TextChanged;
            // 
            // CanvasIdTextBox
            // 
            CanvasIdTextBox.Location = new Point(76, 241);
            CanvasIdTextBox.Name = "CanvasIdTextBox";
            CanvasIdTextBox.ReadOnly = true;
            CanvasIdTextBox.Size = new Size(152, 23);
            CanvasIdTextBox.TabIndex = 25;
            // 
            // CanvasWidthLabel
            // 
            CanvasWidthLabel.AutoSize = true;
            CanvasWidthLabel.Location = new Point(11, 385);
            CanvasWidthLabel.Name = "CanvasWidthLabel";
            CanvasWidthLabel.Size = new Size(45, 15);
            CanvasWidthLabel.TabIndex = 24;
            CanvasWidthLabel.Text = "Width: ";
            // 
            // CanvasLengthLabel
            // 
            CanvasLengthLabel.AutoSize = true;
            CanvasLengthLabel.Location = new Point(11, 351);
            CanvasLengthLabel.Name = "CanvasLengthLabel";
            CanvasLengthLabel.Size = new Size(50, 15);
            CanvasLengthLabel.TabIndex = 23;
            CanvasLengthLabel.Text = "Length: ";
            // 
            // CanvasYLabel
            // 
            CanvasYLabel.AutoSize = true;
            CanvasYLabel.Location = new Point(11, 318);
            CanvasYLabel.Name = "CanvasYLabel";
            CanvasYLabel.Size = new Size(17, 15);
            CanvasYLabel.TabIndex = 22;
            CanvasYLabel.Text = "Y:";
            // 
            // CanvasXLabel
            // 
            CanvasXLabel.AutoSize = true;
            CanvasXLabel.Location = new Point(11, 283);
            CanvasXLabel.Name = "CanvasXLabel";
            CanvasXLabel.Size = new Size(17, 15);
            CanvasXLabel.TabIndex = 21;
            CanvasXLabel.Text = "X:";
            // 
            // CanvasIdLabel
            // 
            CanvasIdLabel.AutoSize = true;
            CanvasIdLabel.Location = new Point(11, 249);
            CanvasIdLabel.Name = "CanvasIdLabel";
            CanvasIdLabel.Size = new Size(20, 15);
            CanvasIdLabel.TabIndex = 20;
            CanvasIdLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(3, 218);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(109, 15);
            SelectedRectangleLabel.TabIndex = 19;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.BackColor = Color.Transparent;
            DeleteRectangleButton.Cursor = Cursors.Hand;
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Location = new Point(153, 181);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(75, 23);
            DeleteRectangleButton.TabIndex = 18;
            DeleteRectangleButton.Text = "Delete";
            DeleteRectangleButton.UseVisualStyleBackColor = false;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.Cursor = Cursors.Hand;
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Location = new Point(29, 181);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(75, 23);
            AddRectangleButton.TabIndex = 17;
            AddRectangleButton.Text = "Add";
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // CanvasRectangleListBox
            // 
            CanvasRectangleListBox.FormattingEnabled = true;
            CanvasRectangleListBox.ItemHeight = 15;
            CanvasRectangleListBox.Location = new Point(3, 12);
            CanvasRectangleListBox.Name = "CanvasRectangleListBox";
            CanvasRectangleListBox.Size = new Size(258, 154);
            CanvasRectangleListBox.TabIndex = 16;
            CanvasRectangleListBox.SelectedIndexChanged += CanvasRectangleListBox_SelectedIndexChanged;
            // 
            // Canvas
            // 
            Canvas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Canvas.BorderStyle = BorderStyle.FixedSingle;
            Canvas.Location = new Point(278, 12);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(491, 388);
            Canvas.TabIndex = 15;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CanvasWidthTextBox);
            Controls.Add(CanvasLengthTextBox);
            Controls.Add(CanvasYTextBox);
            Controls.Add(CanvasXTextBox);
            Controls.Add(CanvasIdTextBox);
            Controls.Add(CanvasWidthLabel);
            Controls.Add(CanvasLengthLabel);
            Controls.Add(CanvasYLabel);
            Controls.Add(CanvasXLabel);
            Controls.Add(CanvasIdLabel);
            Controls.Add(SelectedRectangleLabel);
            Controls.Add(DeleteRectangleButton);
            Controls.Add(AddRectangleButton);
            Controls.Add(CanvasRectangleListBox);
            Controls.Add(Canvas);
            Name = "RectanglesCollisionControl";
            Size = new Size(786, 412);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CanvasWidthTextBox;
        private TextBox CanvasLengthTextBox;
        private TextBox CanvasYTextBox;
        private TextBox CanvasXTextBox;
        private TextBox CanvasIdTextBox;
        private Label CanvasWidthLabel;
        private Label CanvasLengthLabel;
        private Label CanvasYLabel;
        private Label CanvasXLabel;
        private Label CanvasIdLabel;
        private Label SelectedRectangleLabel;
        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private ListBox CanvasRectangleListBox;
        private Panel Canvas;
    }
}
