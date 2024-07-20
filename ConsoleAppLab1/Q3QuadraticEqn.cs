using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q3QuadraticEqn
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public void GetCoeff()
        {
            Console.Write("Enter value of A");
            A=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of C");
            C = Convert.ToDouble(Console.ReadLine());
        }

        private double determinant()
        {
            return Math.Pow((Math.Pow(B,2)-4*A*C), 0.5);
        }

        public void Solve()
        {
            double d = determinant();
            double x1 = (-B + d) / (2 * A);
            double x2 = (-B - d) / (2 * A);
            Console.WriteLine("Roots are " + x1 + " and " + x2);
        }

    }
}
