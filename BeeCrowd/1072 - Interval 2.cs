using System;

class URI
{

    static void Main(string[] args)
    {

        var inNumber = 0;
        var outNumber = 0;
        var integerNeed = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[integerNeed];

        for (int i = 0; i < integerNeed; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 10 && numbers[i] <= 20)
            {
                inNumber++;
            }
            else
            {
                outNumber++;
            }
        }
        Console.WriteLine(inNumber + " in");
        Console.WriteLine(outNumber + " out");

    }

}