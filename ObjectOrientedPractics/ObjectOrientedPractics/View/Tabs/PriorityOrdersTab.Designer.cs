namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            Model.Address address5 = new Model.Address();
            SelectedOrderLabel = new Label();
            IdLabel = new Label();
            CreationTimeLabel = new Label();
            StatusLabel = new Label();
            PriorityOptionsLabel = new Label();
            DeliveryTimeLabel = new Label();
            OrderItemsLabel = new Label();
            AmountTextLabel = new Label();
            AmountLabel = new Label();
            addressControl1 = new Controls.AddressControl();
            OrderItemsListBox = new ListBox();
            IdTextBox = new TextBox();
            CreationTimeTextBox = new TextBox();
            DeliveryTimeComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            SuspendLayout();
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(8, 4);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(92, 15);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "SelectedOrder";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(4, 33);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // CreationTimeLabel
            // 
            CreationTimeLabel.AutoSize = true;
            CreationTimeLabel.Location = new Point(5, 60);
            CreationTimeLabel.Name = "CreationTimeLabel";
            CreationTimeLabel.Size = new Size(51, 15);
            CreationTimeLabel.TabIndex = 2;
            CreationTimeLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(7, 89);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriorityOptionsLabel.Location = new Point(292, 4);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(133, 15);
            PriorityOptionsLabel.TabIndex = 4;
            PriorityOptionsLabel.Text = "PriorityOptionsLabel";
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(292, 33);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(81, 15);
            DeliveryTimeLabel.TabIndex = 5;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(8, 300);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(77, 15);
            OrderItemsLabel.TabIndex = 6;
            OrderItemsLabel.Text = "Order Items";
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountTextLabel.Location = new Point(527, 415);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(60, 15);
            AmountTextLabel.TabIndex = 7;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(527, 430);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(23, 25);
            AmountLabel.TabIndex = 8;
            AmountLabel.Text = "0";
            // 
            // addressControl1
            // 
            address5.Apartment = "";
            address5.Building = "";
            address5.City = "";
            address5.Country = "";
            address5.Index = 100000;
            address5.Street = "";
            addressControl1.Address = address5;
            addressControl1.ApartmentTextBoxValue = "";
            addressControl1.BuildingTextBoxValue = "";
            addressControl1.CityTextBoxValue = "";
            addressControl1.CountryTextBoxValue = "";
            addressControl1.IndexTextBoxValue = "";
            addressControl1.Location = new Point(5, 107);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(583, 190);
            addressControl1.StreetTextBoxValue = "";
            addressControl1.TabIndex = 9;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(11, 318);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(579, 94);
            OrderItemsListBox.TabIndex = 10;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(62, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(184, 23);
            IdTextBox.TabIndex = 11;
            // 
            // CreationTimeTextBox
            // 
            CreationTimeTextBox.Location = new Point(62, 57);
            CreationTimeTextBox.Name = "CreationTimeTextBox";
            CreationTimeTextBox.ReadOnly = true;
            CreationTimeTextBox.Size = new Size(184, 23);
            CreationTimeTextBox.TabIndex = 12;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(379, 30);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(184, 23);
            DeliveryTimeComboBox.TabIndex = 13;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(62, 86);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(184, 23);
            StatusComboBox.TabIndex = 14;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(8, 461);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(98, 31);
            AddItemButton.TabIndex = 15;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(148, 461);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(98, 31);
            RemoveItemButton.TabIndex = 16;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Location = new Point(489, 461);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(98, 31);
            ClearOrderButton.TabIndex = 17;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearOrderButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(StatusComboBox);
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(CreationTimeTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(OrderItemsListBox);
            Controls.Add(addressControl1);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextLabel);
            Controls.Add(OrderItemsLabel);
            Controls.Add(DeliveryTimeLabel);
            Controls.Add(PriorityOptionsLabel);
            Controls.Add(StatusLabel);
            Controls.Add(CreationTimeLabel);
            Controls.Add(IdLabel);
            Controls.Add(SelectedOrderLabel);
            Name = "PriorityOrdersTab";
            Size = new Size(590, 495);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedOrderLabel;
        private Label IdLabel;
        private Label CreationTimeLabel;
        private Label StatusLabel;
        private Label PriorityOptionsLabel;
        private Label DeliveryTimeLabel;
        private Label OrderItemsLabel;
        private Label AmountTextLabel;
        private Label AmountLabel;
        private Controls.AddressControl addressControl1;
        private ListBox OrderItemsListBox;
        private TextBox IdTextBox;
        private TextBox CreationTimeTextBox;
        private ComboBox DeliveryTimeComboBox;
        private ComboBox StatusComboBox;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
    }
}
