using System;

class URI
{

    static void Main(string[] args)
    {

        var firstNumber = 0.0;
        var secondNumber = 0.0;
        var inputNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < inputNumber; i++)
        {
            var line = Console.ReadLine();
            var lineParts = line.Split(' ');

            firstNumber = int.Parse(lineParts[0]);
            secondNumber = int.Parse(lineParts[1]);

            if (secondNumber > -1 && secondNumber < 1)
            {
                Console.WriteLine("divisao impossivel");
            }
            else if (firstNumber < 1 && firstNumber > -1)
            {
                Console.WriteLine(0.0.ToString("F1"));
            }
            else if (firstNumber > secondNumber)
            {
                double division = firstNumber / secondNumber;
                Console.WriteLine(division.ToString("F1"));
                division = 0;
            }
            else if (firstNumber < secondNumber)
            {
                double division = firstNumber / secondNumber;
                Console.WriteLine(division.ToString("F1"));
                division = 0;
            }

        }

    }

}