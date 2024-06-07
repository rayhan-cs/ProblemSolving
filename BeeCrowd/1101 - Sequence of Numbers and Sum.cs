using System;

class URI
{

    static void Main(string[] args)
    {

        var sum = 0;
        var firstNumber = 0;
        var secondNumber = 0;

        while (true)
        {
            var line = Console.ReadLine();
            var lineParts = line.Split(' ');

            firstNumber = int.Parse(lineParts[0]);
            secondNumber = int.Parse(lineParts[1]);

            if (firstNumber < 1 || secondNumber < 1)
            {
                return;
            }
            else if (firstNumber > secondNumber)
            {
                for (int i = secondNumber; i <= firstNumber; i++)
                {
                    Console.Write(i + " ");
                }
                for (int i = secondNumber; i <= firstNumber; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum=" + sum);
                sum = 0;
            }
            else if (firstNumber < secondNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    Console.Write(i + " ");
                }
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum=" + sum);
                sum = 0;
            }
        }

    }

}