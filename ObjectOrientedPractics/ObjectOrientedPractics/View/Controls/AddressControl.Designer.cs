namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            AddressLabel = new Label();
            IndexLabel = new Label();
            CountryLabel = new Label();
            CityLabel = new Label();
            StreetLabel = new Label();
            BuildingLabel = new Label();
            ApartmentLabel = new Label();
            IndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(8, 9);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(109, 15);
            AddressLabel.TabIndex = 0;
            AddressLabel.Text = "Delivery Address";
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Location = new Point(8, 38);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(65, 15);
            IndexLabel.TabIndex = 1;
            IndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(8, 76);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(250, 76);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 3;
            CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(8, 118);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 4;
            StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(8, 161);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 5;
            BuildingLabel.Text = "Building:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(180, 161);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(67, 15);
            ApartmentLabel.TabIndex = 6;
            ApartmentLabel.Text = "Apartment:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(79, 35);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(100, 23);
            IndexTextBox.TabIndex = 7;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(79, 73);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(140, 23);
            CountryTextBox.TabIndex = 8;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(287, 73);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(140, 23);
            CityTextBox.TabIndex = 9;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(79, 115);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(348, 23);
            StreetTextBox.TabIndex = 10;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(79, 158);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(83, 23);
            BuildingTextBox.TabIndex = 11;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApartmentTextBox.Location = new Point(253, 158);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(83, 23);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(IndexTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountryLabel);
            Controls.Add(IndexLabel);
            Controls.Add(AddressLabel);
            Name = "AddressControl";
            Size = new Size(430, 190);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddressLabel;
        private Label IndexLabel;
        private Label CountryLabel;
        private Label CityLabel;
        private Label StreetLabel;
        private Label BuildingLabel;
        private Label ApartmentLabel;
        private TextBox IndexTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
    }
}
