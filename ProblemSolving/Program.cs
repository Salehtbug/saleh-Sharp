using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of seconds: ");
            int totalSeconds = Convert.ToInt32(Console.ReadLine());

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;
            Console.WriteLine($" Time: {hours} hours, {minutes} minutes, {seconds} seconds");
        }
    }
}
