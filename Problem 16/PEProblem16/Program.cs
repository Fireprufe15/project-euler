using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = (BigInteger)Math.Pow(2, 1000);
            string num = number.ToString();
            BigInteger sum = 0;
            foreach (var item in num)
            {
                sum += BigInteger.Parse(item.ToString());
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
