using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an interface Shape which method get() and display().
//Create two classes Rectangle and Square which implements this interface.
//defines the member variable of these classes as per requirement in class itself.
//Create some instances of Rectangle and Square classes and demonstrate interface implementation by classes .


namespace ConsoleAppLab2
{
    internal interface IShape
    {
        void Get();
        void Display();
    }

    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public void Get()
        {
            Console.WriteLine("Enter length of rectangle:");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle:");
            width = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Rectangle -> Length: {length}, Width: {width}");
        }
    }

    // Implement the interface in Square class
    public class Square : IShape
    {
        private double side;

        public void Get()
        {
            Console.WriteLine("Enter side length of square:");
            side = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Square -> Side: {side}");
        }
    }
}
