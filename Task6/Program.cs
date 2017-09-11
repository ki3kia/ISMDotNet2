using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int a; Console.WriteLine("Введіть а "); a = int.Parse(Console.ReadLine());
            int b; Console.WriteLine("Введіть b > a"); b = int.Parse(Console.ReadLine());
            int D = 1;
            if (a>b)           
            {
                Console.WriteLine("Введіть а < b");
            }
            while (a <= b)
            {
                D = D * a;
                a++;
            }
            Console.WriteLine("Результат {0}", D);
        }
    }
}
