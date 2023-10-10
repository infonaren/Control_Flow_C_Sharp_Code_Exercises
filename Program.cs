using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_C_Sharp_Code_Exercises
{
   
    class Program
    {
        static int CalculateDemeritPoints(int speedLimit, int carSpeed)
        {
            if (carSpeed <= speedLimit)
            {
                return 0;
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                return demeritPoints;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 and 10: ");
            int userInput;

            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                var result = (userInput >= 1 && userInput <= 10) ? "Valid" : "Invalid";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.Write("Enter the first number: ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
      

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Maximum number is {0}",firstNumber);
            }
            else
            {
                Console.WriteLine("Maximum number is {0}", secondNumber);

            }

            var maximumNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine(maximumNumber);

            Console.WriteLine("Enter the width of the image:");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of the image:");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is in landscape orientation.");
            }
            else if (height > width)
            {
                Console.WriteLine("The image is in portrait orientation.");
            }
            else
            {
                Console.WriteLine("The image is a square.");
            }

            Console.WriteLine("Welcome to the Speed Camera Program!");

            // Ask the user to enter the speed limit
            Console.Write("Enter the speed limit (in km/hr): ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the speed of the car
            Console.Write("Enter the speed of the car (in km/hr): ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            // Calculate the demerit points
            int demeritPoints = CalculateDemeritPoints(speedLimit, carSpeed);

            // Display the result
            if (demeritPoints > 0)
            {
                Console.WriteLine($"Demerit points: {demeritPoints}");

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended!");
                }
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}
/*
 Note: for all these exercises, ignore input validation unless otherwise directed. 
Assume the user enters a value in the format that the program expects. 
For example, if the program expects the user to enter a number, 
don't worry about validating if the input is a number or not. 
When testing your program, simply enter a number.
   
   
   
   1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
      If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
      (This logic is used a lot in applications where values entered into input boxes need to be validated.)
   
   
   
   2- Write a program which takes two numbers from the console and displays the maximum of the two.
   
   
   
   3- Write a program and ask the user to enter the width and height of an image. 
      Then tell if the image is landscape or portrait.
   
   
   
   4- Your job is to write a program for a speed camera.
      For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
      Write a program that asks the user to enter the speed limit.
      Once set, the program asks for the speed of a car. 
      If the user enters a value less than the speed limit, program should display Ok on the console. 
      If the value is above the speed limit, the program should calculate the number of demerit points. 
      For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
      If the number of demerit points is above 12, the program should display License Suspended.

 */