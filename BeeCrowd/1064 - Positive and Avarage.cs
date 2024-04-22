using System;

class URI
{

    static void Main(string[] args)
    {

        double[] numbers = new double[6];
        var positiveCount = 0;
        var sumofPositive = 0.0;
        var positiveAvagare = 0.0;

        for (int i = 0; i < 6; i++)
        {
            if (double.TryParse(Console.ReadLine(), out numbers[i]))
            {
                if (numbers[i] > 0)
                {
                    positiveCount++;
                    sumofPositive += numbers[i];
                }

            }
        }

        Console.WriteLine(positiveCount + " valores positivos");
        if (sumofPositive > 0)
        {
            positiveAvagare = sumofPositive / positiveCount;
            Console.WriteLine(positiveAvagare.ToString("F1"));
        }

    }

}