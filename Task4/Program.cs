using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a; Console.WriteLine("Введіть а "); a = double.Parse(Console.ReadLine());
            double b; Console.WriteLine("Введіть b "); b = double.Parse(Console.ReadLine());
            double c; Console.WriteLine("Введіть c "); c = double.Parse(Console.ReadLine());
            double x1;
            double x2;
            double x;
            double D;
            D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a * c);
                x2 = (-b - Math.Sqrt(D)) / (2 * a * c);
            }
            if (D < 0)
            {
                Console.WriteLine("Коренів не існує");
            }
            switch (D)
            {
                case 0:
                    x = -b / (2 * a * c);
                    Console.WriteLine("х = {0}", x);
                    break;
            }
        }
    }
}
