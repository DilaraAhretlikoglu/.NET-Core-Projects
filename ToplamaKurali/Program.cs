namespace ToplamaKurali;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aralarinda virgül kullanarak sayi ciftinizi girin(num1,num2): ");
        string numbers = Console.ReadLine();

        string[] parts = numbers.Split(",");
        string text =parts[0].Trim();

        if(parts.Length != 2)
        {
            Console.WriteLine("Gecersiz giris ! ");
            return ;
        }

        if(int.TryParse(parts[0],out int firstNumber) && int.TryParse(parts[1], out int secondNumber))
        {
            int result = NumberCheck(firstNumber,secondNumber);
            Console.WriteLine("({0},{1}) girisinin sonucu : {2}",firstNumber,secondNumber,result);
        }
        else
         Console.WriteLine("Gecersiz formatta giris yaptiniz !");

    }
    public static int NumberCheck(int number1, int number2)
    {
            if(number1 == number2)
                return (int)Math.Pow(number1 + number2, 2);
            else
                return  number1 + number2;
        
    }
}
