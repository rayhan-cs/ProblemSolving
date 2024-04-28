using System;

class URI
{

    static void Main(string[] args)
    {

        var coordinates = new double[2];

        var line = Console.ReadLine();
        var lineParts = line.Split(' ');

        for (int i = 0; i < coordinates.Length; i++)
        {
            coordinates[i] = Convert.ToDouble(lineParts[i]);
        }

        for (int i = 0; i < lineParts.Length - 1; i++)
        {
            if (coordinates[i] > 0.0 && coordinates[i + 1] > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (coordinates[i] < 0.0 && coordinates[i + 1] > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (coordinates[i] < 0.0 && coordinates[i + 1] < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (coordinates[i] > 0.0 && coordinates[i + 1] < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (coordinates[i] == 0.0 && coordinates[i + 1] == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (coordinates[i + 1] == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (coordinates[i] == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
        }

    }

}