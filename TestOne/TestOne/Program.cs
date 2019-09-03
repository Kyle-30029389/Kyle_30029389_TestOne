using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will take a base and power it by the exponent and return value");
            Console.WriteLine("Enter the value of the base");    //Ask user to enter base value
            double basenum = double.Parse(Console.ReadLine());    //Store number user enters as a double

            Console.WriteLine("Enter the number of the exponent"); //Ask user to enter exponent value
            int exponent = int.Parse(Console.ReadLine());  //Store number as int

            Console.WriteLine($"{basenum}^{exponent} = {Math.Pow(basenum,exponent)}"); //Calculate base to the power of the exponent and display back to user
            Console.ReadLine();     //Pause

        }
    }
}
