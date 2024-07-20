using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q10Rectangle
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Area { get; set; }

        public Q10Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public void CalculateArea()
        {
            Area = Length * Breadth;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is "+ Area);
        }
    }
}
