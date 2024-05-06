using System;

class URI
{

    static void Main(string[] args)
    {

        var numbers = new int[100];
        var positions = 0;
        var heights = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (heights < numbers[i])
            {
                heights = numbers[i];
                positions = i + 1;
            }
        }
        Console.WriteLine(heights);
        Console.WriteLine(positions);

    }

}