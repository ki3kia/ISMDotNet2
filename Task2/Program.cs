using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double z1;
            double z2;
            double n;
            double m;
            Console.WriteLine("Введіть n");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть m");
            m = double.Parse(Console.ReadLine());       
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine("z1 = {0}", z1);
            Console.WriteLine("z1 = {0}", z2);
        }
    }
}
