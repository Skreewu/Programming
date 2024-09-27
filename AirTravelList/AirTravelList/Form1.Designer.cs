namespace AirTravelList
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
            FlightListBox = new ListBox();
            SelectedFlightGroupBox = new GroupBox();
            FlightTimeTextBox = new TextBox();
            DepartureTimeLabel = new Label();
            TypeOfFlightLabel = new Label();
            FlightTimeLabel = new Label();
            DestinationLabel = new Label();
            DeparturePointLabel = new Label();
            TypeOfFlightComboBox = new ComboBox();
            DepartureTimePicker = new DateTimePicker();
            DestinationTextBox = new TextBox();
            DeparturePointTextBox = new TextBox();
            AddFlightButton = new Button();
            DeleteFlightButton = new Button();
            EditButton = new Button();
            testik = new ComboBox();
            SelectedFlightGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FlightListBox
            // 
            FlightListBox.FormattingEnabled = true;
            FlightListBox.ItemHeight = 15;
            FlightListBox.Location = new Point(12, 12);
            FlightListBox.Name = "FlightListBox";
            FlightListBox.Size = new Size(292, 229);
            FlightListBox.TabIndex = 0;
            FlightListBox.SelectedIndexChanged += FlightListBox_SelectedIndexChanged;
            // 
            // SelectedFlightGroupBox
            // 
            SelectedFlightGroupBox.Controls.Add(testik);
            SelectedFlightGroupBox.Controls.Add(FlightTimeTextBox);
            SelectedFlightGroupBox.Controls.Add(DepartureTimeLabel);
            SelectedFlightGroupBox.Controls.Add(TypeOfFlightLabel);
            SelectedFlightGroupBox.Controls.Add(FlightTimeLabel);
            SelectedFlightGroupBox.Controls.Add(DestinationLabel);
            SelectedFlightGroupBox.Controls.Add(DeparturePointLabel);
            SelectedFlightGroupBox.Controls.Add(TypeOfFlightComboBox);
            SelectedFlightGroupBox.Controls.Add(DepartureTimePicker);
            SelectedFlightGroupBox.Controls.Add(DestinationTextBox);
            SelectedFlightGroupBox.Controls.Add(DeparturePointTextBox);
            SelectedFlightGroupBox.Location = new Point(310, 12);
            SelectedFlightGroupBox.Name = "SelectedFlightGroupBox";
            SelectedFlightGroupBox.Size = new Size(380, 229);
            SelectedFlightGroupBox.TabIndex = 1;
            SelectedFlightGroupBox.TabStop = false;
            SelectedFlightGroupBox.Text = "Введите данные о рейсе";
            // 
            // FlightTimeTextBox
            // 
            FlightTimeTextBox.Location = new Point(12, 103);
            FlightTimeTextBox.Name = "FlightTimeTextBox";
            FlightTimeTextBox.Size = new Size(145, 23);
            FlightTimeTextBox.TabIndex = 11;
            FlightTimeTextBox.TextChanged += FlightTimeTextBox_TextChanged;
            // 
            // DepartureTimeLabel
            // 
            DepartureTimeLabel.AutoSize = true;
            DepartureTimeLabel.Location = new Point(12, 156);
            DepartureTimeLabel.Name = "DepartureTimeLabel";
            DepartureTimeLabel.Size = new Size(74, 15);
            DepartureTimeLabel.TabIndex = 10;
            DepartureTimeLabel.Text = "Дата вылета";
            // 
            // TypeOfFlightLabel
            // 
            TypeOfFlightLabel.AutoSize = true;
            TypeOfFlightLabel.Location = new Point(215, 85);
            TypeOfFlightLabel.Name = "TypeOfFlightLabel";
            TypeOfFlightLabel.Size = new Size(62, 15);
            TypeOfFlightLabel.TabIndex = 9;
            TypeOfFlightLabel.Text = "Тип рейса";
            // 
            // FlightTimeLabel
            // 
            FlightTimeLabel.AutoSize = true;
            FlightTimeLabel.Location = new Point(12, 85);
            FlightTimeLabel.Name = "FlightTimeLabel";
            FlightTimeLabel.Size = new Size(83, 15);
            FlightTimeLabel.TabIndex = 8;
            FlightTimeLabel.Text = "Время полёта";
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(215, 27);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(109, 15);
            DestinationLabel.TabIndex = 7;
            DestinationLabel.Text = "Пункт Назначения";
            // 
            // DeparturePointLabel
            // 
            DeparturePointLabel.AutoSize = true;
            DeparturePointLabel.Location = new Point(12, 27);
            DeparturePointLabel.Name = "DeparturePointLabel";
            DeparturePointLabel.Size = new Size(114, 15);
            DeparturePointLabel.TabIndex = 6;
            DeparturePointLabel.Text = "Пункт отправления";
            // 
            // TypeOfFlightComboBox
            // 
            TypeOfFlightComboBox.FormattingEnabled = true;
            TypeOfFlightComboBox.Items.AddRange(new object[] { "Internal", "International" });
            TypeOfFlightComboBox.Location = new Point(215, 103);
            TypeOfFlightComboBox.Name = "TypeOfFlightComboBox";
            TypeOfFlightComboBox.Size = new Size(145, 23);
            TypeOfFlightComboBox.TabIndex = 5;
            TypeOfFlightComboBox.SelectedIndexChanged += TypeOfFlightComboBox_SelectedIndexChanged;
            // 
            // DepartureTimePicker
            // 
            DepartureTimePicker.Location = new Point(12, 174);
            DepartureTimePicker.Name = "DepartureTimePicker";
            DepartureTimePicker.Size = new Size(145, 23);
            DepartureTimePicker.TabIndex = 3;
            DepartureTimePicker.Value = new DateTime(2024, 5, 25, 23, 59, 59, 0);
            DepartureTimePicker.ValueChanged += DepartureTimePicker_ValueChanged;
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(215, 45);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(145, 23);
            DestinationTextBox.TabIndex = 2;
            DestinationTextBox.TextChanged += DestinationTextBox_TextChanged;
            // 
            // DeparturePointTextBox
            // 
            DeparturePointTextBox.Location = new Point(12, 45);
            DeparturePointTextBox.Name = "DeparturePointTextBox";
            DeparturePointTextBox.Size = new Size(145, 23);
            DeparturePointTextBox.TabIndex = 2;
            DeparturePointTextBox.TextChanged += DeparturePointTextBox_TextChanged;
            // 
            // AddFlightButton
            // 
            AddFlightButton.Location = new Point(12, 246);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(67, 23);
            AddFlightButton.TabIndex = 2;
            AddFlightButton.Text = "Добавить";
            AddFlightButton.UseVisualStyleBackColor = true;
            AddFlightButton.Click += AddFlightButton_Click;
            // 
            // DeleteFlightButton
            // 
            DeleteFlightButton.Location = new Point(85, 246);
            DeleteFlightButton.Name = "DeleteFlightButton";
            DeleteFlightButton.Size = new Size(67, 23);
            DeleteFlightButton.TabIndex = 3;
            DeleteFlightButton.Text = "Удалить";
            DeleteFlightButton.UseVisualStyleBackColor = true;
            DeleteFlightButton.Click += DeleteFlightButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.LightGray;
            EditButton.Location = new Point(158, 246);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(146, 23);
            EditButton.TabIndex = 12;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // testik
            // 
            testik.FormattingEnabled = true;
            testik.Location = new Point(215, 174);
            testik.Name = "testik";
            testik.Size = new Size(145, 23);
            testik.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 281);
            Controls.Add(EditButton);
            Controls.Add(DeleteFlightButton);
            Controls.Add(AddFlightButton);
            Controls.Add(SelectedFlightGroupBox);
            Controls.Add(FlightListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(720, 320);
            MinimumSize = new Size(720, 320);
            Name = "MainForm";
            Text = "Авиаперелеты";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Leave += MainForm_Leave;
            SelectedFlightGroupBox.ResumeLayout(false);
            SelectedFlightGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox FlightListBox;
        private GroupBox SelectedFlightGroupBox;
        private TextBox DeparturePointTextBox;
        private TextBox DestinationTextBox;
        private DateTimePicker DepartureTimePicker;
        private ComboBox TypeOfFlightComboBox;
        private Label DepartureTimeLabel;
        private Label TypeOfFlightLabel;
        private Label FlightTimeLabel;
        private Label DestinationLabel;
        private Label DeparturePointLabel;
        private TextBox FlightTimeTextBox;
        private Button AddFlightButton;
        private Button DeleteFlightButton;
        private Button EditButton;
        private ComboBox testik;
    }
}
