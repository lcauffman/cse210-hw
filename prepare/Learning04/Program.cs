using System;


namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment a1 = new Assignment("Logan Cauffman", "Multiplication");
            Console.WriteLine(a1.GetSummary());

            MathAssignment a2 = new MathAssignment("Logan Cauffman","Fractions", "7.3", "8-19");
            Console.WriteLine(a2.GetSummary());
            Console.WriteLine(a2.GetHomeworkList());

            WritingAssignment a3 = new WritingAssignment("Logan Cauffman", "European History", "The Causes of WW2");
            Console.WriteLine(a3.GetSummary());
            Console.WriteLine(a3.GetWritingInformation());

        }
    }
}    

    

