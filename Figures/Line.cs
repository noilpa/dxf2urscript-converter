using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class Line : Figure
    {
        public double X1 { get; private set; }
        public double Y1 { get; private set; }
        public double X2 { get; private set; }
        public double Y2 { get; private set; }

        private Line(double x1, double y1, double x2, double y2, bool error)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.Error = error;
            
        }

        public static void Create(double x1, double y1, double x2, double y2, bool error)
        {
            Figure.AddToList(new Line(x1, y1, x2, y2, error));
        }   
    }
}
