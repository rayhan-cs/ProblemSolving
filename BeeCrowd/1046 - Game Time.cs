using System;

class URI
{

    static void Main(string[] args)
    {

        var durations = 0;
        var line = Console.ReadLine() ?? string.Empty;
        var lineParts = line.Split(' ');

        int[] numbers = new int[lineParts.Length];

        for (int i = 0; i < lineParts.Length; i++)
        {
            numbers[i] = Convert.ToInt32(lineParts[i]);
        }

        for (int i = 0; numbers.Length - 1 > i; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                durations = (24 - numbers[i] + numbers[i + 1]);
            }
            else if (numbers[i] < numbers[i + 1])
            {
                durations = (numbers[i + 1] - numbers[i]);
            }
            else if (numbers[i] == numbers[i + 1])
            {
                durations += 24;
            }

        }

        Console.WriteLine($"O JOGO DUROU {durations} HORA(S)");
    }

}