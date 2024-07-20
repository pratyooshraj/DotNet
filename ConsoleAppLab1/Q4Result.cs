using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q4Result
    {
        public Dictionary<string, int> Marks = new();
        public void GetMarks()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter subject");
                string s = Console.ReadLine();
                Console.Write("Enter marks in " + s);
                int m = Convert.ToInt32(Console.ReadLine());
                Marks.Add(s, m);
            }
        }

        private bool PassFail()
        {
            foreach (KeyValuePair<string, int> kvp in Marks)
            {
                if (kvp.Value < 32)
                    return false;
            }
            return true;
        }

        public void DisplayResult()
        {
            int total = 0;
            Console.WriteLine("Marks Sheet");
            Console.WriteLine("Subject   | Full Marks  | Pass Marks | Marks Obtained");
            foreach(KeyValuePair<string, int> kvp in Marks)
            {
                Console.WriteLine("{0,-9} | {1,-11} | {2,-10} | {3,-14}", kvp.Key, 100, 32, kvp.Value);
                total += kvp.Value;
            }
            Console.WriteLine("total marks Obtained= "+ total);
            if(PassFail())
            {
                Console.WriteLine("percentage= " + total / 5 + "%");
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }


    }
}
