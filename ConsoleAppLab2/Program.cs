using ConsoleAppLab2;
using static System.Runtime.InteropServices.JavaScript.JSType;
public delegate int FactorialDelegate(int n);
class Program
{
    static void Main()
    {
        Q1Factorial q1 = new();
        FactorialDelegate factorialDelegate = new(q1.Factorial);

        int n = q1.InputNumber();
        int result = factorialDelegate(n);
        Console.WriteLine($"Factorial of {n} is {result}");
        Console.ReadKey();
        Console.Clear();

        //Q2QuadraticEqn q2 = new();
        //q2.Input();
        //double[] roots = q2.Calculate();
        //foreach (var item in roots)
        //{
        //    Console.WriteLine("Roots are " + item);
        //}
        Iquad q2 = new();
        q2.Calculate();
        Console.ReadKey();
        Console.Clear();

        Imain q3 = new Imain();
        q3.getInput();
        q3.StuGreat24();
        Console.ReadKey();
        Console.Clear();

        TMain q4 = new TMain();
        q4.GetInput();
        q4.CalculateSum();
        Console.ReadKey();
        Console.Clear();

        Files q5 = new Files();
        q5.Copy();
        Console.ReadKey();
        Console.Clear();

        Q6EndWithG q6 = new Q6EndWithG();
        q6.SearchWords();
        Console.ReadKey();
        Console.Clear();

        Q7Calculator q7 = new();
        Console.WriteLine($"Addition Result: {q7.Add(5, 3)}");
        Console.WriteLine($"Subtraction Result: {q7.Diff(5, 3)}");
        Console.ReadKey();
        Console.Clear();


        //Q8
        Rectangle rectangle = new Rectangle();
        Square square = new Square();

        // Demonstrate interface implementation
        Console.WriteLine("Enter details for Rectangle:");
        rectangle.Get();
        rectangle.Display();

        Console.WriteLine("Enter details for Square:");
        square.Get();
        square.Display();
        Console.ReadKey();
        Console.Clear();

        //Q9
        Airplane airplane = new Airplane("Boeing 737", "Boeing", 150);

        // Demonstrate inherited methods and access instance variables
        airplane.DisplayDetails();
        airplane.StartEngine();
        airplane.TakeOff();
        airplane.Land();
        airplane.StopEngine();
        Console.ReadKey();
        Console.Clear();

        //Q10
        Emain q10 = new Emain();
        q10.AddEmployees();
        q10.EmployeesSalaryG();
        Console.ReadKey();
        Console.Clear();

        //Q11
        Q11Lambda q11 = new();
        q11.GetNum();
        q11.SumofOdd();
        Console.ReadKey();
        Console.Clear();
    }
}