using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{

    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;
    // }
    // static string MyName()
    // {
    //     return "Bob";
    // }
    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, its nice to meet you");
    // }
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle._radius = 5;
        double area = myCircle.GetArea();
        Console.WriteLine($"{area}");
    }
        // string myName = MyName();
        // DisplayGreeting(myName);
        // double total = AddNumbers(12.234, 20);
        // Console.WriteLine(total);
        // 
        // int x = 10;
        // int y = 30;
        // int z = 40;
        // // && (and) has a higher order of precedence over || (or)
        // if (x == 10 && y==30 || z == 30)
        //     {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("Y is fun");
        //     }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X = 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default output");
        // }
        // string numberString = "123";
        // int mynumber = int.Parse(numberString);


        // bool done = false;
        // while (! done)
        // {
        //     Console.Write("Are we done (y/n) ?");
        //     done = Console.ReadLine() == "y";
        // }



        //     bool done;
        //     do
        //     {
        //         Console.Write("Are we done (y/n)? ");
        //         done = Console.ReadLine().ToLower() == "y";
        //     } while (! done);
        // }

        // for(int i = 100000; i > -100001; i-=100000)
        //     {
        //         Console.WriteLine(i);
        //     }

        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        // foreach (string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }
        

}

// Comment to end of line

/* Multiline
 comment

*/