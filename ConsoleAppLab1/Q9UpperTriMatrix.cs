using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q9UpperTriMatrix
    {
        private readonly int[,] matrix = new int[3, 3];

        public Q9UpperTriMatrix(int[,] a)
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    matrix[i,j]= a[i,j]; 
                }
            }
        }

        public void PrintUpperTriMatrix()
        {
            for (int i=0;i<matrix.GetLength(0); i++)
            {
                for(int j = 0;j<matrix.GetLength(1);j++)
                {
                    if (i <= j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }


    }
}
