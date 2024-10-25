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
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(0, 18);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(288, 424);
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
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Location = new Point(712, 266);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(54, 15);
            AmountTextLabel.TabIndex = 4;
            AmountTextLabel.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(712, 281);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(23, 25);
            AmountLabel.TabIndex = 5;
            AmountLabel.Text = "0";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(362, 15);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(404, 23);
            CustomerComboBox.TabIndex = 6;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(0, 448);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 38);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add To Cart";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(294, 317);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(108, 38);
            CreateOrderButton.TabIndex = 9;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(544, 318);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(108, 37);
            RemoveButton.TabIndex = 10;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(658, 318);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(108, 37);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "Clear Cart";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(294, 79);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(472, 184);
            CartListBox.TabIndex = 12;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartListBox);
            Controls.Add(ClearButton);
            Controls.Add(RemoveButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(AddButton);
            Controls.Add(CustomerComboBox);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextLabel);
            Controls.Add(CartLabel);
            Controls.Add(CustomerLabel);
            Controls.Add(ItemsLabel);
            Controls.Add(ItemsListBox);
            Name = "CartsTab";
            Size = new Size(773, 489);
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
    }
}
