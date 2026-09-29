using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int numberSquared = SquareNumber(number);
        DisplayResult(name, numberSquared, birthYear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please Enter Your Name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorate number? ");
        return int.Parse(Console.ReadLine());
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("What is your birthyear? ");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int numberSquared, int birthYear)
    {

        int age = 2026 - birthYear;
        Console.WriteLine($"{name}, The Square of your number is {numberSquared}");
        Console.WriteLine($"{name}, You will turn {age} this year.");

    }

}