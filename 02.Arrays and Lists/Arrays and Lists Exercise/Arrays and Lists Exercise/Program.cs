using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex05();
        }

        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the 
        /// above pattern.
        static void Ex01()
        {
            var likes = new List<string> { };
            
            while (true)
            {
                Console.Write("Who the liked my post:");
                var person = Console.ReadLine();
                if (person == String.Empty) break;
                likes.Add(person);
            }
            if (likes.Count == 0)
            {
                Console.WriteLine(string.Empty);
            }
            else if (likes.Count == 1)
            {
                Console.WriteLine("{0} likes your photo.", likes[0]);
            }
            else if (likes.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your photo.", likes[0], likes[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1} and {2} others like your photo.", likes[0], likes[1], likes.Count - 2);
            }
        }

        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        static void Ex02()
        {
            Console.Write("Type your name");
            var name = Console.ReadLine();
            var arr = new char[name.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = name[name.Length - i - 1];
            }

            var reversed = new string(arr);
            Console.WriteLine(reversed);

        }

        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        static void Ex03()
        {
            var numbers = new string[5];
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Please enter a number:");
                var number = Console.ReadLine();
                if (numbers.Contains(number) | String.IsNullOrEmpty(number))
                {
                    Console.WriteLine("Plesa enter a unique and valid value!");
                }
                else
                {
                    numbers[i] = number;
                    i++;
                }

            }
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.Write("{0}, ", number);
            }
            
        }

        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        static void Ex04()
        {
            var numbers = new List<int> { };
            while (true)
            {
                Console.Write("Please enter a number:");
                var number = Console.ReadLine();
                if (number.ToLower() == "quit")
                    break;
                if (!numbers.Contains(Convert.ToInt32(number)))
                {
                    numbers.Add(Convert.ToInt32(number));
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        static void Ex05()
        {
            while (true)
            {
                Console.WriteLine("Please enter a comma separated list of numbers:");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid List!");
                    continue;
                }

                var parts = input.Split(',');

                if (parts.Length < 5)
                {
                    Console.WriteLine("Invalid List!");
                    continue;
                }

                var numbers = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(parts[i].Trim());
                }

                Array.Sort(numbers);

                Console.WriteLine("The 3 smallest numbers in the list: {0}, {1}, {2}",
                    numbers[0], numbers[1], numbers[2]);
                break;
            }
        }
    }
}
