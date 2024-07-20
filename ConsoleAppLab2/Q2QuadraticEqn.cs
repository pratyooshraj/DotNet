using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    internal class Q2QuadraticEqn
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public void Input()
        {
            Console.Write("Enter value of A");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of C");
            C = Convert.ToDouble(Console.ReadLine());
        }
        private double Determinant()
        {
            return Math.Pow((Math.Pow(B, 2) - 4 * A * C), 0.5);
        }

        public double[] Calculate()
        {
            double d = Determinant();
            this.X1 = (-B + d) / (2 * A);
            this.X2 = (-B - d) / (2 * A);
            double[] roots= [X1, X2];
            return roots;
        }

    }

    class Iquad
    {
        Q2QuadraticEqn q2 = new();

        public void Calculate()
        {
            q2.Input();
            double[] roots = q2.Calculate();
            foreach (var item in roots)
            {
                Console.WriteLine("Roots are " + item);
            }
        }
    }
}

