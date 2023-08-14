using System;
namespace MutlakKareAlma
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayi girilecek ?");
            int n = int.Parse(Console.ReadLine());

            int[] sayilar = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. Sayiyi girin:",i+1);
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            int farklarinToplami=0;
            int mutlakKarelerinToplami =0;

            for(int i = 0 ; i < n ; i++)
            {
                if(sayilar[i]<67)
                {
                    farklarinToplami += 67-sayilar[i];
                }
                else
                {
                    mutlakKarelerinToplami += (int)Math.Pow(sayilar[i]-67,2);
                }
            }

            Console.WriteLine("67 den kücük sayilarin farklari toplami : {0}",farklarinToplami);
            Console.WriteLine("67 den büyük ve eşit sayilarin farklarinin mutlak karelerinin toplami : {0}",mutlakKarelerinToplami);
        }
    }
}