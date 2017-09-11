using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string numTicket = Console.ReadLine();

            int number = Int32.Parse(numTicket);
            int first = number / 100000;
            int sec = (number % 100000) / 10000;
            int third = ((number % 100000) % 10000) / 1000;
            int four = (((number % 100000) % 10000) % 1000) / 100;
            int fifth = ((((number % 100000) % 10000) % 1000) % 100) / 10;
            int six = ((((number % 100000) % 10000) % 1000) % 100) % 10;
            int firsthalf = first + sec + third;
            int secondhalf = four + fifth + six;
            if (firsthalf == secondhalf)
            {
                Console.WriteLine("Счастливый билет!");
            }
            else
            {
                Console.WriteLine("Билет не счастливый!");
            }
            Console.ReadLine();
        }
    }
}
