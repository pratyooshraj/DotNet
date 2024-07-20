using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q2SimpleInterest
    {
        public int P { get; set; }
        public double T { get; set; }
        public double R { get; set; }
        public void GetParameters()
        {
            Console.Write("Enter principal ");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate of Interest ");
            T = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time duration ");
            R = Convert.ToDouble(Console.ReadLine());
        }

        public double SimpleInterest()
        {
            double si = P * T * R / 100;
            return si;
        }
    }
}
