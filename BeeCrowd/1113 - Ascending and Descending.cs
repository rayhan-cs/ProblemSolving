using System;

class URI
{

    static void Main(string[] args)
    {

        while (true)
        {
            var line = Console.ReadLine();
            var lineParts = line.Split(' ');

            var inputNumber = new int[lineParts.Length];

            inputNumber[0] = int.Parse(lineParts[0]);
            inputNumber[1] = int.Parse(lineParts[1]);

            if (inputNumber[0] == inputNumber[1])
            {
                break;
            }
            else if (inputNumber[0] < inputNumber[1])
            {
                Console.WriteLine("Crescente");
            }
            else if (inputNumber[0] > inputNumber[1])
            {
                Console.WriteLine("Decrescente");
            }
        }

    }

}