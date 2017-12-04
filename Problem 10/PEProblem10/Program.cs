using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem10 {
    class Program {
        static void Main(string[] args) {

            Int64 i = 1;
            Int64 sum = 0;
            while (i <= 2000000) {
                if (isPrime(i)) sum += i;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        static bool isPrime(double num) {
            if (num <= 1) return false;
            else if (num <= 3 || num == 5) return true;
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0) return false;

            int i = 6;
            var boundary = (int)Math.Floor(Math.Sqrt(num));

            while (i <= boundary) {
                if (num % (i + 1) == 0 || num % (i + 5) == 0) return false;
                i += 6;
            }
            return true;
        }

    }
}
