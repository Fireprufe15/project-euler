using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem7 {
    class Program {
        static void Main(string[] args) {

            var i = 2;
            var counter = 1;
            while (counter < 10001) {
                i++;
                if (isPrime(i)) counter++;
            }
            Console.WriteLine(i);
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

            //for (int i = 5; i*i < num; i+=6)
            //{
            //    if (num % i == 0 || num % (i + 2) == 0) return false;
            //}
            return true;

        }
    }
}
