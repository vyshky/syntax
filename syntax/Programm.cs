using System;
using System.Linq;
using System.Net;

namespace syntax
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CountSpace());
            //Console.WriteLine(String.Concat("Билет ", LuckTicket() ? "Luck" : "Unlucky"));
            //Console.WriteLine(ToUpper());
            //Console.WriteLine(ToLower());
            //PrintStairs();
            StringRevers();
            Console.WriteLine(IntRevers());
        }

//1
        static int CountSpace()
        {
            int count = 0;
            Console.WriteLine("Вводите символы");
            // char ch = '\0';
            // while (ch != '.')
            // {
            //     ch = Console.ReadKey(false).KeyChar; // true - не отображать нажатую клавишу
            //    if (ch == ' ') ++count;
            // }
            // Console.WriteLine();
            ConsoleKeyInfo i;
            do
            {
                i = Console.ReadKey(false);
                // Console.Write(i.Key.ToString()); // выводит наименование клавиш
                if (i.KeyChar == ' ') ++count;
            } while (i.KeyChar != '.');

            Console.WriteLine();
            return count;
        }

//2
        static bool LuckTicket()
        {
            int count = 6; //6 цифр
            Console.WriteLine("Введите номер билета ({0}-значное число)", count);
            string ticket = Console.ReadLine();

            if (ticket.Length != count || count % 2 != 0) return false;

            int leftsum = 0;
            int rightsum = 0;
            for (int i = 0; i < ticket.Length; ++i)
            {
                if (i < ticket.Length / 2) leftsum += ticket[i];
                if (i >= ticket.Length / 2) rightsum += ticket[i];
            }

            return leftsum == rightsum;
        }

//3
        static string ReplaceIndex(string str, char ch, int index)
        {
            string temp = null;
            for (int i = 0; i < str.Length; ++i)
            {
                if (i == index)
                {
                    temp += ch;
                    continue;
                }

                temp += str[i];
            }

            return temp;
        } //

        static string ToUpper()
        {
            Console.WriteLine("Введите строку для конвертирования в верхний регистр");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] >= 97 && str[i] <= 122)
                    str = ReplaceIndex(str, (char) (str[i] - 32), i);
            }

            return str;
        }

        static string ToLower()
        {
            Console.WriteLine("Введите строку для конвертирования в нижний регистр");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] >= 65 && str[i] <= 95)
                    str = ReplaceIndex(str, (char) (str[i] + 32), i);
            }

            return str;
        }

//4
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

//5

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