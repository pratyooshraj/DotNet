using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an abstract class called Vehicle with an abstract method startEngine() and
//a non-abstract method stopEngine(). Derive a concrete class Airplane from Vehicle,
//having instance variables such as model, manufacturer, and maxCapacity.
//The Airplane class should implement the abstract startEngine() method with appropriate logic
//for starting an aircraft engine. Additionally, provide concrete implementations for methods like takeOff() and land().
//In your main class, create an instance of the Airplane class and demonstrate the
//usage of the inherited methods (startEngine(), stopEngine(), takeOff(), and land()) along with accessing the instance variables.

namespace ConsoleAppLab2
{
    internal abstract class Vehicle
    {
        // Abstract method for starting the engine
        public abstract void StartEngine();

        // Non-abstract method for stopping the engine
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
    class Airplane : Vehicle
    {
        // Instance variables
        private string model;
        private string manufacturer;
        private int maxCapacity;
        private int speed = 0;

        // Constructor
        public Airplane(string model, string manufacturer, int maxCapacity)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.maxCapacity = maxCapacity;
        }

        // Implementation of the abstract method StartEngine
        public override void StartEngine()
        {
            Console.WriteLine("Airplane engine started.");
            speed += 5;
            Console.WriteLine($"Speed= {speed}");
        }

        // Method for taking off
        public void TakeOff()
        {
            Console.WriteLine("Airplane taking off...");
            speed += 1000;
            Console.WriteLine($"Speed= {speed}");
        }

        // Method for landing
        public void Land()
        {
            Console.WriteLine("Airplane landing...");
            speed = 0;
            Console.WriteLine($"Speed= {speed}");
        }

        // Method to display airplane details
        public void DisplayDetails()
        {
            Console.WriteLine($"Model: {model}, Manufacturer: {manufacturer}, Max Capacity: {maxCapacity}");
        }
    }
}
