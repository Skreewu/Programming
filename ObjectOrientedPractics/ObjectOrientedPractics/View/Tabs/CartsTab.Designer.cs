namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            CustomerLabel = new Label();
            CartLabel = new Label();
            AmountTextLabel = new Label();
            AmountLabel = new Label();
            CustomerComboBox = new ComboBox();
            AddButton = new Button();
            CreateOrderButton = new Button();
            RemoveButton = new Button();
            ClearButton = new Button();
            CartListBox = new ListBox();
            DiscountsListBox = new CheckedListBox();
            DiscountLabel = new Label();
            DiscountAmountTextLabel = new Label();
            DiscountAmountLabel = new Label();
            TotalLabel = new Label();
            TotalTextLabel = new Label();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(0, 18);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(288, 559);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9F);
            ItemsLabel.Location = new Point(3, 0);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(36, 15);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(294, 18);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(62, 15);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "Customer:";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(294, 61);
            CartLabel.Name = "CartLabel";
            CartLabel.RightToLeft = RightToLeft.No;
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 3;
            CartLabel.Text = "Cart:";
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountTextLabel.Location = new Point(1109, 326);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(60, 15);
            AmountTextLabel.TabIndex = 4;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(1080, 341);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(23, 25);
            AmountLabel.TabIndex = 5;
            AmountLabel.Text = "0";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(362, 15);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(801, 23);
            CustomerComboBox.TabIndex = 6;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(0, 586);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 38);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add To Cart";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.AutoSize = true;
            CreateOrderButton.Location = new Point(294, 369);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(108, 37);
            CreateOrderButton.TabIndex = 9;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.Location = new Point(945, 369);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(108, 37);
            RemoveButton.TabIndex = 10;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.AutoEllipsis = true;
            ClearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearButton.Location = new Point(1059, 369);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(108, 37);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "Clear Cart";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(294, 79);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(869, 244);
            CartListBox.TabIndex = 12;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.BackColor = SystemColors.Control;
            DiscountsListBox.BorderStyle = BorderStyle.None;
            DiscountsListBox.CheckOnClick = true;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.Location = new Point(294, 451);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(275, 126);
            DiscountsListBox.TabIndex = 13;
            DiscountsListBox.ItemCheck += DiscountsListBox_ItemCheck;
            DiscountsListBox.SelectedIndexChanged += DiscountsListBox_SelectedIndexChanged;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountLabel.Location = new Point(294, 426);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(71, 15);
            DiscountLabel.TabIndex = 14;
            DiscountLabel.Text = "Discounts:";
            // 
            // DiscountAmountTextLabel
            // 
            DiscountAmountTextLabel.AutoSize = true;
            DiscountAmountTextLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountTextLabel.Location = new Point(1050, 426);
            DiscountAmountTextLabel.Name = "DiscountAmountTextLabel";
            DiscountAmountTextLabel.Size = new Size(117, 15);
            DiscountAmountTextLabel.TabIndex = 15;
            DiscountAmountTextLabel.Text = "Discount Amount:";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(1080, 441);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(23, 25);
            DiscountAmountLabel.TabIndex = 5;
            DiscountAmountLabel.Text = "0";
            DiscountAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Right;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(1080, 590);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(23, 25);
            TotalLabel.TabIndex = 5;
            TotalLabel.Text = "0";
            TotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalTextLabel.Location = new Point(1050, 575);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(117, 15);
            TotalTextLabel.TabIndex = 15;
            TotalTextLabel.Text = "Discount Amount:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TotalTextLabel);
            Controls.Add(DiscountAmountTextLabel);
            Controls.Add(DiscountLabel);
            Controls.Add(DiscountsListBox);
            Controls.Add(CartListBox);
            Controls.Add(ClearButton);
            Controls.Add(RemoveButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(AddButton);
            Controls.Add(TotalLabel);
            Controls.Add(CustomerComboBox);
            Controls.Add(DiscountAmountLabel);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextLabel);
            Controls.Add(CartLabel);
            Controls.Add(CustomerLabel);
            Controls.Add(ItemsLabel);
            Controls.Add(ItemsListBox);
            Name = "CartsTab";
            Size = new Size(1170, 627);
            Load += CartsTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private Label CustomerLabel;
        private Label CartLabel;
        private Label AmountTextLabel;
        private Label AmountLabel;
        private ComboBox CustomerComboBox;
        private Button AddButton;
        private Button CreateOrderButton;
        private Button RemoveButton;
        private Button ClearButton;
        private ListBox CartListBox;
        private CheckedListBox DiscountsListBox;
        private Label DiscountLabel;
        private Label DiscountAmountTextLabel;
        private Label DiscountAmountLabel;
        private Label TotalLabel;
        private Label TotalTextLabel;
    }
}
