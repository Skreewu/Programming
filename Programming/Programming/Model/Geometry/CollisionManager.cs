using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class CollisionManager
    {
        public static bool IsCollision(RectangleCustom rectangle1, RectangleCustom rectangle2)
        {
            bool result = false;

            //Расстояние между координатами.
            double differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            //Сумма значений.
            double wideSumm = (rectangle1.Width + rectangle2.Width) / 2;
            double lengthSum = (rectangle1.Length + rectangle2.Length) / 2;

            //Проверка на пересечение.
            if (differenceX < wideSumm && differenceY < lengthSum)
            {
                result = true;
            }
            return result;
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
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
