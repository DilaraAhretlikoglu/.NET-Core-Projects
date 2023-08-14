class Cylinder:Shape
{
    private double Radius;
    private double Height;


    public Cylinder(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }
    public override double AlanHesapla()
    {
        return (2 * Math.PI * Radius * Radius) + (2 * Math.PI * Radius * Height);
    }
    public override double HacimHesapla()
    {
        return Math.PI * Radius * Radius * Height ;
    }
}