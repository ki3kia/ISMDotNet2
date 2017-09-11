using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            sbyte a;
            Console.WriteLine("Введіть число: "); a = sbyte.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Понеділок");
                    break;
                case 2:
                    Console.WriteLine("Вівторок");
                    break;
                case 3:
                    Console.WriteLine("Середа");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("П'ятниця");
                    break;
                case 6:
                    Console.WriteLine("Субота");
                    break;
                case 7:
                    Console.WriteLine("Неділя");
                    break;
            }
            if (a < 1)
            {
                Console.WriteLine("Помилка. Введіть число з проміжку від 1 до 7");
            }
            if (a > 7)
            {
                Console.WriteLine("Помилка. Введіть число з проміжку від 1 до 7");
            }
        }
    }
}
