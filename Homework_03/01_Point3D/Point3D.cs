using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03._01_Point3D
{
    class Point3D
    {
        //fields
        private float x;
        private float y;
        private float z;

        private static float basex = 0f;
        private static float basey = 0f;
        private static float basez = 0f;

        //constructors

        static Point3D()
        {
            Console.WriteLine("The coordinate system base is ({0}, {1}, {2})",Point3D.baseX,Point3D.baseY,Point3D.baseZ);
        }

        public Point3D(float x,float y,float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //properties

        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public float Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static float baseX
        {
            get { return Point3D.basex; }
        }

        public static float baseY
        {
            get { return Point3D.basey; }
        }

        public static float baseZ
        {
            get { return Point3D.basez; }
        }

        public override String ToString()
        {
            return string.Format("The point coordinates are : ({0}, {1}, {2})", this.x, this.y, this.z);
        }

    }
}
