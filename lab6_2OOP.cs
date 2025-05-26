using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int N = 10;
        int x = 52;
        List<int> numbers = new List<int>();

        for (int i = 0; i < N; i++)
            numbers.Add(rnd.Next(1, 101));

        Console.WriteLine("New list of numbers: " + string.Join(", ", numbers));

        for (int i = 0; i < numbers.Count; i++)
        {
            int num = int.Parse(numbers[i].ToString()[0].ToString());
            if (num % 2 == 0)
            {
                numbers.Insert(i, x);
                i++;
            }
        }
        Console.WriteLine("List after addind " + x + ": " + string.Join(", ", numbers));
    }
}