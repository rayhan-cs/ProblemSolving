using System;

class URI
{

    static void Main(string[] args)
    {

        var i = 0;
        var line = Console.ReadLine();
        string[] lineParts = line.Split(' ');

        int[] numbers = new int[lineParts.Length];

        foreach (var linePart in lineParts)
        {
            numbers[i] = int.Parse(linePart);
            i++;
        }
        for (int j = 0; j < numbers.Length - 1; j++)
        {
            if (numbers[j + 1] % numbers[j] == 0)
            {
                Console.WriteLine("They are multiples");
            }
            else
            {
                Console.WriteLine("They are not multiples");
            }
        }
    }

}