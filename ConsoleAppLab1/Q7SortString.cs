using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q7SortString
    {
        private string[] names;
        public int ArraySize { get; set; }
        public void GetNames()
        {
            Console.Write("How many names");
            ArraySize=Convert.ToInt32(Console.ReadLine());
            names = new string[ArraySize];
            for(int i = 0; i < ArraySize; i++)
            {
                Console.Write("Enter name");
                names[i] = Console.ReadLine();
            }
        }

        public void PrintSortedNames()
        {
            Array.Sort(names);
            Console.WriteLine("Sorted names are");
            for(int i=0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

    }
}
