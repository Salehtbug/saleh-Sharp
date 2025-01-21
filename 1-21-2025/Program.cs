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


        //1. * *What is class?**  
        //   A class is a blueprint for creating objects, defining their properties and methods.

        //2. **What is object?**
        //   An object is an instance of a class, containing data and behavior defined by the class.

        //3. **Difference between class && object**
        //   A class is a template, while an object is a specific instance of that template.

        //4. **Mention the OOP Principles**  
        //   - Encapsulation
        //   - Inheritance
        //   - Polymorphism
        //   - Abstraction

        //5. **What is property?**
        //   A property is a special method in a class used to get or set the value of a field.

        //6. **What is field?**
        //   A field is a variable declared in a class to store data.

        //7. **What is constructor?**
        //   A constructor is a special method in a class that initializes objects when they are created.

        //8. **What is encapsulation?**
        //   Encapsulation is restricting access to data by bundling it with methods, ensuring controlled interaction.
    }
}

