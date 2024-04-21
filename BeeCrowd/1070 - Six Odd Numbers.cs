using System;

class URI
{

    static void Main(string[] args)
    {

        var number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            for (int i = 1; i <= 11; i = i + 2)
            {
                var oddNumber = number + i;
                Console.WriteLine(oddNumber);
            }
        }
        else
        {
            for (int i = 0; i < 12; i = i + 2)
            {
                var oddNumber = number + i;
                Console.WriteLine(oddNumber);
            }
        }

    }

}