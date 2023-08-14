class  Cube : Shape
{
    private double Side;

    public Cube(double side)
    {
        this.Side = side;
    }
    public override double AlanHesapla()
    {
        return 6 * Side * Side;
    }
    public override double HacimHesapla()
    {
        return Side*Side*Side;
    }

    
}