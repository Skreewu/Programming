namespace ObjectOrientedPractics.View.Tabs
{
    partial class InterfacesTest
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
            ItemListBox = new ListBox();
            ItemsInfoGroupBox = new GroupBox();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            CompareToButton = new Button();
            EqualButton = new Button();
            CopyButton = new Button();
            ItemsInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemListBox
            // 
            ItemListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemListBox.FormattingEnabled = true;
            ItemListBox.ItemHeight = 15;
            ItemListBox.Location = new Point(0, 0);
            ItemListBox.Name = "ItemListBox";
            ItemListBox.Size = new Size(229, 424);
            ItemListBox.TabIndex = 0;
            ItemListBox.SelectedIndexChanged += ItemListBox_SelectedIndexChanged;
            // 
            // ItemsInfoGroupBox
            // 
            ItemsInfoGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsInfoGroupBox.BackgroundImageLayout = ImageLayout.Zoom;
            ItemsInfoGroupBox.Controls.Add(CategoryLabel);
            ItemsInfoGroupBox.Controls.Add(CategoryComboBox);
            ItemsInfoGroupBox.Controls.Add(DescriptionLabel);
            ItemsInfoGroupBox.Controls.Add(NameLabel);
            ItemsInfoGroupBox.Controls.Add(CostLabel);
            ItemsInfoGroupBox.Controls.Add(IdLabel);
            ItemsInfoGroupBox.Controls.Add(DescriptionTextBox);
            ItemsInfoGroupBox.Controls.Add(NameTextBox);
            ItemsInfoGroupBox.Controls.Add(CostTextBox);
            ItemsInfoGroupBox.Controls.Add(IdTextBox);
            ItemsInfoGroupBox.Location = new Point(235, 3);
            ItemsInfoGroupBox.Name = "ItemsInfoGroupBox";
            ItemsInfoGroupBox.Size = new Size(659, 421);
            ItemsInfoGroupBox.TabIndex = 5;
            ItemsInfoGroupBox.TabStop = false;
            ItemsInfoGroupBox.Text = "Selected Item";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(6, 112);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(61, 15);
            CategoryLabel.TabIndex = 9;
            CategoryLabel.Text = "Category: ";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(83, 109);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(570, 23);
            CategoryComboBox.TabIndex = 8;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 287);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(73, 15);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description: ";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 156);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(6, 81);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 5;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 53);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTextBox.Location = new Point(6, 305);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(647, 110);
            DescriptionTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(6, 174);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(647, 94);
            NameTextBox.TabIndex = 2;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.BorderStyle = BorderStyle.FixedSingle;
            CostTextBox.Location = new Point(83, 80);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(570, 23);
            CostTextBox.TabIndex = 1;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Location = new Point(83, 51);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(570, 23);
            IdTextBox.TabIndex = 0;
            // 
            // CompareToButton
            // 
            CompareToButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CompareToButton.Location = new Point(235, 430);
            CompareToButton.Name = "CompareToButton";
            CompareToButton.Size = new Size(109, 32);
            CompareToButton.TabIndex = 6;
            CompareToButton.Text = "CompareTo";
            CompareToButton.UseVisualStyleBackColor = true;
            CompareToButton.Click += CompareToButton_Click;
            // 
            // EqualButton
            // 
            EqualButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EqualButton.Location = new Point(120, 430);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(109, 32);
            EqualButton.TabIndex = 7;
            EqualButton.Text = "Equal";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += EqualButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CopyButton.Location = new Point(3, 430);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(109, 32);
            CopyButton.TabIndex = 8;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // InterfacesTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CopyButton);
            Controls.Add(EqualButton);
            Controls.Add(CompareToButton);
            Controls.Add(ItemsInfoGroupBox);
            Controls.Add(ItemListBox);
            Name = "InterfacesTest";
            Size = new Size(897, 465);
            Load += InterfacesTest_Load;
            ItemsInfoGroupBox.ResumeLayout(false);
            ItemsInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemListBox;
        private GroupBox ItemsInfoGroupBox;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Button CompareToButton;
        private Button EqualButton;
        private Button CopyButton;
    }
}
