namespace OrtalamaHesaplama;
class FibonacciCalculator
{
    public static int[] CalculateFibonacciSeries(int depth)
    {
        int[] series = new int[depth];
        series[0] = 0;
        series[1] = 1;
        for (int i = 2; i < depth; i++)
        {
            series[i] = series[i - 1] + series[i - 2];
        }

        return series;
    }
    public static double CalculateAverage(int[] series)
    {
        int sum = 0;
        foreach (int num in series)
        {
            sum += num;
        }
        return (double)sum / series.Length;
    }

}

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen dizinin derinliğini girin:");
        int depth = int.Parse(Console.ReadLine());


        int[] FibonacciSeries = FibonacciCalculator.CalculateFibonacciSeries(depth);
        double average = FibonacciCalculator.CalculateAverage(FibonacciSeries);

        Console.Write("Fibonacci serisi: ");
        for (int i = 0; i < FibonacciSeries.Length; i++)
        {
            Console.Write(FibonacciSeries[i]);
            if (i < FibonacciSeries.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Fibonacci dizisinin ortalamasi :" + average);




    }
}
