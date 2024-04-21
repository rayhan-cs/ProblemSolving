using System;

class URI
{

    static void Main(string[] args)
    {

        var number = 0;
        var line = Console.ReadLine();
        string[] lineParts = line.Split(' ');

        foreach (string part in lineParts)
        {
            if ((Convert.ToDouble(part) >= 1))
            {
                number++;
            }
        }
        Console.WriteLine(number + " valores positivos");

    }

}