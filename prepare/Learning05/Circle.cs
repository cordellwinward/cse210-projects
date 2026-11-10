class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    : base(color)
    {
        if (radius > 0)
        {
            _radius = radius;
        }
        else
        {
            throw new ArgumentException("'radius' must both be greater than 0");
        }
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}