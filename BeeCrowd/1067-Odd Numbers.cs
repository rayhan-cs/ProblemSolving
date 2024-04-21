using System;

class URI
{

    static void Main(string[] args)
    {

        var number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i = i + 2)
        {
            Console.WriteLine(i);
        }

    }

}