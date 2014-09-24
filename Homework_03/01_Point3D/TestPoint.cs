using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03._01_Point3D
{
    class TestPoint
    {
        static void Main()
        {
            Point3D point1 = new Point3D(2.3f, 3.4f, 3.1f);
            Console.WriteLine(point1);
            Point3D point2 = new Point3D(3.8f, 10.3f, 17.3f);
            Console.ReadKey();
        }
    }
}
