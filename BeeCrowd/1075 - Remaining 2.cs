using System;

class URI
{

    static void Main(string[] args)
    {

        var number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            for (int i = 1; i < 10000; i++)
            {
                if (i % number == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }

}