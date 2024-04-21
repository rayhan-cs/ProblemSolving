using System;

class URI
{

    static void Main(string[] args)
    {

        var sum = 0.0;
        var line = Console.ReadLine() ?? string.Empty;
        string[] lineParts = line.Split(' ');

        var line1 = Console.ReadLine() ?? string.Empty;
        string[] lineParts1 = line1.Split(' ');

        double[] number1 = new double[lineParts.Length];
        double[] number2 = new double[lineParts1.Length];

        for (int i = 0; i < lineParts.Length; i++)
        {
            number1[i] = double.Parse(lineParts[i]);
        }
        for (int j = 0; j < lineParts1.Length; j++)
        {
            number2[j] = double.Parse(lineParts1[j]);
        }

        for (int z = 0; z < number1.Length - 2; z++)
        {

            var calculate1 = number1[z + 1] * number1[z + 2];
            var calculate2 = number2[z + 1] * number2[z + 2];

            sum = calculate1 + calculate2;
        }
        Console.WriteLine("VALOR A PAGAR: R$ " + sum.ToString("f2"));

    }

}