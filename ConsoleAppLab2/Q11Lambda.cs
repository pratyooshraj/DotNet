using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleAppLab2
{
    //Create an array of Integer of size n then enter the element in array and
    //find the sum of odd numbers of array elements using the concept of Lambda Expression.
    internal class Q11Lambda
    {

        private int[] num;
        public int ArraySize { get; set; }

        public void GetNum()
        {
            Console.Write("How many numbers");
            ArraySize = Convert.ToInt32(Console.ReadLine());
            num = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Console.Write("Enter number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void SumofOdd()
        {
            int sumOfOddNumbers = num.Where(num => num % 2 != 0).Sum();

            Console.WriteLine($"Sum of odd numbers in the array: {sumOfOddNumbers}");

        }
    }


}