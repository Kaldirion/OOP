using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01._01_Persons
{
    class PersonShow
    {
        private static void Main()
        {
            Persons SecondPerson = new Persons("Vesi", 23);
            Console.WriteLine(SecondPerson);

            Persons FirstPerson = new Persons("Daniel", 24, "Daniel.Dimitrov@ipsos.com");
            Console.WriteLine(FirstPerson);

            Console.ReadKey();
        }
    }
}
