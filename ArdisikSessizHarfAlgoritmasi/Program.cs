using System;

namespace ArdisikSessizHarfAlgoritmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime girin:");
            string kelime = Console.ReadLine();

            if (ArdIsikSessizVarMi(kelime))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        static bool ArdIsikSessizVarMi(string kelime)
        {
            int sayac = 0;
            char[] sessizHarfler = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };

            for (int i = 0; i < kelime.Length - 1; i++)
            {
                if (Array.Exists(sessizHarfler, harf => harf == char.ToLower(kelime[i])) && Array.Exists(sessizHarfler, harf => harf == char.ToLower(kelime[i + 1])))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
