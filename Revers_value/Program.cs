using System;
using System.Linq;

namespace Revers_value
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRevers();
            Console.WriteLine(IntRevers());
        }
        
        static void StringRevers()
        {
            Console.WriteLine("Введите строку для реверса");
            string str = Console.ReadLine();
            foreach (var i in str.Reverse())
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }

        static int IntRevers()
        {
            Console.WriteLine("Введите строку для реверса");
            int str = Convert.ToInt32(Console.ReadLine());
            int revers = 0;
            while (str > 0)
            {
                revers += str % 10;
                revers *= 10;
                str /= 10;
            }

            return revers / 10;
        }
    }
}