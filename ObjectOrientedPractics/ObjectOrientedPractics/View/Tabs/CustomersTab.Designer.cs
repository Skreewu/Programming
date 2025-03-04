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
            Model.Address address6 = new Model.Address();
            CustomersListGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            CustomersInfoGroupBox = new GroupBox();
            RemoveDiscountButton = new Button();
            AddDiscountButton = new Button();
            DiscountsListBox = new ListBox();
            DiscountsLabel = new Label();
            IsPriorityCheckBox = new CheckBox();
            addressControl1 = new Controls.AddressControl();
            FullNameLabel = new Label();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            PictureBox = new PictureBox();
            CustomersListGroupBox.SuspendLayout();
            CustomersInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
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
            CustomersListGroupBox.Size = new Size(348, 652);
            CustomersListGroupBox.TabIndex = 0;
            CustomersListGroupBox.TabStop = false;
            CustomersListGroupBox.Text = "Customers";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.Location = new Point(233, 610);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(109, 36);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Location = new Point(6, 610);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(109, 36);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(336, 574);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersInfoGroupBox
            // 
            CustomersInfoGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersInfoGroupBox.Controls.Add(PictureBox);
            CustomersInfoGroupBox.Controls.Add(RemoveDiscountButton);
            CustomersInfoGroupBox.Controls.Add(AddDiscountButton);
            CustomersInfoGroupBox.Controls.Add(DiscountsListBox);
            CustomersInfoGroupBox.Controls.Add(DiscountsLabel);
            CustomersInfoGroupBox.Controls.Add(IsPriorityCheckBox);
            CustomersInfoGroupBox.Controls.Add(addressControl1);
            CustomersInfoGroupBox.Controls.Add(FullNameLabel);
            CustomersInfoGroupBox.Controls.Add(IdLabel);
            CustomersInfoGroupBox.Controls.Add(IdTextBox);
            CustomersInfoGroupBox.Controls.Add(FullNameTextBox);
            CustomersInfoGroupBox.Location = new Point(357, 3);
            CustomersInfoGroupBox.Name = "CustomersInfoGroupBox";
            CustomersInfoGroupBox.Size = new Size(864, 655);
            CustomersInfoGroupBox.TabIndex = 0;
            CustomersInfoGroupBox.TabStop = false;
            CustomersInfoGroupBox.Text = "SelectedCustomer";
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Location = new Point(222, 372);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(95, 37);
            RemoveDiscountButton.TabIndex = 11;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Location = new Point(222, 329);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(95, 37);
            AddDiscountButton.TabIndex = 10;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 15;
            DiscountsListBox.Location = new Point(6, 329);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(210, 94);
            DiscountsListBox.TabIndex = 9;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountsLabel.Location = new Point(6, 311);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(67, 15);
            DiscountsLabel.TabIndex = 8;
            DiscountsLabel.Text = "Discounts";
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Location = new Point(79, 92);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(75, 19);
            IsPriorityCheckBox.TabIndex = 7;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // addressControl1
            // 
            address6.Apartment = "0";
            address6.Building = "0";
            address6.City = "Город";
            address6.Country = "Страна";
            address6.Index = 100000;
            address6.Street = "Улица";
            addressControl1.Address = address6;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.ApartmentTextBoxValue = "0";
            addressControl1.BuildingTextBoxValue = "0";
            addressControl1.CityTextBoxValue = "Город";
            addressControl1.CountryTextBoxValue = "Страна";
            addressControl1.IndexTextBoxValue = "100000";
            addressControl1.Location = new Point(0, 117);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(858, 351);
            addressControl1.StreetTextBoxValue = "Улица";
            addressControl1.TabIndex = 6;
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
            IdTextBox.Size = new Size(525, 23);
            IdTextBox.TabIndex = 1;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FullNameTextBox.Location = new Point(79, 56);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(779, 23);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // PictureBox
            // 
            PictureBox.BackgroundImageLayout = ImageLayout.None;
            PictureBox.Image = Properties.Resources._1rFunhoLcgjLzNJZx0R40dA1_wJ9uBEcZrbmN2vwkKfZ1tL_e3Tre3mgGSlEesdz712QzAktNdYYwxrudqeSsXXt;
            PictureBox.Location = new Point(6, 429);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(166, 129);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 12;
            PictureBox.TabStop = false;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersInfoGroupBox);
            Controls.Add(CustomersListGroupBox);
            Name = "CustomersTab";
            Size = new Size(1224, 658);
            CustomersListGroupBox.ResumeLayout(false);
            CustomersInfoGroupBox.ResumeLayout(false);
            CustomersInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersListGroupBox;
        private GroupBox CustomersInfoGroupBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox CustomersListBox;
        private Label FullNameLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private TextBox FullNameTextBox;
        private Controls.AddressControl addressControl1;
        private CheckBox IsPriorityCheckBox;
        private Button RemoveDiscountButton;
        private Button AddDiscountButton;
        private ListBox DiscountsListBox;
        private Label DiscountsLabel;
        private PictureBox PictureBox;
    }
}
