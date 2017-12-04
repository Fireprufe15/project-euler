using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem9 {
    class Program {
        static void Main(string[] args) {

            Int64 n = 2;
            Int64 m = 1;
            Int64 a = 1;
            Int64 b = 0;
            Int64 c = 1;
            bool found = false;

            while (!found) {
                for (m = 1; m < n; m++) {
                    a = n * n - m * m;
                    b = 2 * (n * m);
                    c = (n * n) + (m * m);
                    if (a + b + c == 1000) {
                        found = true;
                        break;
                    }
                }
                n++;
            }
            
            Console.WriteLine(found);
            Console.WriteLine(a +b + c);
            Console.WriteLine(a*b*c);
            Console.ReadKey();


        }
    }
}
