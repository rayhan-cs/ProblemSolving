using System;

class URI
{

    static void Main(string[] args)
    {

        var firstNumber = 0;
        var secondNumber = 0;

        while (true)
        {
            var line = Console.ReadLine();
            var lineParts = line.Split(' ');

            firstNumber = int.Parse(lineParts[0]);
            secondNumber = int.Parse(lineParts[1]);

            if (firstNumber > 0 && secondNumber > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (firstNumber < 0 && secondNumber > 0)
            {
                Console.WriteLine("segundo");
            }
            else if (firstNumber < 0 && secondNumber < 0)
            {
                Console.WriteLine("terceiro");
            }
            else if (firstNumber > 0 && secondNumber < 0)
            {
                Console.WriteLine("quarto");
            }
            else if (firstNumber == 0 || secondNumber == 0)
            {
                return;
            }
        }

    }

}