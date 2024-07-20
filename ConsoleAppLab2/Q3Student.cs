using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Student having instance variable age and name and class also
//contains a function name void input( ) for user input age and name.
//Then create another class Imain and create an array of size 5 of Student
//then store the Student in array and print those records of array whose age is greater than or equal to 24.

namespace ConsoleAppLab2
{
    internal class Q3Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"{Name} is {Age} yrs ");   
        }
    }

    class Imain()
    {
        public Q3Student[] q3 = new Q3Student[5];

        public void getInput()
        {
            for(int i=0;i<q3.Length;i++)
            {
                q3[i] = new Q3Student();
                q3[i].Input();
            }
        }

        public void StuGreat24()
        {
            Console.WriteLine("Students older than 24yrs");
            foreach (var student in q3)
            {
                if (student.Age >= 24)
                    student.Output();
            }
        }

}
}
