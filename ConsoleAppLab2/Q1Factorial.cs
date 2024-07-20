using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    internal class Q1Factorial
    {
        public int InputNumber()
        {
            Console.Write("Enter a number");
            int number =Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
