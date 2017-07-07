using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class Circle : Figure
    {
        public double X1 { get; private set; }
        public double Y1 { get; private set; }
        public double Radius { get; private set; }

        private Circle(double x1, double y1, double radius, bool error)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.Radius = radius;
            this.Error = error;

        }

        public static void Create(double x1, double y1, double radius, bool error)
        {
            Figure.AddToList(new Circle(x1, y1, radius, error));
        }
    }
}

