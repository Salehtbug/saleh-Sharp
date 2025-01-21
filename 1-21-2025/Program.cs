using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_21_2025
{


}
public class Student
{
    private const int id = 1;
    public const int MinAge = 18;
    public const int MaxAge = 40;

    public string Name { get; set; }
    public int Age { get; set; }
    public int StudentID { get; set; }

    public Student(string name, int age, int studentID)
    {
        if (age < MinAge || age > MaxAge)
        {
            Console.WriteLine($"Age must be between {MinAge} and {MaxAge}. Setting default age to {MinAge}.");
            Age = MinAge;
        }
        else
        {
            Age = age;
        }
        Name = name;
        StudentID = studentID;
    }

    public void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentID}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Saleh Ababneh", 25, 4229);
        Student student2 = new Student("Ahmad", 17, 1001);

        student1.GetDetails();
        student2.GetDetails();
        Student student3 = new Student("Ayman Malkawi", 28, 1003);
        Student student4 = new Student("Habeeb Alafeef", 23, 1004);
        student3.GetDetails();
        student4.GetDetails();
    }
}

