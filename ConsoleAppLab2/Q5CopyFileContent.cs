using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to read a file from input.txt then copy the content of input.txt to output.txt.
namespace ConsoleAppLab2
{
    internal class Q5CopyFileContent
    {
        public string TextContent { get; set; }

        public void ReadText(string file)
        {
            TextContent = File.ReadAllText(file);
        }

        public void WriteText(string file)
        {
            File.WriteAllText(file, TextContent);
            Console.Write("File Content copied successfully");
        }
    }

    class Files
    {
        public Q5CopyFileContent q5 = new();
        private string inputFileName = "C:\\Users\\ACER\\Desktop\\6th sem\\C#\\ConsoleAppLab2\\input.txt";
        private string outputFileName = "C:\\Users\\ACER\\Desktop\\6th sem\\C#\\ConsoleAppLab2\\output.txt";

        public void Copy()
        {
            try
            {
                q5.ReadText(inputFileName);
                q5.WriteText(outputFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

}
