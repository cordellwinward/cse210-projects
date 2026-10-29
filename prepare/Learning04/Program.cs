using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("John Smith", "Multiplication");
        Console.WriteLine(myAssignment.GetSummary());
        MathAssignment myMathAssignment = new MathAssignment("Jacob White", "Partial Fractions", "6.7", "1-2, 7-17 odds");
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        WritingAssignment myWritingAssignment = new WritingAssignment("Sarah Jones", "US History", "The Revolutionary War");
        Console.WriteLine(myWritingAssignment.GetWritingAssignment());
    }
}