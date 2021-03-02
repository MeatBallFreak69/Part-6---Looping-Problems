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

            Console.ReadLine();
        }
    }
}

