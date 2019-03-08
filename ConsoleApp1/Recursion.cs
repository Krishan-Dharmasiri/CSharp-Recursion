using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Recursion
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">The parameter that is used to stop the recursion</param>
        public static void PrintNumbersOneToTen(int n)
        {
            if (n > 10)
                return;

            Console.WriteLine(n);
            PrintNumbersOneToTen(n+1);

        }

        /// <summary>
        /// Sum up the integers until the int value given
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumFromOneToAGivenNumber(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + SumFromOneToAGivenNumber(n - 1);
        }

        /// <summary>
        /// Get the Factorial of the given value (int)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
