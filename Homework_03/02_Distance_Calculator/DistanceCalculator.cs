using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_03._01_Point3D;

namespace Homework_03._02_Distance_Calculator
{
    static class DistanceCalculator
    {
        //static method
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            double Xdiff = p2.X - p1.X;
            double Ydiff = p2.Y - p1.Y;
            double Zdiff = p2.Z - p1.Z;

            return Math.Sqrt(Math.Pow(Xdiff, 2) + Math.Pow(Ydiff, 2) + Math.Pow(Zdiff, 2));
        }
    }
}
