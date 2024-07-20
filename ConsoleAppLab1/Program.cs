using ConsoleAppLab1;
class Program
{
    static void Main(string[] args)
    {
        Q1Sum q1 = new Q1Sum();
        Console.Write("Enter a number:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        q1.N1 = number1;
        Console.Write("Enter a number:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        q1.N2 = number2;
        int s = q1.Sum();
        Console.WriteLine("sum is " + s);
        Console.ReadKey();
        Console.Clear();


        Q2SimpleInterest q2 = new();
        q2.GetParameters();
        Console.WriteLine("Simple Interest=" + q2.SimpleInterest());
        Console.ReadKey();
        Console.Clear();


        Q3QuadraticEqn q3 = new();
        q3.GetCoeff();
        q3.Solve();
        Console.ReadKey();
        Console.Clear();


        Q4Result q4 = new();
        q4.GetMarks();
        q4.DisplayResult();
        Console.ReadKey();
        Console.Clear();


        Q5ChooseOperator q5 = new();
        q5.GetParameters();
        q5.Calculate();
        Console.ReadKey();
        Console.Clear();


        Q6DisplayNamesWithT q6 = new();
        q6.ReadNames();
        q6.WriteNamesWithT();
        Console.ReadKey();
        Console.Clear();


        Q7SortString q7 = new();
        q7.GetNames();
        q7.PrintSortedNames();
        Console.ReadKey();
        Console.Clear();


        Q8MinMax q8 = new();
        q8.GetNumbers();
        q8.FindMinMax();
        Console.ReadKey();
        Console.Clear();


        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Q9UpperTriMatrix q9 = new Q9UpperTriMatrix(array);
        q9.PrintUpperTriMatrix();
        Console.ReadKey();
        Console.Clear();


        Q10Rectangle q10a = new Q10Rectangle(9, 5);
        Q10Rectangle q10b = new Q10Rectangle(12, 4);
        q10a.CalculateArea();
        q10b.CalculateArea();
        if(q10a.Area > q10b.Area)
        {
            q10a.DisplayArea();
        }
        else
        {
            q10b.DisplayArea();
        }
        Console.ReadKey();
    }
}
