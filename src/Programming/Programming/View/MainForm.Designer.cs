namespace Programming
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
            components = new System.ComponentModel.Container();
            Enums = new TabPage();
            enumerations1 = new View.Enumerations();
            SeasonHandle = new GroupBox();
            seasonHandle1 = new View.SeasonHandle();
            WeekdayParsing = new GroupBox();
            weekdayParsing1 = new View.WeekdayParsing();
            tabControl1 = new TabControl();
            Classes = new TabPage();
            FilmsGroupBox = new GroupBox();
            movies1 = new View.Movies();
            RectanglesGroupBox = new GroupBox();
            rectanglesClasses1 = new View.RectanglesClasses();
            tabRectangles = new TabPage();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rectanglesCollisionControl1 = new View.RectanglesCollisionControl();
            Enums.SuspendLayout();
            SeasonHandle.SuspendLayout();
            WeekdayParsing.SuspendLayout();
            tabControl1.SuspendLayout();
            Classes.SuspendLayout();
            FilmsGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            tabRectangles.SuspendLayout();
            SuspendLayout();
            // 
            // Enums
            // 
            Enums.Controls.Add(enumerations1);
            Enums.Controls.Add(SeasonHandle);
            Enums.Controls.Add(WeekdayParsing);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 422);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // enumerations1
            // 
            enumerations1.Location = new Point(8, 0);
            enumerations1.Name = "enumerations1";
            enumerations1.Size = new Size(780, 239);
            enumerations1.TabIndex = 1;
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(seasonHandle1);
            SeasonHandle.Location = new Point(377, 249);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(411, 173);
            SeasonHandle.TabIndex = 7;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // seasonHandle1
            // 
            seasonHandle1.Location = new Point(6, 36);
            seasonHandle1.Name = "seasonHandle1";
            seasonHandle1.Size = new Size(235, 52);
            seasonHandle1.TabIndex = 1;
            // 
            // WeekdayParsing
            // 
            WeekdayParsing.Controls.Add(weekdayParsing1);
            WeekdayParsing.Location = new Point(15, 249);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Size = new Size(344, 173);
            WeekdayParsing.TabIndex = 6;
            WeekdayParsing.TabStop = false;
            WeekdayParsing.Text = "Weekday Parsing";
            // 
            // weekdayParsing1
            // 
            weekdayParsing1.Location = new Point(6, 36);
            weekdayParsing1.Name = "weekdayParsing1";
            weekdayParsing1.Size = new Size(332, 129);
            weekdayParsing1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(Classes);
            tabControl1.Controls.Add(tabRectangles);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Classes
            // 
            Classes.BackColor = Color.White;
            Classes.Controls.Add(FilmsGroupBox);
            Classes.Controls.Add(RectanglesGroupBox);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(792, 422);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            // 
            // FilmsGroupBox
            // 
            FilmsGroupBox.Controls.Add(movies1);
            FilmsGroupBox.Location = new Point(348, 6);
            FilmsGroupBox.Name = "FilmsGroupBox";
            FilmsGroupBox.Size = new Size(436, 224);
            FilmsGroupBox.TabIndex = 8;
            FilmsGroupBox.TabStop = false;
            FilmsGroupBox.Text = "Films";
            // 
            // movies1
            // 
            movies1.Dock = DockStyle.Fill;
            movies1.Location = new Point(3, 19);
            movies1.Name = "movies1";
            movies1.Size = new Size(430, 202);
            movies1.TabIndex = 9;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(rectanglesClasses1);
            RectanglesGroupBox.Location = new Point(8, 6);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(304, 338);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // rectanglesClasses1
            // 
            rectanglesClasses1.Dock = DockStyle.Fill;
            rectanglesClasses1.Location = new Point(3, 19);
            rectanglesClasses1.Name = "rectanglesClasses1";
            rectanglesClasses1.Size = new Size(298, 316);
            rectanglesClasses1.TabIndex = 1;
            // 
            // tabRectangles
            // 
            tabRectangles.Controls.Add(rectanglesCollisionControl1);
            tabRectangles.Location = new Point(4, 24);
            tabRectangles.Name = "tabRectangles";
            tabRectangles.Padding = new Padding(3);
            tabRectangles.Size = new Size(792, 422);
            tabRectangles.TabIndex = 2;
            tabRectangles.Text = "Rectangles";
            tabRectangles.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(786, 416);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            Text = "Form1";
            Enums.ResumeLayout(false);
            SeasonHandle.ResumeLayout(false);
            WeekdayParsing.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Classes.ResumeLayout(false);
            FilmsGroupBox.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            tabRectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Enums;
        private TabControl tabControl1;
        private GroupBox WeekdayParsing;
        private GroupBox SeasonHandle;
        private TabPage Classes;
        private GroupBox RectanglesGroupBox;
        private GroupBox FilmsGroupBox;
        private TabPage tabRectangles;
        private ContextMenuStrip contextMenuStrip1;
        private View.Enumerations enumerations1;
        private View.WeekdayParsing weekdayParsing1;
        private View.SeasonHandle seasonHandle1;
        private View.RectanglesClasses rectanglesClasses1;
        private View.Movies movies1;
        private View.RectanglesCollisionControl rectanglesCollisionControl1;
    }
}