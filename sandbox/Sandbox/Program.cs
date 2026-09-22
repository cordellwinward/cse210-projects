using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 30;
        int z = 40;
        // && (and) has a higher order of precedence over || (or)
        if (x == 10 && y==30 || z == 30)
            {
            Console.WriteLine("X is 10");
            Console.WriteLine("Y is fun");
            }
        else if (x == 20)
        {
            Console.WriteLine("X = 20");
        }
        else
        {
            Console.WriteLine("Default output");
        }
        string numberString = "123";
        int mynumber = int.Parse(numberString);
    }
}

// Comment to end of line

/* Multiline
 comment

*/