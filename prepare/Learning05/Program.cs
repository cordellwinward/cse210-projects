using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("blue", 5);
        // Console.WriteLine(mySquare.GetColor());
        // Console.WriteLine(mySquare.GetArea());

        Rectangle myRectangle = new Rectangle("red", 7.5, 5);
        // Console.WriteLine(myRectangle.GetColor());
        // Console.WriteLine(myRectangle.GetArea());

        Circle myCircle = new Circle("yellow", 10);
        // Console.WriteLine(myCircle.GetColor());
        // Console.WriteLine(myCircle.GetArea());

        List<Shape> shapes = [mySquare, myRectangle, myCircle];
        foreach(Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}; Area: {s.GetArea()}");
        }
    }
}