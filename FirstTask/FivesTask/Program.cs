using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string Length;
            Console.WriteLine("Введите целое число(число>0): ");
            Length = Console.ReadLine();
            number = Length.Length - 1;
            for (int i = 0; number >= i; number--)
            {
                Console.Write(Length[number]);
            }
            Console.ReadLine();
        }
    }
}
