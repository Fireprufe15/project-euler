using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem12 {
    class Program {
        static void Main(string[] args) {

            int i = 1;
            bool found = false;
            while (!found) {
                var trianglenumber = (i * (i + 1)) / 2;
                var factors = new List<long>();
                for (int factor = 1; factor <= Math.Sqrt(trianglenumber); factor++) {
                    if (trianglenumber%factor == 0) {
                        factors.Add(factor);
                        if (factor != trianglenumber/factor) {
                            factors.Add(trianglenumber / factor);
                        }
                    }
                }
                if (factors.Count >= 500) {
                    found = true;
                    Console.WriteLine(trianglenumber);
                }
                i++;

            }
            Console.ReadKey();
            

        }

       
    }
}
