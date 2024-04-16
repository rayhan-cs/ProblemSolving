using System;

class URI
{

    static void Main(string[] args)
    {

        int i = 0;
        var line = Console.ReadLine() ?? string.Empty;
        string[] lineparts = line.Split(' ');

        double[] numbers = new double[lineparts.Length];

        foreach (var part in lineparts)
        {
            numbers[i] = Convert.ToDouble(part);
            i++;
        }

        for (int j = 0; j < numbers.Length - 2; j++)
        {
            if (numbers[j] >= numbers[j + 1] + numbers[j + 2])
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            if ((numbers[j] * numbers[j]) == (numbers[j + 1] * numbers[j + 1]) + (numbers[j + 2] * numbers[j + 2]))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if ((numbers[j] * numbers[j]) > (numbers[j + 1] * numbers[j + 1]) + (numbers[j + 2] * numbers[j + 2]))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if ((numbers[j] * numbers[j]) < (numbers[j + 1] * numbers[j + 1]) + (numbers[j + 2] * numbers[j + 2]))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (numbers[j] == numbers[j + 1] && numbers[j] == numbers[j + 2])
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if (numbers[j] == numbers[j + 1] && numbers[j + 1] != numbers[j + 2])
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            if (numbers[j] == numbers[j + 2] && numbers[j + 2] != numbers[j + 1])
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }

    }

}

