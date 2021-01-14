using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minimum value");
            string minValString = Console.ReadLine();
            int minVal = Int32.Parse(minValString);
            Console.WriteLine("Enter max value");
            string maxValString = Console.ReadLine();
            int maxVal = Int32.Parse(maxValString);
            Console.WriteLine("FizzBuzzing...");
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;
            int sum = 0;
            for (int i = minVal; i <= maxVal; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i+" FizzBuzz");
                    fizzCount++;
                    buzzCount++;
                    fizzBuzzCount++;
                    sum += i;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(i+" Fizz");
                    fizzCount++;
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i+" Buzz");
                    buzzCount++;
                    sum += i;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            int total = fizzCount + buzzCount;
            Console.WriteLine("fizzCount: "+fizzCount);
            Console.WriteLine("buzzCount: " + buzzCount);
            Console.WriteLine("fizzBuzzCount: " + fizzBuzzCount);
            Console.WriteLine("total: " + total);
            Console.WriteLine("sum: " + sum);
        }
    }
}
