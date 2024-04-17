using System;

class URI
{

    static void Main(string[] args)
    {

        var squaree = 0;
        var number = Convert.ToInt32(Console.ReadLine());

        var evenNumber = 2;

        for (int i = 0; i <= number; i++)
        {
            if (number >= evenNumber)
            {
                squaree = evenNumber * evenNumber;
                Console.WriteLine(+evenNumber + "^2 = " + squaree);
                evenNumber = evenNumber + 2;
            }
        }

    }

}