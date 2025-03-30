using Programming.Model;
using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class RectanglesClasses : UserControl
    {
        List<RectangleCustom> _rectangles = new List<RectangleCustom>();
        RectangleCustom _currentRectangle = new RectangleCustom();
        public RectanglesClasses()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                RectangleCustom rectangle = RectangleFactory.Randomize();
                RectanglesListBox.Items.Add(rectangle);
                _rectangles.Add(rectangle);
            }
        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectangleCustom rectangle = (RectangleCustom)RectanglesListBox.SelectedItem;
            LengthTextBox.Text = rectangle.Length.ToString();
            WidthTextBox.Text = rectangle.Width.ToString();
            ColourTextBox.Text = rectangle.Color.ToString();
            XCoordinateTextBox.Text = rectangle.Center.X.ToString();
            YCoordinateTextBox.Text = rectangle.Center.Y.ToString();
            RectangleIDLabel.Text = $"Rectangle ID: {rectangle.Id}";
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                LengthTextBox.BackColor = AppColors.basicWhite;
                int length = int.Parse(LengthTextBox.Text);
                _currentRectangle.Length = length;
            }
            catch (Exception)
            {
                LengthTextBox.BackColor = AppColors.errors;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                WidthTextBox.BackColor = AppColors.basicWhite;
                int width = int.Parse(WidthTextBox.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = AppColors.errors;
            }
        }

        private void ColourListBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                ColourTextBox.BackColor = AppColors.basicWhite;
                Colour colour = (Colour)Enum.Parse(typeof(Colour), ColourTextBox.Text);
                _currentRectangle.Color = colour;
            }
            catch (Exception)
            {
                ColourTextBox.BackColor = AppColors.errors;
            }
        }
        /// <summary>
        /// Находит прямоугольник с наибольшей шириной среди списка.
        /// </summary>
        /// <param name="rectangles">Список прямоугольников.</param>
        /// <returns>Возвращает индекс прямоугольника с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(List<RectangleCustom> rectangles)
        {
            double maxWidth = Double.NegativeInfinity;
            int maxWidthIndex = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxWidthIndex = i;
                }

            }
            return maxWidthIndex;
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = index;
        }

        private void RectanglesClasses_Load(object sender, EventArgs e)
        {

        }
    }
}
