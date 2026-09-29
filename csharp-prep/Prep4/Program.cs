using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<double> numList = [];
        Console.WriteLine("Enter a list of Numbers, type 0 when finished: ");
        double inputNum;
        do
        {
            inputNum = double.Parse(Console.ReadLine());
            if (inputNum != 0)
            {
            numList.Add(inputNum);
            }
        }
        while (inputNum != 0);
        double total = 0;
        double highest = numList[0];
        foreach(double number in numList)
        {
            total += number;
            if (highest < number)
            {
                highest = number;
            }
        }
        double average = total / numList.Count;
        Console.WriteLine($"The sum is {total}. The average number is {average}. The highest is {highest}.");
    }

}