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
            OrdersLabel = new Label();
            SelectedOrderLabel = new Label();
            IdLabel = new Label();
            DateLabel = new Label();
            StatusLabel = new Label();
            OrderItemsLabel = new Label();
            AmountTextLabel = new Label();
            AmountLabel = new Label();
            addressControl1 = new Controls.AddressControl();
            IdTextBox = new TextBox();
            DateTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            ItemsListBox = new ListBox();
            OrdersDataGrid = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGrid).BeginInit();
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
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(349, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(95, 15);
            SelectedOrderLabel.TabIndex = 1;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(349, 25);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(24, 15);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "ID: ";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(349, 54);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(51, 15);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(349, 83);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status:";
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(349, 298);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(77, 15);
            OrderItemsLabel.TabIndex = 5;
            OrderItemsLabel.Text = "Order Items";
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Location = new Point(708, 440);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(54, 15);
            AmountTextLabel.TabIndex = 6;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(739, 455);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.RightToLeft = RightToLeft.Yes;
            AmountLabel.Size = new Size(23, 25);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "0";
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
            addressControl1.ImeMode = ImeMode.NoControl;
            addressControl1.Location = new Point(340, 105);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(430, 190);
            addressControl1.TabIndex = 8;
            addressControl1.Load += addressControl1_Load;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(424, 22);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(138, 23);
            IdTextBox.TabIndex = 9;
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(424, 51);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.ReadOnly = true;
            DateTextBox.Size = new Size(138, 23);
            DateTextBox.TabIndex = 10;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "New", "Processing", "Assembly", "Sent", "Delivered,", "Returned", "Abandoned" });
            StatusComboBox.Location = new Point(424, 80);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(138, 23);
            StatusComboBox.TabIndex = 11;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(349, 316);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(413, 124);
            ItemsListBox.TabIndex = 12;
            // 
            // OrdersDataGrid
            // 
            OrdersDataGrid.AllowUserToAddRows = false;
            OrdersDataGrid.AllowUserToResizeRows = false;
            OrdersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGrid.Columns.AddRange(new DataGridViewColumn[] { IdColumn, DateColumn, NameColumn, AddressColumn, AmountColumn, StatusColumn });
            OrdersDataGrid.Location = new Point(3, 18);
            OrdersDataGrid.MultiSelect = false;
            OrdersDataGrid.Name = "OrdersDataGrid";
            OrdersDataGrid.Size = new Size(331, 459);
            OrdersDataGrid.TabIndex = 13;
            OrdersDataGrid.RowHeaderMouseClick += OrdersDataGrid_RowHeaderMouseClick;
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
            Controls.Add(OrdersDataGrid);
            Controls.Add(ItemsListBox);
            Controls.Add(StatusComboBox);
            Controls.Add(DateTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(addressControl1);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextLabel);
            Controls.Add(OrderItemsLabel);
            Controls.Add(StatusLabel);
            Controls.Add(DateLabel);
            Controls.Add(IdLabel);
            Controls.Add(SelectedOrderLabel);
            Controls.Add(OrdersLabel);
            Name = "OrdersTab";
            Size = new Size(770, 480);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrdersLabel;
        private Label SelectedOrderLabel;
        private Label IdLabel;
        private Label DateLabel;
        private Label StatusLabel;
        private Label OrderItemsLabel;
        private Label AmountTextLabel;
        private Label AmountLabel;
        private Controls.AddressControl addressControl1;
        private TextBox IdTextBox;
        private TextBox DateTextBox;
        private ComboBox StatusComboBox;
        private ListBox ItemsListBox;
        private DataGridView OrdersDataGrid;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn StatusColumn;
    }
}
