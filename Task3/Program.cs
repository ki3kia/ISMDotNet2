using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a;
            double b;
            double x;
            double y;
            Console.WriteLine("Введіть х"); x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть a не дорівнює 0"); a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b"); b = double.Parse(Console.ReadLine());
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine("y = {0}", y);
        }
    }
}
