using System;

class URI
{

    static void Main(string[] args)
    {

        var r = 7;
        var range = 5;
        for (int i = 1; i <= 9; i = i + 2)
        {
            for (int j = r; j >= range; j = j - 1)
            {
                Console.WriteLine("I=" + i + " J=" + j);
            }
        }

    }

}