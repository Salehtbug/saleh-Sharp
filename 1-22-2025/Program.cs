using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1_22_2025
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }


    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public void StartCar()
        {
            //Console.WriteLine("Car is starting.");
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle
            {
                Brand = "Generic",
                Model = "Model X"
            };
            vehicle.Start();

            Car car = new Car
            {
                Brand = "Toyota",
                Model = "Camry",
                NumberOfDoors = 4
            };
            //car.StartCar();
            //Console.WriteLine($"Car Brand: {car.Brand}, Model: {car.Model}, Doors: {car.NumberOfDoors}");



            //           Constructor: A method that initializes an object when it's created.
            //           OOP Concepts: Encapsulation, Inheritance, Polymorphism, and Abstraction.
            //           Encapsulation: Protecting data by controlling access using methods or properties.
            //           Sealed Class: A class that cannot be inherited.
            //           Inheritance: A child class using the properties and methods of a parent clas

        }
    }
}
