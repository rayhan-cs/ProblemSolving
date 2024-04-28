using System;

class URI
{

    static void Main(string[] args)
    {

        var positives = 0;
        var negatives = 0;
        var evenNumbers = 0;
        var oddNumbers = 0;
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] % 2 == 0)
            {
                evenNumbers++;
            }
        }

        Console.WriteLine(evenNumbers + " valores pares");

    }

}