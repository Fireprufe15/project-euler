using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProblem17
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "";
            for (int i = 1; i < 1001; i++)
            {
                sentence += NumbersInWords(i);
            }
            sentence = sentence.Replace(" ","");
            sentence = sentence.Replace("-", "");
            Console.WriteLine(sentence.Count());
            Console.ReadKey();
        }

        static string NumbersInWords(int number)
        {
            if (number == 0)
            {
                return "zero";
            }
            string words = "";
            
            if ((number / 1000) > 0)
            {
                words += NumbersInWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumbersInWords(number / 100) + " hundred ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
