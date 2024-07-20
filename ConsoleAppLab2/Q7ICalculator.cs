using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create an interface called ICalculator which has methods int add(int x ,int y)
//and int diff(int x,int y) to perform addition and subtraction of numbers passed as arguments.
//Then define a class that implements interface ICalculator.
namespace ConsoleAppLab2
{
    internal interface ICalculator
    {
        int Add(int x, int y);
        int Diff(int x, int y);
    }
    public class Q7Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Diff(int x, int y)
        {
            return x - y;
        }
    }
}
