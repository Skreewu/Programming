namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomersListGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            CustomersInfoGroupBox = new GroupBox();
            AddressLabel = new Label();
            FullNameLabel = new Label();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            CustomersListGroupBox.SuspendLayout();
            CustomersInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersListGroupBox
            // 
            CustomersListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListGroupBox.Controls.Add(RemoveButton);
            CustomersListGroupBox.Controls.Add(AddButton);
            CustomersListGroupBox.Controls.Add(CustomersListBox);
            CustomersListGroupBox.Location = new Point(3, 3);
            CustomersListGroupBox.Name = "CustomersListGroupBox";
            CustomersListGroupBox.Size = new Size(348, 494);
            CustomersListGroupBox.TabIndex = 0;
            CustomersListGroupBox.TabStop = false;
            CustomersListGroupBox.Text = "Customers";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.Location = new Point(100, 452);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(88, 36);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Location = new Point(6, 452);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(88, 36);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(336, 424);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersInfoGroupBox
            // 
            CustomersInfoGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersInfoGroupBox.Controls.Add(AddressLabel);
            CustomersInfoGroupBox.Controls.Add(FullNameLabel);
            CustomersInfoGroupBox.Controls.Add(IdLabel);
            CustomersInfoGroupBox.Controls.Add(IdTextBox);
            CustomersInfoGroupBox.Controls.Add(FullNameTextBox);
            CustomersInfoGroupBox.Controls.Add(AddressTextBox);
            CustomersInfoGroupBox.Location = new Point(357, 3);
            CustomersInfoGroupBox.Name = "CustomersInfoGroupBox";
            CustomersInfoGroupBox.Size = new Size(440, 497);
            CustomersInfoGroupBox.TabIndex = 0;
            CustomersInfoGroupBox.TabStop = false;
            CustomersInfoGroupBox.Text = "SelectedCustomer";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(6, 85);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Address:";
            AddressLabel.Click += AddressLabel_Click;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(6, 59);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 5;
            FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 30);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Location = new Point(79, 28);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(101, 23);
            IdTextBox.TabIndex = 1;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FullNameTextBox.Location = new Point(79, 56);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(355, 23);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.BorderStyle = BorderStyle.FixedSingle;
            AddressTextBox.Location = new Point(79, 85);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(355, 85);
            AddressTextBox.TabIndex = 3;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersInfoGroupBox);
            Controls.Add(CustomersListGroupBox);
            Name = "CustomersTab";
            Size = new Size(800, 500);
            CustomersListGroupBox.ResumeLayout(false);
            CustomersInfoGroupBox.ResumeLayout(false);
            CustomersInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersListGroupBox;
        private GroupBox CustomersInfoGroupBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox CustomersListBox;
        private Label AddressLabel;
        private Label FullNameLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private TextBox FullNameTextBox;
        private TextBox AddressTextBox;
    }
}
