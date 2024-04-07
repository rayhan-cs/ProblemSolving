using System;

class URI
{

    static void Main(string[] args)
    {

        int i = 0;
        var line = Console.ReadLine();
        string[] lineParts = line.Split(' ');

        int[] numbers = new int[lineParts.Length];

        foreach (string part in lineParts)
        {
            numbers[i] = int.Parse(part);
            i++;
        }
        for (int j = 0; j < numbers.Length - 3; j++)
        {
            if (numbers[j + 1] > numbers[j + 2] && numbers[j + 3] > numbers[j] && numbers[j + 2] + numbers[j + 3] > numbers[j] + numbers[j + 1] && numbers[j + 2] > 0 && numbers[j + 3] > 0 && numbers[j] % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }

    }

}