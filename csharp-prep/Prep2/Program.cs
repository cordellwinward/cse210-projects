using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you percenage grade in the class? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        
        String letterGrade;
        if (grade >= 90)
            {
            letterGrade = "A";
            }
        else if (grade >= 80)
            {
            letterGrade = "B";
            }
        else if (grade >= 70)
            {
            letterGrade = "C";
            }
        else if (grade >= 60)
            {
            letterGrade = "D";
            }
        else
            {letterGrade = "F";}
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the class with an {letterGrade}");
        }
        else if (grade < 70)
        {
            Console.WriteLine($"Sorry, you failed the class with a {letterGrade}");
        }

}
}