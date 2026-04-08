using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise4();

        }
        static void Exercise1()
        {
            //1 - Write a program and ask the user to enter a number. The number should be between 1 to 10.If the user enters
            //a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in
            //applications where values entered into input boxes need to be validated.)
            Console.Write("Bir sayı giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void Exercise2()
        {
            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.Write("Bir sayı giriniz:");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayı giriniz:");
            var number2 = Convert.ToInt32( Console.ReadLine());

            var number3 = (number1 >  number2) ? number1 : number2;

            Console.WriteLine("max number is " + number3);
            
        }

        static void Exercise3()
        {
            //3 - Write a program and ask the user to enter the width and height of an image.Then tell if the image is
            //landscape or portrait.

            Console.Write("Lütfen boyu giriniz:");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen eni giriniz:");
            var weight = Convert.ToInt32(Console.ReadLine());

            var type = (weight > height) ? "landscape" : "portrait";
            Console.WriteLine("The image is " + type);
        }

        static void Exercise4()
        {
            //4 - Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera,
            //sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.Once
            //set, the program asks for the speed of a car.If the user enters a value less than the speed limit, program
            //should display Ok on the console.If the value is above the speed limit, the program should calculate the number
            //of demerit points.For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed
            //on the console.If the number of demerit points is above 12, the program should display License Suspended.

            Console.Write("Hz limitini giriniz:");
            var speed_limit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Araba hızını giriniz:");
            var car_speed = Convert.ToInt32(Console.ReadLine());

            if (speed_limit > car_speed)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demerit_point = (car_speed - speed_limit) / 5;
                Console.WriteLine("Demerit point is " + demerit_point);
                Console.WriteLine((demerit_point > 12) ? "Licence Suspended" : "");
            }
        }
    }
}
