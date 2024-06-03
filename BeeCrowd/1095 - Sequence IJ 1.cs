using System;

class URI
{

    static void Main(string[] args)
    {

        int i = -2;
        var found = 0;

        for (int j = 60; j >= 0; j = j - 5)
        {
            i = i + 3;
            Console.WriteLine("I=" + i + " J=" + j);
        }

    }

}