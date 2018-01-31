using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("We're gonna fac your torial today kid!");
            int i = 1;
            Console.WriteLine("please enter a number.");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                int end = input;
                Console.WriteLine("would you like to get your factorial through recursion(r), loop (l), or mystery(m)?");
                string response = Console.ReadLine();
                if (response == "r")
                {
                    int total = RecursiveWay(input, i, end);
                    Console.WriteLine("The factor of your number is: " + total);
                    Repeat();
                }
                else if (response == "l")
                {
                    Calculate(input);
                }
                else if (response == "m")
                {
                    MysteryWay(input, i, end);
                }
            }
            else
            {
                Console.WriteLine("That input didn't work bub, try again.");
                Main();
            }
        }
        public static void Calculate(int input)
        {

            //Console.WriteLine("Enter an integer from 1 to 25 please");
            //if (int.TryParse(Console.ReadLine(), out int input))
            //{
                long fact = 1;
                for (int i = 1; i <= input; i++)
                {
                    fact = fact * i;
                    Console.WriteLine(fact);
                }
                Console.WriteLine("The factorial of " + input + " is " + fact);
                Repeat();
            //}
            //else
            //{
            //    Console.WriteLine("I'm sorry, I can't calculate that input, please retry a number.");
            //    Calculate();
            //}
        }

        static int RecursiveWay(int input, int i, int end)
        {
            //Console.WriteLine("please enter a number.");
            //int input = int.Parse(Console.ReadLine());
            input = input * i;
            i++;
            Console.WriteLine(input);

            if (i > (end - 1))
            {
                return input;
            }
            input = RecursiveWay(input, i, end);
            return input;
        }
        static void MysteryWay(int input, int i, int end)
        {
            while (i < end)
            {
                input = i * input;
                Console.WriteLine(input);
                i++;
            }
            Console.WriteLine("The factor of your number is: " + input);
            Repeat();
        }

        static void Repeat()
        {
            Console.WriteLine("Would you like to repeat (y/n)");

            if (char.TryParse(Console.ReadLine(), out char response))
            {
                if (char.ToLower(response) == 'y')
                {
                    Main();
                }
                else if (char.ToLower(response) == 'n')
                {
                    Console.WriteLine("Goodbye.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand. Would you like to continue?(y/n)");
                    Repeat();
                }
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand. Would you like to continue?(y/n)");
                Repeat();
            }
        }
    }
}
