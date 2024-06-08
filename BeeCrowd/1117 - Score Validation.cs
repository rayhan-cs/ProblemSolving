using System;

class URI
{

    static void Main(string[] args)
    {

        int notFound = 0;
        int count = 0;
        int j = 0;
        var sum = 0.0;
        var media = 0.0;
        var numbers = new double[2];

        while (true)
        {
            var inputNumber = Convert.ToDouble(Console.ReadLine());

            if (inputNumber > 0 && inputNumber <= 10)
            {
                numbers[j] = inputNumber;
                sum = sum + (double)numbers[j];
                j++;
                count++;
                if (count == 2)
                {
                    break;
                }
            }
            notFound++;
        }

        for (int i = 1; i < notFound; i++)
        {
            Console.WriteLine("nota invalida");
        }
        media = sum / count;
        Console.WriteLine("media = " + media);

    }

}