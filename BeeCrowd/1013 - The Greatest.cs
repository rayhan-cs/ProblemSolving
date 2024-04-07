using System;

class URI
{

    static void Main(string[] args)
    {

        var line = Console.ReadLine();
        string[] lineParts = line.Split(' ');

        var greatest = 0;

        foreach (string part in lineParts)
        {
            if (greatest < int.Parse(part))
            {
                greatest = int.Parse(part);
            }

        }
        Console.WriteLine(greatest + " eh o maior");

    }

}