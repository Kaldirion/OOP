using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListTest
    {
        static void Main()
        {
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine(intList);
            Console.WriteLine("Element at index 2 is : {0}",intList[2]);
            Console.WriteLine("Dooes the list contain 1 : {0}",intList.Find(1));
            Console.WriteLine("The index if value 3 is : {0}",intList.FindIndex(3));
            intList.InsertAt(8, 2);
            Console.WriteLine(intList);
            intList.RemoveAt(2);
            Console.WriteLine(intList);
            //intList.ClearAll();
            //Console.WriteLine(intList);
            Console.WriteLine("Max Value : {0}",intList.Max());
            Console.WriteLine("Min Value : {0}", intList.Min());
            Console.ReadKey();
        }
    }
}
