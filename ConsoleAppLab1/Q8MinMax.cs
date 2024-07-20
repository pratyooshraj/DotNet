using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q8MinMax
    {
        private int[] num;
        public int ArraySize { get; set; }
        public void GetNumbers()
        {
            Console.Write("How many numbers");
            ArraySize = Convert.ToInt32(Console.ReadLine());
            num = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine("Enter numbers");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void FindMinMax()
        {
            Console.WriteLine("Minimum Number is " + num.Min());
            Console.WriteLine("Maximum Number is " + num.Max());
        }

    }
}
