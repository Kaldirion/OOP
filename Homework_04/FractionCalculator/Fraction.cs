using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    struct Fraction
    {
        //fields
        private Int64 numerator;
        private Int64 denominator;

        //constructor
        public Fraction (Int64 numerator, Int64 denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        //properties
        public Int64 Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException("Numerator is out of range [-9223372036854775808 … 9223372036854775807]");
                }
                this.numerator = value;
            }
        }

        public Int64 Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException("Denominator is out of range [-9223372036854775808 … 9223372036854775807]");
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Denominator can't be 0");
                }
                this.denominator = value;
            }
        }
        //override "+" operator
        public static Fraction operator + (Fraction fraction1, Fraction fraction2)
        {
            Int64 num;
            Int64 denom;
            if (fraction1.denominator == fraction2.denominator)
            {
                num = fraction1.numerator + fraction2.numerator;
                denom = fraction1.denominator;
            }
            else
            {
                denom = LCM(fraction1.denominator, fraction2.denominator);
                num = (denom / fraction1.denominator) * fraction1.numerator + (denom / fraction2.denominator) * fraction2.numerator;
            }
            return new Fraction(num,denom);
        }

        //override "-" operator 
        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            Int64 num;
            Int64 denom;

            if (fraction1.denominator == fraction2.denominator)
            {
                num = fraction1.numerator - fraction2.numerator;
                denom = fraction1.denominator;
            }
            else
            {
                denom = LCM(fraction1.denominator, fraction2.denominator);
                num = (denom / fraction1.denominator) * fraction1.numerator - (denom / fraction2.denominator) * fraction2.numerator;
            }
            return new Fraction(num, denom);
        }

        //helper functions
        public static Int64 GCF(Int64 num1, Int64 num2)
        {
            while (num2 != 0)
            {
                Int64 temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        public static Int64 LCM(Int64 num1, Int64 num2)
        {
            return (num1 / GCF(num1, num2)) * num2;
        }

        // ovveride ToString() for printing object
        public override string ToString()
        {
            return string.Format("{0}",((float)this.numerator/this.denominator));
        }
    }


}
