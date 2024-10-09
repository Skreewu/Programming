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
            tabControl1 = new TabControl();
            ItemsTabControl = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            CustomersTabControl = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            ItemsTabControl.SuspendLayout();
            CustomersTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTabControl);
            tabControl1.Controls.Add(CustomersTabControl);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(810, 533);
            tabControl1.TabIndex = 0;
            // 
            // ItemsTabControl
            // 
            ItemsTabControl.Controls.Add(itemsTab1);
            ItemsTabControl.Location = new Point(4, 24);
            ItemsTabControl.Name = "ItemsTabControl";
            ItemsTabControl.Padding = new Padding(3);
            ItemsTabControl.Size = new Size(802, 505);
            ItemsTabControl.TabIndex = 0;
            ItemsTabControl.Text = "Items";
            ItemsTabControl.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(796, 499);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 533);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            tabControl1.ResumeLayout(false);
            ItemsTabControl.ResumeLayout(false);
            CustomersTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemsTabControl;
        private TabPage CustomersTabControl;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
    }
}
