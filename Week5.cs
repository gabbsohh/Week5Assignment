using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Assignment
{
    internal class Week5
    {
        static void Main(string[] args)
        {
            //ask user to call functions

            problemOne();
            problemTwo();
            problemThree();
            
        }
        //function to count how many numbers between 1 and 100
        //are divisible by 3 with no remainder. Display count
        //on console
        static void problemOne()
        {
            int count = 0;
            //starting at 1 and ending at 100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("There are " + count + " numbers between 1 and 100 " +
                "that are divisible by 3 with no remainder.");

        }
        //function to ask user for number or 'ok' to exit
        //calculate the sum of all previously entered numbers
        static void problemTwo()
        {
            int sum = 0;
            //will keep executing as long as user does not input 'ok'
            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit: ");
                string input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                int number = int.Parse(input);
                sum += number;
            }
            Console.WriteLine("Your total sum is " + sum);
        }
        //ask user to enter a number. Compute factorial of number
        //print it on console.
        //Ex: if 5, should calculate 5x4x3x2x1 and display 5!=120
        static void problemThree()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(number + "! = " + factorial);
        }
    }
}
