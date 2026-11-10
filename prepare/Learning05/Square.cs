using System.Drawing;

class Square : Shape
{
    private double _side;
    public Square(string color, double side_length)
    : base(color)
    {
        if (side_length > 0)
        {
            _side = side_length;
        }
        else
        {
            throw new ArgumentException("side_length must be greater than 0");
        }
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}