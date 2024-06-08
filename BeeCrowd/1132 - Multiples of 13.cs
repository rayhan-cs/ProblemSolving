using System;

class URI
{

    static void Main(string[] args)
    {

        var inputNumber = new int[2];
        var sum = 0;
        var firstNumber = 0;
        var secondNumber = 0;

        for (int i = 0; i < 2; i++)
        {
            inputNumber[i] = Convert.ToInt32(Console.ReadLine());
        }

        firstNumber = inputNumber[0];
        secondNumber = inputNumber[1];
        if (firstNumber < secondNumber)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {
                if (j % 13 != 0)
                {
                    sum = sum + j;
                }
            }
        }
        else if (secondNumber < firstNumber)
        {
            for (int j = secondNumber; j <= firstNumber; j++)
            {
                if (j % 13 != 0)
                {
                    sum = sum + j;
                }
            }
        }
        Console.WriteLine(sum);

    }

}