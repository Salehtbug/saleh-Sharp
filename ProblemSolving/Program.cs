using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Program
    {

        class Person
        {
            public void Sum()
            {
                Console.WriteLine(5 + 3);
            }

            public void Sum(int x , int y)
            {
                Console.WriteLine(x + y);
            }

            public void Sum(int Num1 , double Num2)
            {
                Console.WriteLine(Num1 - Num2);
            }

            public void Sum(double Num2, int Num1)
            {
                Console.WriteLine(Num1 * Num2);
            }

            //public void Sum(double Num1, int Num2)
            //{
            //    Console.WriteLine(Num1 + Num2);
            //}

            //public void Sum(double Num3, int Num4)
            //{
            //    Console.WriteLine(Num3 + Num4);
            //}

        }
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Sum();

            person.Sum(5, 3);    
            
            person.Sum(5,3.1);

            person.Sum(8.33, 6);
        }
    }
}
