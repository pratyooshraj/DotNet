using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    internal class Q5ChooseOperator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public string OperatorName { get; set; }

        private int Add()
        {
        //can this be written as lamda expression?
            return Num1 + Num2;
        }
        private int Subtract()
        {
            return Num1 - Num2;
        }

        private int Multiply()
        {
            return Num1 * Num2;
        }
        private int Divide()
        {
            return Num1 / Num2;
        }

        public void GetParameters()
        {
            Console.WriteLine("Enter number1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator");
            OperatorName =Console.ReadLine();
        }

        public void Calculate()
        {
            double result = 0;
            switch (OperatorName)
            {
                case "+":
                    result = Add();
                    break;
                case "-":
                    result = Subtract();
                    break; 
                case "*":
                    result = Multiply();
                    break;
                case "/":
                    result = Divide();
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3}",Num1,OperatorName,Num2,result);
        }


    }
}
