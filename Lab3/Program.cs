using System;
using System.Threading;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lab 3!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string continueProgram;

            do
            {
                Console.Write($"Hi {name}, please enter a number between 1 and 100: ");
                int number = int.Parse(Console.ReadLine());
                
                if (number < 1 || number > 100)
                {
                    Console.WriteLine("That is not a valid number, please enter a number in the correct range");
                }
                else if(number % 2 == 0 && number < 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (number % 2 == 0 && number <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"{number} Even");
                }
                else if (number % 2 ==1 && number > 60)
                {
                    Console.WriteLine($"{number} Odd");
                }
                else if (number % 2 ==1 && number <= 100)
                {
                    Console.WriteLine($"{number} Odd");
                }

                bool isValid;

                do
                {
                    Console.WriteLine("Would you like to continue?: (y/n)");
                    continueProgram = Console.ReadLine().ToLower();
                    isValid = continueProgram == "y" || continueProgram == "n";
                } while (!isValid);



            } while (continueProgram == "y");

            Console.WriteLine($"Ok {name}, Goodbye!");
        }
    }
}
