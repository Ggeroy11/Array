using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string numberA = Console.ReadLine();
            int A = Int32.Parse(numberA);
            Console.WriteLine("Введите второе число: ");
            string numberB = Console.ReadLine();
            int B = Int32.Parse(numberB);

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
