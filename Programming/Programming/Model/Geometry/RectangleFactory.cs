using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class RectangleFactory
    {
        public static RectangleCustom Randomize()
        {
            Random random = new Random();
            Colour[] colors = (Colour[])Enum.GetValues(typeof(Colour));
            Point2D Center = new Point2D(random.Next(0, 500), random.Next(0, 400));
            RectangleCustom rectangle = new RectangleCustom(random.Next(10, 150), random.Next(10, 150), colors[random.Next(colors.Length)], Center);
            return rectangle;
        }
    }
}
