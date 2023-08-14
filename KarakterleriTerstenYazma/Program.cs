namespace KarakterleriTerstenYazma;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Metni girin:");
        string metin=Console.ReadLine();

        string yeniMetin = yerDegistir(metin);
        Console.WriteLine("Degistirilmis metin : " + yeniMetin);
    }
    static string yerDegistir(string metin)
    {
        char[] karakterDizisi = metin.ToCharArray();
        for(int i = 1; i < karakterDizisi.Length; i++)
        {
            char temp = karakterDizisi[i];
            karakterDizisi[i]=karakterDizisi[i-1];
            karakterDizisi[i-1] = temp;
        }
        return new string(karakterDizisi);
    }
}
