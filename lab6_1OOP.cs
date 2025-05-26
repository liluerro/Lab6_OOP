using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int N = 17;
        List<int> numbers = new List<int>();

        for(int i = 0; i < N; i++)
            numbers.Add(random.Next(1, 51));

        Console.WriteLine("New list of numbers: " + string.Join(", ", numbers));

        int min = numbers.Min();
        int max = numbers.Max();

        Console.WriteLine("Minimum number: " + min);
        Console.WriteLine("Maximum number: " + max);

        numbers.Remove(min);
        numbers.Remove(max);

        Console.WriteLine("Numbers after removing min and max: " + string.Join(", ", numbers));
    }
}