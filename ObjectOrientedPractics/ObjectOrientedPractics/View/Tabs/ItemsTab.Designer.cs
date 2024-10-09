namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsListGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            ItemsInfoGroupBox = new GroupBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            ItemsListGroupBox.SuspendLayout();
            ItemsInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListGroupBox
            // 
            ItemsListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListGroupBox.Controls.Add(RemoveButton);
            ItemsListGroupBox.Controls.Add(AddButton);
            ItemsListGroupBox.Controls.Add(ItemsListBox);
            ItemsListGroupBox.Location = new Point(0, 0);
            ItemsListGroupBox.Name = "ItemsListGroupBox";
            ItemsListGroupBox.Size = new Size(325, 500);
            ItemsListGroupBox.TabIndex = 0;
            ItemsListGroupBox.TabStop = false;
            ItemsListGroupBox.Text = "Items";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.Location = new Point(218, 441);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(101, 47);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Location = new Point(3, 441);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(101, 47);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 19);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(316, 409);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ItemsInfoGroupBox
            // 
            ItemsInfoGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsInfoGroupBox.BackgroundImageLayout = ImageLayout.Zoom;
            ItemsInfoGroupBox.Controls.Add(DescriptionLabel);
            ItemsInfoGroupBox.Controls.Add(NameLabel);
            ItemsInfoGroupBox.Controls.Add(CostLabel);
            ItemsInfoGroupBox.Controls.Add(IdLabel);
            ItemsInfoGroupBox.Controls.Add(DescriptionTextBox);
            ItemsInfoGroupBox.Controls.Add(NameTextBox);
            ItemsInfoGroupBox.Controls.Add(CostTextBox);
            ItemsInfoGroupBox.Controls.Add(IdTextBox);
            ItemsInfoGroupBox.Location = new Point(334, 0);
            ItemsInfoGroupBox.Name = "ItemsInfoGroupBox";
            ItemsInfoGroupBox.Size = new Size(466, 500);
            ItemsInfoGroupBox.TabIndex = 1;
            ItemsInfoGroupBox.TabStop = false;
            ItemsInfoGroupBox.Text = "Selected Item";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 257);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(73, 15);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description: ";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 126);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(6, 82);
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
            DescriptionTextBox.Location = new Point(6, 275);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(454, 122);
            DescriptionTextBox.TabIndex = 3;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(6, 144);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(454, 94);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.BorderStyle = BorderStyle.FixedSingle;
            CostTextBox.Location = new Point(67, 79);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(127, 23);
            CostTextBox.TabIndex = 1;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Location = new Point(67, 50);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(127, 23);
            IdTextBox.TabIndex = 0;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsInfoGroupBox);
            Controls.Add(ItemsListGroupBox);
            Name = "ItemsTab";
            Size = new Size(800, 500);
            ItemsListGroupBox.ResumeLayout(false);
            ItemsInfoGroupBox.ResumeLayout(false);
            ItemsInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsListGroupBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private GroupBox ItemsInfoGroupBox;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
    }
}
