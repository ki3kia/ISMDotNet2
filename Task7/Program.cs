using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            uint n; Console.WriteLine("Введіть n "); n = uint.Parse(Console.ReadLine());
            double s=0.00;
            double i = 1.0;
            while (i<=n)
            {
                s = s + 1/i;
                i++;
            }
            Console.WriteLine(s);
        }
    }
}
