using System;

namespace Homework_02._01_Square_Roots
{
    class SqrRoot
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter digit");
                int Num = int.Parse(Console.ReadLine());
                Console.WriteLine("Square root of " + Num + " is " + Math.Sqrt((double)Num));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Must enter number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Must enter valid integer!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter number in the ragne of 32bit Integer!");
            }
            finally
            {
                Console.WriteLine("Good bye");
                Console.ReadKey();
            }
        }
    }
}
