using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculator
    {
        //delegate
        public delegate double CalculateInterest(int money, double interest, int yeras);

        //fields
        private int money;
        private double interest;
        private int years;
        private CalculateInterest type;

        //constructors

        public InterestCalculator(int money,double interest, int years, CalculateInterest type)
        {
            this.money = money;
            this.interest = interest;
            this.years = years;
            this.type = type;
        }

        public override string ToString()
        {
            return string.Format("{0:F4}",this.type(this.money,this.interest,this.years));
        }
    }
}
