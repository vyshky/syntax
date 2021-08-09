using System;

namespace CountSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSpace());
        }
        static int CountSpace()
        {
            int count = 0;
            Console.WriteLine("Вводите символы");
            
            //1 решение
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
    }
}