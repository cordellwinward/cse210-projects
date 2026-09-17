using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.Write("Please Enter your First name: ");
        firstName = Console.ReadLine();
        Console.Write("Please Enter your Last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"{firstName} {lastName}");


    }
}