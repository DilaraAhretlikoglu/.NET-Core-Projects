namespace GeometrikŞekillerinAlanınıHesaplama;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hoşgeldiniz !");
        Console.WriteLine("Lütfen işlem yapmak istediğiniz geometrik şekli seçiniz !");
        Console.WriteLine("(1):Silindir");
        Console.WriteLine("(2):Üçgen Prizma");
        Console.WriteLine("(3):Küp");
        Console.WriteLine("(4):Dikdörtgen Prizma");
        int secim = int.Parse(Console.ReadLine());

        switch (secim)
        {
            case 1:
                    Console.WriteLine("Silindirin yaricapini girin :");
                    double r = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Silindirin yüksekliğini girin :");
                    double h = Convert.ToDouble(Console.ReadLine());

                    Cylinder silindir = new Cylinder (r,h);

                    Console.WriteLine("Silindirin alanı : {0}",silindir.AlanHesapla());
                    Console.WriteLine("Silindirin hacmi : {0}",silindir.HacimHesapla());
                    
                break;
            case 2:
                Console.WriteLine("Eskenar ucgen prizmanin taban uzunluğunu girin :");
                double taban = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Eskenar ucgen prizmanin yüksekliğini girin :");
                double yukseklik = Convert.ToDouble(Console.ReadLine());

                TriangularPrism ucgenPrizma = new TriangularPrism(taban,yukseklik);

                Console.WriteLine("Eskenar ucgen prizmanin alanı : {0}",ucgenPrizma.AlanHesapla());
                Console.WriteLine("Eskenar ucgen prizmanin hacmi : {0}",ucgenPrizma.HacimHesapla());  

                break;
            case 3:
                Console.WriteLine("Kupun bir kenarini girin :");
                double kenar = Convert.ToDouble(Console.ReadLine());

                Cube kup = new Cube(kenar);

                Console.WriteLine("Kupun alanı : {0}",kup.AlanHesapla());
                Console.WriteLine("Kupun hacmi : {0}",kup.HacimHesapla()); 

                break;
            case 4:
                Console.WriteLine("Dikdortgen prizmanin uzun kenarini girin :");
                double UzunKenar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Dikdortgen prizmanin kisa kenarini girin :");
                double KisaKenar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Dikdortgen prizmanin yuksekligini girin :");
                double yukseklik2 = Convert.ToDouble(Console.ReadLine());

                RectangularPrism dikdortgenPrizma = new RectangularPrism(UzunKenar, KisaKenar, yukseklik2);

                Console.WriteLine("Dikdortgen prizmanin alanı : {0}",dikdortgenPrizma.AlanHesapla());
                Console.WriteLine("Dikdortgen prizmanin hacmi : {0}",dikdortgenPrizma.HacimHesapla());

                break;
            default:
                Console.WriteLine("Gecersiz giris yaptiniz !");
                break;
        }
    }
}
