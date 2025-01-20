using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_20_2025
{
    ////Class vs. Object
    //class Car
    //{
    //    public string Model { get; set; }
    //    public void Drive()
    //    {
    //        Console.WriteLine("Driving...");
    //    }
    //}

    //// Field / Constant
    //class Person
    //{
    //    public string Name; // Field
    //}


    class Room
    {
        // Properties of the Room class
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsBooked { get; set; }

        // Constant for the hotel name
        public const string HotelName = "Grand Stay Hotel";

        // Method to display room details
        public void DisplayRoomDetails()
        {
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Room Type: {RoomType}");
            Console.WriteLine($"Price Per Night: {PricePerNight:C}"); // Format as currency
            Console.WriteLine($"Is Booked: {IsBooked}");
            Console.WriteLine(); // Blank line for better readability
        }
    }





    internal class Program
    {


        static string CheckEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return $"The number {num} is even.";
            }
            else
            {
                return $"The number {num} is odd.";
            }
        }


        static int FindSecondSmallest(int[] nums)
        {
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in nums)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }

            return secondSmallest;
        }

        static long CalculateFactorial(int num)
        {
            long result = 1; // Initialize result to 1

            for (int i = 1; i <= num; i++)
            {
                result *= i; // Multiply result by the current number
            }

            return result; // Return the calculated factorial
        }


        static bool IsPrime(int num)
        {
            if (num < 2) return false; // 0 and 1 are not prime numbers

            // Check for factors from 2 to the square root of num
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; // Found a factor, so it's not prime
                }
            }

            return true; // No factors found, so it's prime
        }


        static int FindLargestNumber(int[] nums)
        {
            int largest = int.MinValue; // Initialize largest to the smallest possible integer

            foreach (int num in nums)
            {
                if (num > largest)
                {
                    largest = num; // Update largest if current number is greater
                }
            }

            return largest; // Return the found largest number
        }


        static void Main(string[] args)
        {
            //// While Loop
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////Do While Loop
            //int z = 0;
            //do
            //{
            //    Console.WriteLine(z);
            //    z++;
            //} while (z < 5);

            ////For Loop
            //for (int x = 0; x < 5; x++)
            //{
            //    Console.WriteLine(x);
            //}

            //// Foreach Loop
            //string[] fruits = { "Apple", "Banana", "Cherry" };

            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            ////If Else
            //int number = 10;

            //if (number > 0)
            //{
            //    Console.WriteLine("The number is positive.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is not positive.");
            //}

            ////Switch Statement
            //int day = 4;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number.");
            //        break;
            //}

            ////Object: An instance of a class
            //Car myCar = new Car();
            //myCar.Model = "Toyota";
            //myCar.Drive();


            //1

            Console.Write("Enter an integer: ");
            int number;
            bool isValidInput = int.TryParse(Console.ReadLine(), out number);

            if (isValidInput)
            {

                string result = CheckEvenOrOdd(number);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }


            //2

            int[] numbers = new int[5];

            Console.WriteLine("Enter five numbers (separated by spaces):");
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int secondSmallest = FindSecondSmallest(numbers);
            Console.WriteLine($"The 2nd smallest number is: {secondSmallest}");



            //3
            Console.Write("Enter a non-negative integer: ");
            int number1;
            bool isValidInput1 = int.TryParse(Console.ReadLine(), out number1);

            if (isValidInput && number1 >= 0)
            {

                long factorial = CalculateFactorial(number1);
                Console.WriteLine($"The factorial of {number1} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }

            //4
            Console.Write("Enter the start value: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end value: ");
            int end = int.Parse(Console.ReadLine());


            Console.WriteLine($"Prime numbers between {start} and {end}:");

            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }


            //5
            int[] num1 = { 3, 1, 4, 1, 5, 9 };
            int largestNumber = FindLargestNumber(num1);

            Console.WriteLine($"The largest number in the array is: {largestNumber}");


            //6
            int n = 5;

            int currentNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                Console.WriteLine();
            }




            //Hotel Reservation System 
            Room[] rooms = new Room[2];

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room(); 

                Console.WriteLine($"Enter details for Room {i + 1}:");

                Console.Write("Room Number: ");
                rooms[i].RoomNumber = int.Parse(Console.ReadLine());

                Console.Write("Room Type (Single/Double/Suite): ");
                rooms[i].RoomType = Console.ReadLine();

                Console.Write("Price Per Night: ");
                rooms[i].PricePerNight = decimal.Parse(Console.ReadLine());

                Console.Write("Is Booked (true/false): ");
                rooms[i].IsBooked = bool.Parse(Console.ReadLine());

                Console.WriteLine(); 
            }

            Console.WriteLine($"Welcome to {Room.HotelName}!");
            foreach (var room in rooms)
            {
                room.DisplayRoomDetails();
            }

        }

    }

}





