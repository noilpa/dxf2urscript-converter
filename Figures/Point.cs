using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class Point : Figure
    {
        public double X1 { get; private set; }
        public double Y1 { get; private set; }


        private Point(double x1, double y1, bool error)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.Error = error;

        }

        public static void Create(double x1, double y1, bool error)
        {
            Figure.AddToList(new Point(x1, y1, error));
        }

        public static Point CreateAndReturn(double x1, double y1, bool error)
        {
            return new Point(x1, y1, error);
        }
    }
}
