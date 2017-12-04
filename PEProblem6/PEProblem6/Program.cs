using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem6 {
    class Program {
        static void Main(string[] args) {

            var sumOfSquares = 0;
            var sum = 0;
            for (int i = 1; i < 101; i++) {
                sumOfSquares += i * i;
                sum += i;
            }
            var answer = (sum * sum) - sumOfSquares;
            Console.WriteLine(answer);
            Console.ReadKey();

        }
    }
}
