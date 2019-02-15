using System;
using System.Collections.Generic;

/*
 * Authors:
 *   
 * Mak
 * Damon 
 * Breakfast matt
 * 
*/

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiplesOf3and5();
            Console.WriteLine($"SumSquareDifference: {SumSquareDifference()}");
            EvenFibonacciNumbers();
            Console.ReadLine();

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

        static void EvenFibonacciNumbers()//https://projecteuler.net/problem=2
        {
            int current = 0;//current is the sum of the prevNums
            int sum = 2;//original sum.
            int[] prevNums = new int[2] { 1, 2 };
            while(1==1){
                current = prevNums[0] + prevNums[1];
                if (!(current < 4000000))
                    break;
                prevNums[0] = prevNums[1];
                prevNums[1] = current;
                if (current % 2 == 0)//if the number is even
                    sum += current;
            }//while
            Console.WriteLine($"The sum of the even-valued fibonacci terms that do not exceed four million is: {sum}");

        }

        public static void MultiplesOf3and5()
        {
            int sum =0;
            int current = 1;
            while (current < 1000)
            {
                if(current%3 == 0 || current%5 == 0)
                {
                    sum = sum +current ; 
                }
                current++;
            }

            Console.WriteLine("The sum of multiples of 3 and 5 below 1000 is "+ Convert.ToString(sum) +"!");
        }
    }
}