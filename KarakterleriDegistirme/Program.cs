namespace KarakterleriDegistirme;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir kelime girin:");
        string input = Console.ReadLine();

        if(!string.IsNullOrEmpty(input) && input.Length >=2)
        {
            char[] charArray = input.ToCharArray();
            char firstChar = charArray[0];
            char lastChar = charArray[input.Length-1];

            charArray[0] = lastChar ;
            charArray[input.Length-1] = firstChar ;

            string output = new string(charArray);

            Console.WriteLine("Kelimenizin son hali :{0}",output);
            

        }

        

    }
}
