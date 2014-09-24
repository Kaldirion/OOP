using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_03._01_Point3D;

namespace Homework_03._02_Distance_Calculator
{
    class DistanceTest
    {
        static void Main()
        {
            Point3D point3 = new Point3D(3.1f, 32.4f, 17.8f);
            Point3D point4 = new Point3D(5.2f, 2.8f, 27.2f);
            double distance = DistanceCalculator.CalculateDistance(point3, point4);
            Console.WriteLine("The distance is : {0}",distance);
            Console.ReadKey();
        }
    }
}
