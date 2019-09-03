using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0; // intiate var
            Console.WriteLine("This program takes 5 values and returns the sum"); // display code purpose
            Console.WriteLine("Money calculator please enter in 5 values");
            for(int x = 1; x <= 5; x++) //loop 5 times
            {
                Console.WriteLine($"Value {x}:"); // display value number entering
                number = number + double.Parse(Console.ReadLine()); // adding numbers together as user inputs them
            }
            if (number % 1 == 0) //if number is = to whole number
            {
                Console.WriteLine($"The total of those items is ${Math.Round(number, 2)}"); // print total
                Console.ReadLine(); // pause
            }
            else // if number is not = to whole number
            {
                Console.WriteLine($"The total of those items is ${Math.Round(number, 2)}0"); // print total
                Console.ReadLine(); // pause
            }
            
            
        }
    }
}
