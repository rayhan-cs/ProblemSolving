using System;

class URI
{

    static void Main(string[] args)
    {

        var sum = 0;
        var sum2 = 0;
        var firstNumber = 0;
        var secondNumber = 0;
        var number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            var line = Console.ReadLine();
            var lineParts = line.Split(' ');

            firstNumber = int.Parse(lineParts[0]);
            secondNumber = int.Parse(lineParts[1]);

            if (firstNumber < secondNumber)
            {
                for (int j = firstNumber + 1; j < secondNumber; j++)
                {
                    if (j % 2 != 0)
                    {
                        sum2 = sum2 + j;
                    }
                }
                Console.WriteLine(sum2);
                sum2 = 0;
            }

            else if (firstNumber > secondNumber)
            {
                for (int j = secondNumber + 1; j < firstNumber; j++)
                {
                    if (j % 2 != 0)
                    {
                        sum = sum + j;
                    }
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            else if (secondNumber == firstNumber)
            {
                Console.WriteLine(0);
            }
        }

    }

}