using System;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My test program");
        }
    }

    public class math_algorithm
    {
        public int sqr(int x)
        {
            return x * x;
        }

        public double doubleAddition(Double a, Double b)
        {
            return a + b;
            
        }

        public long GetFactorial(int number)

        {

            if (number == 0)

            {

                return 0;

            }

            return number * GetFactorial(number - 1);

        }
    }
}
