using System;

class URI
{

    static void Main(string[] args)
    {

        var r = 1.0;
        var range = 3.0;
        for (var i = 0.0; i <= 2; i = i + 0.2)
        {
            for (var j = r; j <= range; j++)
            {
                Console.WriteLine("I=" + i + " J=" + j);
            }
            r = r + 0.2;
            range = range + 0.2;
        }

    }

}