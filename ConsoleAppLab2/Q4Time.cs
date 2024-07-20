using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a class Time with three integer member variables hr , min, sec.
//The class also will contain the method Tim Sum(Time t1, Time t2) method
//that will return the sum of t1and t2 Create a class TimeDemo with main method
//that will create an object of Time and to invoke the Sum function and print the added time
namespace ConsoleAppLab2
{
    internal class Q4Time
    {
        public int Hr {  get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }

        public void GetTime()
        {
            Console.Write("Enter hours ");
            Hr=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minutes");
            Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds");
            Sec = Convert.ToInt32(Console.ReadLine());
        }

        public Q4Time Sum(Q4Time t1, Q4Time t2)
        {
            Q4Time s = new Q4Time();
            int sRem = 0, mRem = 0;
            s.Sec = t1.Sec+t2.Sec;
            if(s.Sec>=60)
            {
                sRem = s.Sec / 60;
                s.Sec %= 60;
            }
            s.Min= t1.Min+t2.Min+sRem;
            if(s.Min>=60)
            {
                mRem=s.Min/60;
                s.Min %= 60;
            }
            s.Hr=t1.Hr+t2.Hr+mRem;
            return s;
        }

        public void PrintTime()
        {
            Console.WriteLine($"Sum is {this.Hr} : {this.Min} : {this.Sec}");
        }

    }

    class TMain()
    {
        public Q4Time t1= new Q4Time();
        public Q4Time t2= new Q4Time();
        
        public void GetInput()
        {
            t1.GetTime();
            t2.GetTime();
        }

        public void CalculateSum()
        {
            Q4Time res=t1.Sum(t1, t2);
            res.PrintTime();
        }
    }
}
