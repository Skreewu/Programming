using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class CollisionManager
    {
        public bool IsCollision(RectangleCustom rectangle1, RectangleCustom rectangle2)
        {
            double dx = Math.Abs(rectangle2.Center.X - rectangle1.Center.X);
            double dy = Math.Abs(rectangle2.Center.Y - rectangle1.Center.Y);
            if ((dx < Math.Abs(rectangle2.Length - rectangle1.Length) / 2) | (dy < Math.Abs(rectangle2.Width - rectangle1.Width) / 2))
            {
                return true;
            }
            else { return false; }
        }
        public bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = Math.Abs(ring2.Center.X - ring1.Center.X);
            double dy = Math.Abs(ring2.Center.Y - ring1.Center.Y);
            double c = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
            if (c < ring1.OuterRadius + ring2.OuterRadius)
            {
                return true;
            }
            else { return false; }
        }
    }
}
