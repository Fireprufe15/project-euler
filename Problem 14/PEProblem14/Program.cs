using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem14 {
    class Program {
        static void Main(string[] args) {

            double longestLenght = 0;
            double startingNumber = 2;
            for (double i = 13; i < 1000000; i++) {
                double count = 0;
                double val = i;
                while (val > 1) {
                    if (val % 2 == 0) {
                        val /= 2;
                    }
                    else {
                        val = 3 * val + 1;
                    }
                    count++;
                }
                if (count+1 > longestLenght) {
                    startingNumber = i;
                    longestLenght = count;
                }
            }
            Console.WriteLine(startingNumber);
            Console.ReadKey();

        }
    }
}
