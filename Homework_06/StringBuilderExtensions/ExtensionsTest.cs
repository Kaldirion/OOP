using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
    class ExtensionsTest
    {
        static void Main()
        {
            StringBuilder name2 = new StringBuilder("afieafaefe");
            Console.WriteLine(name2);
            name2.RemoveChar('e');
            Console.WriteLine(name2);
            name2.RemoveText("af");
            Console.WriteLine(name2);

            StringBuilder test2 = new StringBuilder("gfkgefhaeafieaihfiuaehifa");
            Console.WriteLine(test2.Substring(2,5));
            Console.ReadKey();

        }
    }
}
