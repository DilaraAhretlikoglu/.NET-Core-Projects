namespace SplitAlgoritması;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string[] parts =input.Split(',');

        if(parts.Length != 2)
        {
            Console.WriteLine("Gecersiz giris ! ");
            return ;
        }
        string text =parts[0].Trim(); // Trim: sağdan ve soldan boşlukları temizler

        if (!int.TryParse(parts[1], out int index) || index < 0 || index >= text.Length)
        {
            Console.WriteLine("Geçersiz index değeri.");
                return;
        }

        string result = RemoveCharAtIndex(text, index);
        Console.WriteLine("Output: "+result);
    }
    static string RemoveCharAtIndex(string input, int index)
    {
        return input.Remove(index,1);
    }
}
