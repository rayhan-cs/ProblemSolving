using System;

class URI
{

    static void Main(string[] args)
    {

        var x = Convert.ToInt32(Console.ReadLine());
        var y = Convert.ToInt32(Console.ReadLine());

        var oddNumber = 0;

        for (int i = y + 1; i < x; i++)
        {
            if (i % 2 != 0)
            {
                oddNumber = oddNumber + i;
            }

        }
        Console.WriteLine(oddNumber);

    }

}