using System;

namespace PrintStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStairs();
        }

        static void PrintStairs()
        {
            Console.WriteLine("Введите 2 значения A и B");
            int A = Convert.ToInt32(Console.ReadLine()),
                B = Convert.ToInt32(Console.ReadLine());

            for (int i = A; i <= B; ++i)
            {
                for (int y = 0; y < i; ++y)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}