using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01._02_Laptop_Shop
{
    class Laptop_Shop
    {
        private static void Main()
        {
            Laptop Lenovo = new Laptop("lenovo",1250);
            Console.WriteLine(Lenovo);

            Laptop Dell = new Laptop("Dell Inspiron 1525", "Dell", "Intel Core2Duo - 2.0GHz", "8", "Intel HD Graphics 4400","500 GB","13.3 (33.78 cm) – 3200 x 1800",4,2300);
            Console.WriteLine(Dell);
            Console.ReadKey();
        }
    }
}
