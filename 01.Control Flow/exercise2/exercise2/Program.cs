using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex5();

        }

        static void Ex1()
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void Ex2()
        {
            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the
            //previously entered numbers and display it on the console.

            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number or type 'ok' for exit:");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);

            }
            Console.WriteLine(sum);
        }

        static void Ex3()
        {
            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on
            //the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it
            //as 5! = 120.
            Console.Write("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine("Factorial of {0} is {1}",number,result);
        }

        static void Ex4()
        {
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".

            // 1. yol
            //var random = new Random();

            //var random_number = random.Next(1, 10);
            //var chance = 4;
            //while (chance>0)
            //{
            //    Console.Write("What's your guess:");
            //    var guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess == random_number)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    chance--;
            //    if (chance == 0)
            //    {
            //        Console.WriteLine("You lost! Actual number was {0}.", random_number);
            //    }
            //}

            //2.yol
            var random = new Random().Next(1, 10);
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("What's your guess:");
                var guess = Convert.ToInt32(Console.ReadLine());


                if (guess == random)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost! Actual number was {0}.", random);
        }

        static void Ex5()
        {
            //5 - Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the
            //numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should
            //display 8.

            Console.Write("Enter comma separeted numbers: ");

            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max_number = Convert.ToInt32(numbers[0]);
            foreach (var strnumber in numbers)
            {
                var number = Convert.ToInt32(strnumber);
                if (number >= max_number)
                {
                    max_number = number;
                }
            }
            Console.WriteLine(max_number);
        }
    }
}
