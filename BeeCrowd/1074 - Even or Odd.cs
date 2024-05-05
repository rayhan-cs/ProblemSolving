using System;

class URI
{

    static void Main(string[] args)
    {

        var inputNumber = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[inputNumber];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
            }
            else if (numbers[i] < 0)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
            else if (numbers[i] == 0)
            {
                Console.WriteLine("NULL");
            }

        }

    }

}