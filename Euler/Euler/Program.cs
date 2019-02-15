using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumSquareDifference());
        }

        static int SumSquareDifference()
        {
            int SumSquare = 0;
            int SquareSum = 0;
          
            for (int i = 1; i <= 100; i++)
            {
                SumSquare += i * i;
                SquareSum += i;
            }

            SquareSum = SquareSum * SquareSum;

            return SquareSum - SumSquare;
        }
    }
}
