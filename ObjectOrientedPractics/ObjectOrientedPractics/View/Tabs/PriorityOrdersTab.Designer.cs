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
            SelectedOrderLabel = new Label();
            IdLabel = new Label();
            OrderCreationDateLabel = new Label();
            StatusLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
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
            // OrderCreationDateLabel
            // 
            OrderCreationDateLabel.AutoSize = true;
            OrderCreationDateLabel.Location = new Point(5, 60);
            OrderCreationDateLabel.Name = "OrderCreationDateLabel";
            OrderCreationDateLabel.Size = new Size(51, 15);
            OrderCreationDateLabel.TabIndex = 2;
            OrderCreationDateLabel.Text = "Created:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 3);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 33);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 302);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(684, 414);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(681, 439);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(StatusLabel);
            Controls.Add(OrderCreationDateLabel);
            Controls.Add(IdLabel);
            Controls.Add(SelectedOrderLabel);
            Name = "PriorityOrdersTab";
            Size = new Size(795, 495);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedOrderLabel;
        private Label IdLabel;
        private Label OrderCreationDateLabel;
        private Label StatusLabel;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
