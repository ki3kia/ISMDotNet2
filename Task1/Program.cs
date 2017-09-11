using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a;
            double b;
            double P;
            double S;
            Console.WriteLine("Введіть а= "); a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b= "); b = double.Parse(Console.ReadLine());
            P = 2 * (a + b);
            S = a * b;
            Console.WriteLine("Периметр прямокутника = {0} ",P);
            Console.WriteLine("Площадь прямокутника = {0}", S);         
        }
    }
}
