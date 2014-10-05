using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class TestInterestCalculator
    {
        public static double GetSimpleInterest(int money, double interest, int years)
        {
            return (double)money * (1 + (interest/100) * years);
        }

        public static double GetCompoundInterest(int money, double interest, int years)
        {
            return (double)money * Math.Pow((1 + (interest / 100) / 12),(years * 12));
        }

        static void Main()
        {
            InterestCalculator CompundCalc = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(CompundCalc);

            InterestCalculator SimpleCalc = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(SimpleCalc);

            Console.ReadKey();
        }
    }
}
