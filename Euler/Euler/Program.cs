using System;

/*
 * Authors:
 *   
 * Mak
 * Damon 
 * Breakfast boi
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
            Console.ReadLine();
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

            Console.WriteLine("The sum of multiples between 3 and 5 below 1000 is "+ Convert.ToString(sum) +"!");
        }
    }
}
