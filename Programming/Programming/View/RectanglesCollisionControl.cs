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
    public partial class RectanglesCollisionControl : UserControl
    {
        // Каждый элемент массива представляет собой объект типа Type, который представляет информацию о типе данных во время выполнения программы
        List<RectangleCustom> _rectangles = new List<RectangleCustom>();
        RectangleCustom _currentRectangle = new RectangleCustom();
        List<Panel> _rectanglePanels = new List<Panel>();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                RectangleCustom rectangle = RectangleFactory.Randomize();
                _rectangles.Add(rectangle);
                CanvasRectangleListBox.Items.Add(rectangle);
                Panel panelRectangle = new Panel();
                panelRectangle.Location = new Point((int)(rectangle.Center.X - rectangle.Width / 2), (int)(rectangle.Center.Y - rectangle.Length / 2));
                panelRectangle.Width = (int)rectangle.Width;
                panelRectangle.Height = (int)rectangle.Length;
                panelRectangle.BackColor = AppColors.greenRectangle;
                _rectanglePanels.Add(panelRectangle);
                Canvas.Controls.Add(panelRectangle);
            }
            FindCollisions();
        }
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            RectangleCustom rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);
            CanvasRectangleListBox.Items.Add(rectangle);
            Panel panelRectangle = new Panel();
            panelRectangle.Location = new Point((int)(rectangle.Center.X - rectangle.Width / 2), (int)(rectangle.Center.Y - rectangle.Length / 2));
            panelRectangle.Width = (int)rectangle.Width;
            panelRectangle.Height = (int)rectangle.Length;
            panelRectangle.BackColor = AppColors.greenRectangle;
            Canvas.Controls.Add(panelRectangle);
            _rectanglePanels.Add(panelRectangle);
            FindCollisions();
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            int index = CanvasRectangleListBox.SelectedIndex;
            if (index == -1) { return; }
            _rectangles.RemoveAt(index);
            CanvasRectangleListBox.Items.RemoveAt(index);
            ClearRectangleInfo();
            _rectanglePanels.RemoveAt(index);
            Canvas.Controls.RemoveAt(index);
            FindCollisions();
        }

        private void CanvasRectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CanvasRectangleListBox.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[CanvasRectangleListBox.SelectedIndex];
            RectangleCustom rectangle = (RectangleCustom)CanvasRectangleListBox.SelectedItem;
            CanvasLengthTextBox.Text = rectangle.Length.ToString();
            CanvasWidthTextBox.Text = rectangle.Width.ToString();
            CanvasIdTextBox.Text = rectangle.Id.ToString();
            CanvasXTextBox.Text = rectangle.Center.X.ToString();
            CanvasYTextBox.Text = rectangle.Center.Y.ToString();
        }

        private void CanvasXTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CanvasRectangleListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            try
            {
                CanvasXTextBox.BackColor = AppColors.basicWhite;
                int x = int.Parse(CanvasXTextBox.Text);
                _currentRectangle.Center.X = x;
                RectangleCustom rectangle = (RectangleCustom)CanvasRectangleListBox.SelectedItem;
                _rectanglePanels[index].Location = new Point((int)(x - rectangle.Width / 2), (int)(rectangle.Center.Y - rectangle.Length / 2));
                UpdateRectangleInfo();
                FindCollisions();
            }
            catch (Exception)
            {
                CanvasXTextBox.BackColor = AppColors.errors;
            }
        }

        private void CanvasYTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CanvasRectangleListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            try
            {
                CanvasYTextBox.BackColor = AppColors.basicWhite;
                int y = int.Parse(CanvasYTextBox.Text);
                _currentRectangle.Center.Y = y;
                RectangleCustom rectangle = (RectangleCustom)CanvasRectangleListBox.SelectedItem;
                _rectanglePanels[index].Location = new Point((int)(rectangle.Center.X - rectangle.Width / 2), (int)(y - rectangle.Length / 2));
                UpdateRectangleInfo();
                FindCollisions();
            }
            catch (Exception)
            {
                CanvasYTextBox.BackColor = AppColors.errors;
            }
        }

        private void CanvasLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CanvasRectangleListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            try
            {
                CanvasLengthTextBox.BackColor = AppColors.basicWhite;
                int length = int.Parse(CanvasLengthTextBox.Text);
                _currentRectangle.Length = length;
                RectangleCustom rectangle = (RectangleCustom)CanvasRectangleListBox.SelectedItem;
                _rectanglePanels[index].Height = length;
                UpdateRectangleInfo();
                FindCollisions();
            }
            catch (Exception)
            {
                CanvasLengthTextBox.BackColor = AppColors.errors;
            }
        }

        private void CanvasWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CanvasRectangleListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            try
            {
                CanvasWidthTextBox.BackColor = AppColors.basicWhite;
                int width = int.Parse(CanvasWidthTextBox.Text);
                _currentRectangle.Width = width;
                RectangleCustom rectangle = (RectangleCustom)CanvasRectangleListBox.SelectedItem;
                _rectanglePanels[index].Width = width;
                UpdateRectangleInfo();
                FindCollisions();
            }
            catch (Exception)
            {
                CanvasWidthTextBox.BackColor = AppColors.errors;
            }
        }
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (i != j && CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) == true)
                    {
                        _rectanglePanels[i].BackColor = AppColors.errors;
                        _rectanglePanels[j].BackColor = AppColors.errors;
                    }
                }
            }
        }
        private void UpdateRectangleInfo()
        {
            int index = CanvasRectangleListBox.Items.IndexOf(_currentRectangle);
            if (index == -1) return;
            CanvasRectangleListBox.Items.RemoveAt(index);
            CanvasRectangleListBox.Items.Insert(index, _currentRectangle);
            CanvasRectangleListBox.SelectedIndex = index;
        }
        private void ClearRectangleInfo()
        {
            CanvasLengthTextBox.Clear();
            CanvasWidthTextBox.Clear();
            CanvasIdTextBox.Clear();
            CanvasXTextBox.Clear();
            CanvasYTextBox.Clear();
        }
    }
}
