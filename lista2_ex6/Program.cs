using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, p, s;
            x = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= 400.00)
            {
                p = x * 0.15;
                s = p + x;
                Console.WriteLine("Novo salario: " + String.Format("{0:F2}", s));

                Console.WriteLine("Reajuste ganho: " + String.Format("{0:F2}", p));

                Console.WriteLine("Percentual ganho: 15 %");
            }
            else if (x >= 400.01 && x <= 800.00)
            {
                p = (12 / 100) * x;
                s = p + x;
                Console.WriteLine("Novo salario: " + String.Format("{0:F2}", s));

                Console.WriteLine("Reajuste ganho: " + String.Format("{0:F2}", p));

                Console.WriteLine("Percentual ganho: 12 %");
            }
            else if (x >= 800.01 && x <= 1200.00)
            {
                p = (10 / 100) * x;
                s = p + x;
                Console.WriteLine("Novo salario: " + String.Format("{0:F2}", s));

                Console.WriteLine("Reajuste ganho: " + String.Format("{0:F2}", p));

                Console.WriteLine("Percentual ganho: 10 %");

            }
            else if (x >= 1200.01 && x <= 2000.00)
            {
                p = (7 / 100) * x;
                s = p + x;
                Console.WriteLine("Novo salario: " + String.Format("{0:F2}", s));

                Console.WriteLine("Reajuste ganho: " + String.Format("{0:F2}", p));

                Console.WriteLine("Percentual ganho: 7 %");
            }
            else if (x < 2000.00)
            {
                p = (4 / 100) * x;
                s = p + x;
                Console.WriteLine("Novo salario: " + String.Format("{0:F2}", s));

                Console.WriteLine("Reajuste ganho: " + String.Format("{0:F2}", p));

                Console.WriteLine("Percentual ganho: 4 %");


            }
            
                Console.ReadKey();
        }
    }
}
