class TriangularPrism:Shape
{
    private double Side;
    private double Height;

    public TriangularPrism(double side, double height)
    {
        Side = side;
        Height = height;
    }
    public override double AlanHesapla()
    {
        return 2*((Side * Side* Math.Sqrt(3))/4) + (3 * Side * Height);
    }
    public override double HacimHesapla()
    {
        return ((Side * Side* Math.Sqrt(3))/4) * Height;
    }
}