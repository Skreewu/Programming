namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TabControl = new TabControl();
            ItemsTabControl = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            CustomersTabControl = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            CartsControl = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            OrderControl = new TabPage();
            ordersTab1 = new View.Tabs.OrdersTab();
            PriorityOrdersPage = new TabPage();
            priorityOrdersTab1 = new View.Tabs.PriorityOrdersTab();
            TabControl.SuspendLayout();
            ItemsTabControl.SuspendLayout();
            CustomersTabControl.SuspendLayout();
            CartsControl.SuspendLayout();
            OrderControl.SuspendLayout();
            PriorityOrdersPage.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabControl);
            TabControl.Controls.Add(CustomersTabControl);
            TabControl.Controls.Add(CartsControl);
            TabControl.Controls.Add(OrderControl);
            TabControl.Controls.Add(PriorityOrdersPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1184, 661);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ItemsTabControl
            // 
            ItemsTabControl.Controls.Add(itemsTab1);
            ItemsTabControl.Location = new Point(4, 24);
            ItemsTabControl.Name = "ItemsTabControl";
            ItemsTabControl.Padding = new Padding(3);
            ItemsTabControl.Size = new Size(1176, 633);
            ItemsTabControl.TabIndex = 0;
            ItemsTabControl.Text = "Items";
            ItemsTabControl.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1170, 627);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersTabControl
            // 
            CustomersTabControl.Controls.Add(customersTab1);
            CustomersTabControl.Location = new Point(4, 24);
            CustomersTabControl.Name = "CustomersTabControl";
            CustomersTabControl.Padding = new Padding(3);
            CustomersTabControl.Size = new Size(802, 505);
            CustomersTabControl.TabIndex = 1;
            CustomersTabControl.Text = "Customers";
            CustomersTabControl.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(796, 499);
            customersTab1.TabIndex = 0;
            // 
            // CartsControl
            // 
            CartsControl.Controls.Add(cartsTab1);
            CartsControl.Location = new Point(4, 24);
            CartsControl.Name = "CartsControl";
            CartsControl.Padding = new Padding(3);
            CartsControl.Size = new Size(802, 505);
            CartsControl.TabIndex = 2;
            CartsControl.Text = "Carts";
            CartsControl.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(796, 499);
            cartsTab1.TabIndex = 0;
            // 
            // OrderControl
            // 
            OrderControl.Controls.Add(ordersTab1);
            OrderControl.Location = new Point(4, 24);
            OrderControl.Name = "OrderControl";
            OrderControl.Padding = new Padding(3);
            OrderControl.Size = new Size(1176, 633);
            OrderControl.TabIndex = 3;
            OrderControl.Text = "Orders";
            OrderControl.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(1170, 627);
            ordersTab1.TabIndex = 0;
            // 
            // PriorityOrdersPage
            // 
            PriorityOrdersPage.Controls.Add(priorityOrdersTab1);
            PriorityOrdersPage.Location = new Point(4, 24);
            PriorityOrdersPage.Name = "PriorityOrdersPage";
            PriorityOrdersPage.Padding = new Padding(3);
            PriorityOrdersPage.Size = new Size(1176, 633);
            PriorityOrdersPage.TabIndex = 4;
            PriorityOrdersPage.Text = "Priority Orders";
            PriorityOrdersPage.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Dock = DockStyle.Fill;
            priorityOrdersTab1.Location = new Point(3, 3);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            priorityOrdersTab1.Size = new Size(1170, 627);
            priorityOrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(TabControl);
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            TabControl.ResumeLayout(false);
            ItemsTabControl.ResumeLayout(false);
            CustomersTabControl.ResumeLayout(false);
            CartsControl.ResumeLayout(false);
            OrderControl.ResumeLayout(false);
            PriorityOrdersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabControl;
        private TabPage CustomersTabControl;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage CartsControl;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage OrderControl;
        private View.Tabs.OrdersTab ordersTab1;
        private TabPage PriorityOrdersPage;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}
