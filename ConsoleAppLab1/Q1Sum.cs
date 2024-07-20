using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q1Sum
    {
        private int n1;//this method is old use constructors preferrably
        private int n2;

        public int N1
        {
            get { return n1; }
            set { n1 = value; }

        }
        public int N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public int Sum()
        {
            return n1 + n2;
        }
    }
}

