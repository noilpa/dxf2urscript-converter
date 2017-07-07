using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class PolyLine : Figure
    {
        private List<Point> points;
        public int PointsNumber { get; private set; } // code = 90
        
        private PolyLine(int pointsNumber, List<Point> points)
        {
            this.points = new List<Point>(points);
            this.Error = CheckError(points);
        } 

        
        private bool CheckError(List<Point> points)
        {
            bool error = false;
            foreach(Point point in points)
            {
                if(point.Error)
                {
                    error = true;
                }
            }
            return error;
        }

    }
}
