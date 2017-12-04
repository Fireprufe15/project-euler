using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem4 {
    class Program {
        static void Main(string[] args) {
            var highestPalindrome = 0;
            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++) {
                    var val = i * j;
                    Console.WriteLine(val);
                    var number = val.ToString();
                    var revnumber = new string(number.ToCharArray().Reverse().ToArray());

                    if (number == revnumber && val > highestPalindrome) {
                        highestPalindrome = val;
                    }
                }
            }

            Console.WriteLine(highestPalindrome);
            Console.ReadKey();

        }
    }
}
