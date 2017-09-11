using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            uint n; Console.WriteLine("Введіть n "); n = uint.Parse(Console.ReadLine());
            uint s, i, f;
            s = 0;
            f = 1;
            i = 1;
            for (; i<=n; i++)
            {
                f = f * i;
                s = s + f;
            }
            Console.WriteLine("Результат {0}", s);
        }
    }
}
