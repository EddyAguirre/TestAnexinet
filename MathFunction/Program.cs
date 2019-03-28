using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            double from = 1;
            double to = Math.Pow(10, 6);
            //double to = 6;
            Console.WriteLine(DoMath(from, to));
            Console.ReadKey();
        }

        static double DoMath(double from, double to)
        {
            double result = 0;
            for (double k = from; k < to; k++)
            {
                result += Math.Pow(-1, k+1) / (2 * k - 1);
                //Console.Write($" {Math.Pow(-1, k+1)}/({2*k-1})"); //Shows each Sum
            }
            return 4 * result;
        }
    }
}
