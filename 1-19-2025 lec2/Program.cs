using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_19_2025_lec2
{
    internal class Program


    {
        static double ConvertKmhToMph(double kmh)
        {
            return kmh * 0.621371;
        }

        static int ConvertToTotalMinutes(int hours, int minutes)
        {
            return (hours * 60) + minutes;
        }

        static (int hours, int minutes) ConvertToHoursAndMinutes(int totalMinutes)
        {
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            return (hours, minutes);
        }

        static void Main(string[] args)
        {

            // 1 
            Console.Write("Please enter a double value: ");


            string input = Console.ReadLine();
            double doubleValue = Convert.ToDouble(input);
            int intValue = (int)doubleValue;

            Console.WriteLine($"Double: {doubleValue}");
            Console.WriteLine($"Converted Int: {intValue}");

            // 2
            Console.Write("Please enter a number: ");
            string input1 = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                string numberAsString = Convert.ToString(number);
                string outputSentence = "Your number is: " + numberAsString;
                Console.WriteLine(outputSentence);
            }

            //3
            string sentence = "C# is fun!";

            string upperCase = sentence.ToUpper();
            string lowerCase = sentence.ToLower();

            Console.WriteLine($"Uppercase: {upperCase}");
            Console.WriteLine($"Lowercase: {lowerCase}");

            //4

            Console.Write("Please enter your full name: ");

            string fullName = Console.ReadLine();
            string[] nameParts = fullName.Split(' ');

            string firstName = nameParts[0];
            string lastName = nameParts[nameParts.Length - 1];

            int totalCharacters = fullName.Replace(" ", "").Length;


            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Total Characters: {totalCharacters}");

            //5

            Console.Write("Please enter the first integer: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second integer: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Smaller Number: {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Smaller Number: {secondNumber}");
            }

            //6 

            Console.Write("Enter speed in kilometers per hour (km/h): ");

            string input2 = Console.ReadLine();
            double kmh = Convert.ToDouble(input2);
            double mph = ConvertKmhToMph(kmh);

            Console.WriteLine($"{kmh} km/h is equivalent to {mph} mph");

            ////7 

            Console.Write("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = ConvertToTotalMinutes(hours, minutes);

            Console.WriteLine($"Total: {totalMinutes} minutes");

            //8

            Console.Write("Enter total minutes: ");
            int totalMinutes1 = Convert.ToInt32(Console.ReadLine());


            var (hours1, minutes1) = ConvertToHoursAndMinutes(totalMinutes);

            Console.WriteLine($"{totalMinutes} minutes is equivalent to {hours1} Hours, {minutes1} Minutes");

            //9

            Console.Write("Enter the first number: ");
            int firstNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber1 = Convert.ToInt32(Console.ReadLine());

            string result = (firstNumber1 == secondNumber1) ? "Equal" :
                       (firstNumber1 > secondNumber1) ? "Greater" : "Smaller";


            Console.WriteLine(result);

            // 9-1 

            Console.Write("Enter a number to calculate the sum of its digits: ");
            string numberInput = Console.ReadLine();
            int sum = 0;
            string newnum;

            for (int i = 0; i < numberInput.Length; i++)
            {
                newnum = Convert.ToString(numberInput[i]);
                sum += int.Parse(newnum);
            }
            Console.WriteLine(sum);


            //10

            Console.Write("Enter a number to reverse: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int reversedNumber = 0;

            while (number3 > 0)
            {

                int lastDigit = number3 % 10;
                reversedNumber = (reversedNumber * 10) + lastDigit;

                number3 /= 10;
            }
            Console.WriteLine($"Reversed Number: {reversedNumber}");


            //11 

            Console.Write("Enter the first number: ");
            int firstNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber2 = Convert.ToInt32(Console.ReadLine());

            string result1 = (secondNumber2 != 0 && firstNumber2 % secondNumber2 == 0) ? "Divisible" : "Not Divisible";

            Console.WriteLine(result1);

            //12

            Console.Write("Enter the first number: ");
            int firstNumber5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber5 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int middleValue = (firstNumber5 > secondNumber5)
                        ? ((firstNumber5 < thirdNumber) ? firstNumber5 : ((secondNumber5 > thirdNumber) ? secondNumber5 : thirdNumber))
                        : ((secondNumber5 < thirdNumber) ? secondNumber5 : ((firstNumber5 > thirdNumber) ? firstNumber5 : thirdNumber));

            
            Console.WriteLine($"The middle value is: {middleValue}");




        }
    }
}
