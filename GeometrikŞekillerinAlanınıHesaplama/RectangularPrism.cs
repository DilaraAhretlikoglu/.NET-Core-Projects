class RectangularPrism:Shape
{
    private double LongSide;
    private double ShortSide;
    private double Height;

    public RectangularPrism(double longSide, double shortSide, double height)
    {
        LongSide = longSide;
        ShortSide = shortSide;
        Height = height;
    }

    public override double AlanHesapla()
    {
        return  2*(ShortSide * LongSide + LongSide * Height + ShortSide * Height);
    }
    public override double HacimHesapla()
    {
        return ShortSide * LongSide * Height ;
    }
}