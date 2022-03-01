using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwerty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minus(double a1, double b1)
            {
              
            }
            double plus(double a1, double b1)
            {
             
            }
            double umn(double a1, double b1)
            {
                return a1 * b1;
            }
            double del(double a1, double b1)
            {

            }
            double a = 0;
            double b = 0;
            string op = null;
            double res = 0;
            Console.WriteLine("Введите А");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Б");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine('-');
            Console.WriteLine('+');
            Console.WriteLine('*');
            Console.WriteLine('/');
            op = Console.ReadLine();
            if (op == "-")
            {
                res = minus(a, b);
                Console.WriteLine(res);
            }
            if (op == "+")
            {
                res = minus(a, b);
                Console.WriteLine(res);
            }
            if (op == "*")
            {
                res = minus(a, b);
                Console.WriteLine(res);
            }
            if (op == "/")
            {
                res = minus(a, b);
                Console.WriteLine(res);
            }
        }
    }
}
