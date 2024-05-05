using System;

class URI
{

    static void Main(string[] args)
    {

        var number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {number} = " + number * i);
            }
        }

    }

}