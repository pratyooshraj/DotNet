using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//Write a program to read a file from Input.txt then display those words which ends with the character ‘g’.
namespace ConsoleAppLab2
{
    internal class Q6EndWithG
    {
        private string fileName = "C:\\Users\\ACER\\Desktop\\6th sem\\C#\\ConsoleAppLab2\\input.txt";
        private string pattern = @"\b\w+g\b";
        public void SearchWords()
        {

            Regex rg = new Regex(pattern);
            string Text = File.ReadAllText(fileName);
            MatchCollection matches = rg.Matches(Text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
