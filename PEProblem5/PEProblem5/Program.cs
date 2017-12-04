using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem5 {
    class Program {
        static void Main(string[] args) {

            int cur = 0;
            var found = false;
            while (!found) {
                cur++;
                found = true;
                for (int i = 1; i < 21; i++) {
                    if (cur%i > 0) {
                        found = false;
                        break;
                    }
                }
            }
            Console.WriteLine(cur);
            Console.ReadKey();

        }
    }
}
