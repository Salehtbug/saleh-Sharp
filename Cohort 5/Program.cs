using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            string Name = "saleh";
            bool isActive = true;
            char Grade = 'A';
            int per = 80;
            double height = 1.86;
            const int age = 25;

            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Active: {isActive}");
            Console.WriteLine($"Grade : {Grade}");
            Console.WriteLine($"Per : {per}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Age : {age}");

            string[] Car = { "BMW", "Volvo", "Marcedec", "Opel" };
            foreach (var item in Car)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("Input your firstname :");
            string fname = Console.ReadLine();

            Console.WriteLine("Input your lastname :");
            string lname = Console.ReadLine();

            Console.WriteLine("Input your BirthDay :");
            string bday = Console.ReadLine();

            Console.WriteLine(fname  + "" +  lname + "" +  bday);


            string[] array = new string[10];
            Console.WriteLine("Input 10 elements in the array :");
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Console.ReadLine();
                }
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }




        }
    }
}
