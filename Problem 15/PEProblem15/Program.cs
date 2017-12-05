using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem15
{
    class Program
    {
        static void Main(string[] args)
        {

            double input = 20;
            var count = (Factorial(input*2)) / (Math.Pow(Factorial(input),2));
            Console.WriteLine(count);
            Console.ReadKey();

        }

        static double Factorial(double i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }

        static int combination(int n, int k)
        {
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += Math.Log10(n - i);
                sum -= Math.Log10(i + 1);
            }
            return (int)Math.Pow(10, sum);
        }
    }
}
