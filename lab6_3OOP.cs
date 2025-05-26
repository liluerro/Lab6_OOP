using System;

class Program
{
    static void Main()
    {
        static bool IsProste(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        Random random = new Random();
        int N = 10;
        List<int> all = new List<int>();
        List<int> prosti = new List<int>();
        List<int> other = new List<int>();

        for (int i = 0; i < N; i++)
            all.Add(random.Next(1, 51));

        foreach (int number in all)
        {
            if (IsProste(number))
                prosti.Add(number);
            else
                other.Add(number);
        }

        Console.WriteLine("All numbers: " + string.Join(", ", all));
        Console.WriteLine("Prosti numbers: " + string.Join(", ", prosti));
        Console.WriteLine("Inshi numbers: " + string.Join(", ", other));
    }
}