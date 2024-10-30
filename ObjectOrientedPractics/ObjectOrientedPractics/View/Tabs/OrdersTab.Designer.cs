namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Model.Address address1 = new Model.Address();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            OrdersLabel = new Label();
            OrdersDataGrid = new DataGridView();
            IdTextBox = new TextBox();
            DateTextBox = new TextBox();
            StatusLabel = new Label();
            StatusComboBox = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            DateLabel = new Label();
            ItemsListBox = new ListBox();
            OrderItemsLabel = new Label();
            IdLabel = new Label();
            SelectedOrderLabel = new Label();
            DeliveryTimeLabel = new Label();
            PriorityOptionsLabel = new Label();
            DeliveryTimeComboBox = new ComboBox();
            AmountTextLabel = new Label();
            AmountLabel = new Label();
            PriorityOptionsPanel = new Panel();
            IsPriority = new DataGridViewTextBoxColumn();
            IdColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGrid).BeginInit();
            PriorityOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrdersLabel.Location = new Point(3, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(47, 15);
            OrdersLabel.TabIndex = 0;
            OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGrid
            // 
            OrdersDataGrid.AllowUserToAddRows = false;
            OrdersDataGrid.AllowUserToResizeRows = false;
            OrdersDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGrid.Columns.AddRange(new DataGridViewColumn[] { IsPriority, IdColumn, DateColumn, NameColumn, AddressColumn, AmountColumn, StatusColumn });
            OrdersDataGrid.Location = new Point(3, 21);
            OrdersDataGrid.MultiSelect = false;
            OrdersDataGrid.Name = "OrdersDataGrid";
            OrdersDataGrid.Size = new Size(641, 603);
            OrdersDataGrid.TabIndex = 13;
            OrdersDataGrid.RowHeaderMouseClick += OrdersDataGrid_RowHeaderMouseClick;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            IdTextBox.Location = new Point(734, 28);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(138, 23);
            IdTextBox.TabIndex = 9;
            // 
            // DateTextBox
            // 
            DateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DateTextBox.Location = new Point(734, 54);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.ReadOnly = true;
            DateTextBox.Size = new Size(138, 23);
            DateTextBox.TabIndex = 10;
            // 
            // StatusLabel
            // 
            StatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(659, 86);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status:";
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(734, 83);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(138, 23);
            StatusComboBox.TabIndex = 11;
            // 
            // addressControl1
            // 
            address1.Apartment = "0";
            address1.Building = "0";
            address1.City = "Город";
            address1.Country = "Страна";
            address1.Index = 100000;
            address1.Street = "Улица";
            addressControl1.Address = address1;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            addressControl1.ApartmentTextBoxValue = "0";
            addressControl1.BuildingTextBoxValue = "0";
            addressControl1.CityTextBoxValue = "Город";
            addressControl1.CountryTextBoxValue = "Страна";
            addressControl1.ImeMode = ImeMode.NoControl;
            addressControl1.IndexTextBoxValue = "100000";
            addressControl1.Location = new Point(650, 105);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(517, 183);
            addressControl1.StreetTextBoxValue = "Улица";
            addressControl1.TabIndex = 8;
            addressControl1.Load += addressControl1_Load;
            // 
            // DateLabel
            // 
            DateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(659, 57);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(51, 15);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Created:";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(656, 314);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(511, 184);
            ItemsListBox.TabIndex = 12;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(656, 291);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(77, 15);
            OrderItemsLabel.TabIndex = 5;
            OrderItemsLabel.Text = "Order Items";
            // 
            // IdLabel
            // 
            IdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(659, 28);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(24, 15);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "ID: ";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(659, 10);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(95, 15);
            SelectedOrderLabel.TabIndex = 1;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(0, 21);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(81, 15);
            DeliveryTimeLabel.TabIndex = 16;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriorityOptionsLabel.Location = new Point(0, 0);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(104, 15);
            PriorityOptionsLabel.TabIndex = 15;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DeliveryTimeComboBox.Location = new Point(87, 18);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(121, 23);
            DeliveryTimeComboBox.TabIndex = 17;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountTextLabel.Location = new Point(1086, 501);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(60, 15);
            AmountTextLabel.TabIndex = 18;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(1086, 516);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(23, 25);
            AmountLabel.TabIndex = 19;
            AmountLabel.Text = "0";
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriorityOptionsPanel.Controls.Add(PriorityOptionsLabel);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Location = new Point(949, 10);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(208, 41);
            PriorityOptionsPanel.TabIndex = 20;
            PriorityOptionsPanel.Visible = false;
            // 
            // IsPriority
            // 
            IsPriority.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IsPriority.DefaultCellStyle = dataGridViewCellStyle1;
            IsPriority.HeaderText = "";
            IsPriority.Name = "IsPriority";
            IsPriority.SortMode = DataGridViewColumnSortMode.NotSortable;
            IsPriority.Width = 50;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.Name = "IdColumn";
            IdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Created";
            DateColumn.Name = "DateColumn";
            DateColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Customer Full Name";
            NameColumn.Name = "NameColumn";
            NameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AddressColumn
            // 
            AddressColumn.HeaderText = "Address";
            AddressColumn.Name = "AddressColumn";
            AddressColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "Amount";
            AmountColumn.Name = "AmountColumn";
            AmountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "OrderStatus";
            StatusColumn.Name = "StatusColumn";
            StatusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PriorityOptionsPanel);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextLabel);
            Controls.Add(OrdersDataGrid);
            Controls.Add(SelectedOrderLabel);
            Controls.Add(OrdersLabel);
            Controls.Add(IdLabel);
            Controls.Add(IdTextBox);
            Controls.Add(OrderItemsLabel);
            Controls.Add(DateTextBox);
            Controls.Add(ItemsListBox);
            Controls.Add(StatusLabel);
            Controls.Add(StatusComboBox);
            Controls.Add(DateLabel);
            Controls.Add(addressControl1);
            Name = "OrdersTab";
            Size = new Size(1170, 627);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGrid).EndInit();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrdersLabel;
        private DataGridView OrdersDataGrid;
        private TextBox IdTextBox;
        private TextBox DateTextBox;
        private Label StatusLabel;
        private ComboBox StatusComboBox;
        private Controls.AddressControl addressControl1;
        private Label DateLabel;
        private ListBox ItemsListBox;
        private Label OrderItemsLabel;
        private Label IdLabel;
        private Label SelectedOrderLabel;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionsLabel;
        private ComboBox DeliveryTimeComboBox;
        private Label AmountTextLabel;
        private Label AmountLabel;
        private Panel PriorityOptionsPanel;
        private DataGridViewTextBoxColumn IsPriority;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn StatusColumn;
    }
}
