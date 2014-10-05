using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClass
{
    class Student_Test
    {
        static void Main()
        {
            Student student = new Student("Peter", 25);
            student.Age = 30;
            Console.ReadKey();
        }
        

    }
}
