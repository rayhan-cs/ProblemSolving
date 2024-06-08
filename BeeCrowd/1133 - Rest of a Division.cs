using System;

class URI
{

    static void Main(string[] args)
    {

        var inputNumber = new int[2];
        var firstNumber = 0;
        var secondNumber = 0;

        for (int i = 0; i < 2; i++)
        {
            inputNumber[i] = Convert.ToInt32(Console.ReadLine());
        }

        firstNumber = inputNumber[0];
        secondNumber = inputNumber[1];

        if (firstNumber > 0 && secondNumber > 0)
        {
            if (firstNumber < secondNumber)
            {
                for (int j = firstNumber + 1; j < secondNumber; j++)
                {
                    if (j % 5 == 2 || j % 5 == 3)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            else if (secondNumber < firstNumber)
            {
                for (int j = secondNumber + 1; j < firstNumber; j++)
                {
                    if (j % 5 == 2 || j % 5 == 3)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }

    }

}