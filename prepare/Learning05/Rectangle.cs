class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width)
    : base(color)
    {
        if (width > 0 && length > 0)
        {
            _width = width;
            _length = length;
        }
        else
        {
            throw new ArgumentException("'width' and 'length' must both be greater than 0");
        }
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}