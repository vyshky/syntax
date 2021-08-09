using System;

namespace To_UPPER_lower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToUpper());
            Console.WriteLine(ToLower());
        }
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
    }
}