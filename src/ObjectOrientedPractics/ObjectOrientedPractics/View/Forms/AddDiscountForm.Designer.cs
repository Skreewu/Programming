namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiscountLabel = new Label();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            CancelButton = new Button();
            OkButton = new Button();
            SuspendLayout();
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountLabel.Location = new Point(12, 9);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(114, 15);
            DiscountLabel.TabIndex = 0;
            DiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 34);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(77, 31);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(195, 23);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(185, 70);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(87, 29);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(92, 70);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(87, 29);
            OkButton.TabIndex = 4;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(DiscountLabel);
            Name = "AddDiscountForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DiscountLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Button CancelButton;
        private Button OkButton;
    }
}