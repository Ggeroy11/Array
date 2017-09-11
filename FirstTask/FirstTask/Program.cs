using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char Dot;
            Console.WriteLine("Введите символ:");
            while(true)
            {
                Dot = (char)Console.Read();
                if (Dot == '.')
                {
                    break;
                }
                else if (Dot == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Пробелов: ");
            Console.WriteLine(count);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
