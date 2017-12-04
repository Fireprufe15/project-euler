using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 0;
            var sum = 0;
            Queue<int> fib = new Queue<int>();
            while (num < 4000000)
            {
                if (num == 0)
                {
                    fib.Enqueue(0);
                    fib.Enqueue(1);
                }
                num = fib.Dequeue() + fib.Peek();
                if (num % 2 == 0) sum += num;
                fib.Enqueue(num);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
