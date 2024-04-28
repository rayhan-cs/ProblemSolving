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
            if (numbers[i] % 2 != 0)
            {
                oddNumbers++;
            }
            if (numbers[i] > 0)
            {
                positives++;
            }
            if (numbers[i] < 0)
            {
                negatives++;
            }
        }

        Console.WriteLine(evenNumbers + " valor(es) par(es)");
        Console.WriteLine(oddNumbers + " valor(es) impar(es)");
        Console.WriteLine(positives + " valor(es) positivo(s)");
        Console.WriteLine(negatives + " valor(es) negativo(s)");

    }

}