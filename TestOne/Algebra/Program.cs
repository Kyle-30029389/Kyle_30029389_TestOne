using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2(x-3) + x = 12
             * 2x -6 + x = 12
             * 3x - 6 = 12
             * 3x = 18
             * x = 6
            */
            int x = 6; // initialise value

            Console.WriteLine("Can you solve 2(x – 3) + x = 12"); //display purpose of code
            int guess = int.Parse(Console.ReadLine()); //store user's guess

            if(guess == x) // check if guess is correct
            {
                Console.WriteLine($"You are correct x = {x}"); //display feedback
                Console.ReadLine();//pause
            }

            else // if wrong
            {
                Console.WriteLine("You are incorect"); //display feedback
                Console.ReadLine();//pause
            }
        }
    }
}
