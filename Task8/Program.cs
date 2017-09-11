using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            uint n; Console.WriteLine("Введіть n "); n = uint.Parse(Console.ReadLine());
            double a; Console.WriteLine("Введіть а "); a = double.Parse(Console.ReadLine());
            double i=1;
            double d=a;
            for (;i<=n; i++)               
            {
                d = Math.Pow(a, i);
            }
            Console.WriteLine("Результат: {0}", d);
        }
    }
}
