using System;
using System.Collections.Generic;
using System.Linq;

namespace week5Assignment
{
    class Program
    {
        private static Random random;
        static void ProblemOne()
        {
            int number = 1;
            int count = 0;

            List<int> primeNumbers = new List<int>();

            Console.WriteLine("Problem 1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.");
            Console.WriteLine();

            while (number <= 100)
            {
                if (number % 3 == 0)
                {
                    count++;
                }
                number++;
            }

            Console.WriteLine("Between 1 and 100 there are " + count + " numbers divisible by 3.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void ProblemTwo()
        {
            int sum = 0;
            string valueEntered;
            int valueEnteredInt = 0;

            Console.WriteLine("Problem 2 - Write a program and continuously ask the user to enter a number or 'ok' to exit. Calculate the sum of all the previously entered numbers and display it on the console.");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Please enter a number or 'ok' to stop");
                valueEntered = Console.ReadLine();
                if (valueEntered == "ok")
                {
                    Console.WriteLine("The sum of all the numbers you entered is " + sum);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                else
                {
                    valueEnteredInt = Convert.ToInt32(valueEntered);
                    sum = sum + valueEnteredInt;
                }
            }
        }
        static void ProblemThree()
        {
            Console.WriteLine("Problem 3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.");
            Console.WriteLine();
            Console.WriteLine();

            ulong factorial = 1;

            Console.WriteLine("Please enter a number: ");
            ulong userInput = Convert.ToUInt64(Console.ReadLine());

            for (ulong i = 1; i <= userInput; i++)
            { 
                factorial *= i;
            }
            Console.WriteLine("The factorial of " + userInput + " is " + userInput + "! = " + factorial);
            Console.WriteLine();
            Console.WriteLine();
        }
        static void ProblemFour()
        {
            string problem4 = "Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display \"You won\"; otherwise, display \"You lost\". (To make sure the program is behaving correctly, you can display the secret number on the console first.)";
            Console.WriteLine("Problem 4 - " + problem4);
            Console.WriteLine();
            Console.WriteLine();

            int randomNumber = random.Next(1, 10);
            int attempt = 4;

            do
            {
                Console.WriteLine("Please enter a number between 1 and 10. You have " + attempt + " guesses left.");
                int guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                attempt--;
                if (guess == randomNumber)
                {
                    Console.WriteLine("You Won!");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
                if (attempt == 0)
                {
                    Console.WriteLine("You Lost!    The number was " + randomNumber +"!");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }
            }while (attempt > 0);
        }
        static void ProblemFive()
        {
            Console.WriteLine("Problem 5 - Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters 5, 3, 8, 1, 4, the program should display 8");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enter a list of numbers separated by a comma.");

            string userList = Console.ReadLine();
            string[] userNumbers = userList.Split(',');

            List<int> numbers = new List<int>();
            int eachNumber;

            foreach (string n in userNumbers)
            {
                if(Int32.TryParse(n, out eachNumber))
                    numbers.Add(eachNumber);
            }
            Console.WriteLine();
            Console.WriteLine("The lagest number you entered was: " + numbers.Max());
        }
        static void Main(string[] args)
        {
            random = new Random();

            ProblemOne();
            ProblemTwo();
            ProblemThree();
            ProblemFour();
            ProblemFive();
        }
    }
}