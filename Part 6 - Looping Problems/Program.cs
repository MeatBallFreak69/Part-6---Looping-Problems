using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Looping_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prompter");
            int minValue;
            int maxValue;
            int numBetween;

            Console.WriteLine("Please enter 2 numbers, first being a minimum and second a maximum value");
            Console.WriteLine("Minimum");

            while (!Int32.TryParse(Console.ReadLine(), out minValue))
                Console.WriteLine("Invalid integer! Try again");

            Console.WriteLine("Maximum");

            while (!Int32.TryParse(Console.ReadLine(), out maxValue))
                Console.WriteLine("Invalid integer! Try again");

            Console.WriteLine($"Now enter a number between {minValue} and {maxValue}");

            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out numBetween))
                    Console.WriteLine("Invalid integer! Try again");

                if (numBetween < minValue || numBetween > maxValue)
                {
                    Console.WriteLine("Error! Incorrect value entered");
                }
            } while (numBetween < minValue || numBetween > maxValue);

            Console.WriteLine($"Your number which is {numBetween} is in the range of {minValue} and {maxValue}");
            
            Console.WriteLine("");
            Console.WriteLine("Percent Passing");

            double above70 = 0;
            double below70 = 0;
            double percent = 0;
            string strScore;
            int intScore;
            
            Boolean stop = false;
            
            Console.WriteLine("Please enter your test scores to find out how many 70% + scores there were. Then type done when you're finished.");
            while (stop == false)
            {
                strScore = Console.ReadLine();
                if (strScore == "done")
                {
                    stop = true;
                }
                Int32.TryParse(strScore, out intScore);
                if (intScore >= 70)
                {
                    above70 += 1;
                }
                else
                {
                    below70 += 1;
                }
                
                
            }
            percent = (above70 / (above70 + below70)) * 100;
            percent = Math.Round(percent, 2);

            Console.WriteLine($"The percent of scores you entered that were above 70% were {percent}%");

            Console.WriteLine("");
            Console.WriteLine("Oddsum");

            int number;
            int oddNumbers = 0;

            Console.WriteLine("Please enter an integer.");

            Int32.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    oddNumbers += 0;
                }
                else
                {
                    oddNumbers += i;
                }
                
            }
            Console.WriteLine($"The sum of all the odd numbers from 1 to your number {number} is {oddNumbers}");

            Console.WriteLine("");
            Console.WriteLine("RandomNumbers");

            minValue = 0;
            maxValue = 0;

            Random generator = new Random();

            Console.WriteLine("Please enter a minimum and maximum value");

            while (!Int32.TryParse(Console.ReadLine(), out minValue))
                Console.WriteLine("Invalid integer! Try again");

            while (!Int32.TryParse(Console.ReadLine(), out maxValue))
                Console.WriteLine("Invalid integer! Try again");

            for (int j = 1; j <= 25; j++)
            {
                Console.WriteLine(generator.Next(minValue, maxValue + 1));
            }
            Console.ReadLine();
        }
    }
}

