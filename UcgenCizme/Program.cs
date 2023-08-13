namespace UcgenCizme;
class Triangle
{
    public static void TriangleDrawing(int boyut)
    {
        for(int i = 0 ; i < boyut ; i++)
        {
            for(int j = 0; j<=i ; j++)
            {
                Console.Write("*"); //Veriyi yazdırdıktan sonra aynı satırda kalır, yani bir sonraki yazdırmanız aynı satırın sonundan devam eder.
            }
            Console.WriteLine(); //Yeni satıra geçmek için
        }

    }
    
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Boyut bilgisini girin:");
        int boyut = int.Parse(Console.ReadLine());

        Triangle.TriangleDrawing(boyut);


    }
}
