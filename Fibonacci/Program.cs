using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            //(*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 

            Console.WriteLine("Enter integer number for FibonacciSeries!");
            int num = Convert.ToInt32(Console.ReadLine());
            var result = fibonacci(num);
            Console.WriteLine($"Fibonacci number {result}");
            Console.ReadLine();


            static int fibonacci(int n)
            {
                if (n == 1 || n == 2)
                {
                    return 1;
                }
                else
                {
                    return fibonacci(n - 1) + fibonacci(n - 2);
                }
            }
        }
    }
}
