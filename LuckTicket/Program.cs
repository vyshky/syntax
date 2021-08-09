using System;

namespace LuckTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Concat("Билет ", LuckTicket() ? "Luck" : "Unlucky"));
        }
        
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
    }
}