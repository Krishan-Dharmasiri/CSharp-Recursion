using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print numbers from 1 to 10
            Recursion.PrintNumbersOneToTen(1);

            Console.WriteLine();
            Console.WriteLine();

            //Print the sum from 1 to n
            Console.WriteLine("--- Passed value is 5 so the Sum is 15 ---");
            Console.WriteLine(Recursion.SumFromOneToAGivenNumber(5));

            Console.WriteLine();
            Console.WriteLine();

            //Factorial of the given value
            Console.WriteLine("--- Passed values is 10 so the Factorial of 10 = 3,628,800 ---");
            Console.WriteLine(Recursion.Factorial(10));

            Console.ReadKey();
        }
    }
}
