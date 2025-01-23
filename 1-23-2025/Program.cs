using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _1_23_2025
{

    // Interface 
    // how to implemnt interface 
    // interface vs abstract 
    internal class Program
    {
        static void Main(string[] args)
        {

            Calcator C = new Calcator();
            C.Calc(10, 15);
            C.Calc(10, 15, 4);
            C.Calc(2.1, 1.5);
            Circle C1 = new Circle();
            Shape S = new Shape();
            Rectangle R = new Rectangle();
            S.Draw();
            C1.Draw();
            R.Draw();
            Dog D = new Dog();
            D.sleep();
            D.makeSound();
            Cat c2 = new Cat();
            c2.sleep();
            c2.makeSound();
            Guitar G = new Guitar();
            paino P = new paino();
            G.play();
            P.play();
           




        }
    }

    //1
    class Calcator
    {
        public void Calc(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Calc(int a, int b, int c)
        {
            Console.WriteLine((a + b) * c);
        }

        public void Calc(double a, double b)
        {
            Console.WriteLine(a + b);
        }

    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drwaing Shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");

        }
    }

    class Rectangle : Shape
    {

        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");

        }

    }

    abstract class Animal
    {
        public abstract void makeSound();

        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

    interface IPlayable
    {
        void play();

    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks");
        }

        public void play()
        {
            Console.WriteLine("abdallah");
        }
    }

    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat meows");

        }
    }

    class Guitar : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing the guitar");
        }
    }

    class paino : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing the piano");
        }
    }
}