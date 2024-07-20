using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q6DisplayNamesWithT
    {
        private string[] names=new string[5];
        public void ReadNames()
        {  
            for(int i=0;i<names.Length;i++)
            {
                Console.Write("Enter name {0}", i+1);
                names[i]=Console.ReadLine();
            }
        }

        public void WriteNamesWithT()
        {
            Console.WriteLine("Names with T are");
            for(int i=0;i<names.Length;i++)
            {
                if (names[i].Contains('t'))
                {
                    Console.WriteLine(names[i]);
                }
            }   
        }
    }
}
