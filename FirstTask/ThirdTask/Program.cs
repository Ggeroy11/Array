using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '\0';

            while (symbol != '.')
            {
                symbol = Console.ReadKey().KeyChar;
                if (symbol >= 'а' && symbol <= 'я')
                {
                    Console.Write("\r" + (char)(symbol - ('а' - 'А')));
                }
                else if (symbol >= 'А' && symbol <= 'Я')
                {
                    Console.Write("\r" + (char)(symbol + ('а' - 'А')));
                }
            }
            Console.ReadLine();
        }
    }
}
