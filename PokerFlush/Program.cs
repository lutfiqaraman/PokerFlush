using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFlush
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = { "10D", "QD", "7D", "KD", "5D" };

            char Symbol = cards.First().Last();
            bool IsPoker = cards.All(x => x.Last() == Symbol);

            if (IsPoker)
                Console.WriteLine("POKER !");
            else
                Console.WriteLine("NOT A POKER !");

            Console.ReadKey();
        }
    }
}
