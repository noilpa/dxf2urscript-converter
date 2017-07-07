using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class Arc : Figure
    {
        public double XStart { get; private set; }
        public double YStart { get; private set; }
        public double Radius { get; private set; }
        public double AngleStart { get; private set; } // xStart = X1 + Radius*Math.sin(AngleStart)
                                                       // yStart = Y1 + Radius*Math.cos(AngleStart)
        public double AngleStop { get; private set; }  // xStop  = X1 + Radius*Math.sin(AngleStop)
                                                       // yStop  = Y1 + Radius*Math.cos(AngleStop)
        public double XStop { get; private set; }
        public double YStop { get; private set; }
        public double XVia { get; private set; }
        public double YVia { get; private set; }

        private Arc(double x1, double y1, double radius, double angleStart, double angleStop, bool error)
        {
            this.XStart = x1 + radius * Math.Cos(DegreeToRadian(angleStart));
            this.YStart = y1 + radius * Math.Sin(DegreeToRadian(angleStart));
            this.Radius = radius;
            this.AngleStart = angleStart;
            this.AngleStop = angleStop;
            this.XStop = x1 + radius * Math.Cos(DegreeToRadian(angleStop));
            this.YStop = y1 + radius * Math.Sin(DegreeToRadian(angleStop));
            this.Error = error;
            if (angleStart > angleStop)
            {
                this.XVia = x1 + radius * Math.Cos(DegreeToRadian(angleStart + angleStop));
                this.YVia = y1 + radius * Math.Sin(DegreeToRadian(angleStart + angleStop));
            }
            else
            {
                this.XVia = radius * Math.Cos(DegreeToRadian((angleStart + angleStop)/2));
                this.YVia = radius * Math.Sin(DegreeToRadian((angleStart + angleStop)/2));
            }

        }

        public static void Create(double x1, double y1, double radius, double angleStart, double angleStop, bool error)
        {
            Figure.AddToList(new Arc(x1, y1, radius, angleStart, angleStop, error));
        }

        public static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}

