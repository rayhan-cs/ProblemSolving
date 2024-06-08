using System;

class URI
{

    static void Main(string[] args)
    {

        var result = 1;
        var numbers = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numbers; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result = result * i;
                Console.Write(result);
                if (j < 2)
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
            result = 1;
        }

    }

}