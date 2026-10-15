using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{

static void Main(string[] args)
    {
        Circle myCircle = new Circle(10);
        // myCircle.SetRadius(10);
        double area = myCircle.GetArea();
        Console.WriteLine($"{area}");
    }
    
}
