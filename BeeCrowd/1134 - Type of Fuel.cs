using System;

class URI
{

    static void Main(string[] args)
    {

        var alcohol = 0;
        var gasoline = 0;
        var diesel = 0;

        while (true)
        {
            var numbers = Convert.ToInt32(Console.ReadLine());
            if (numbers > 0)
            {
                if (numbers >= 1 && numbers <= 4)
                {
                    if (numbers == 1)
                    {
                        alcohol = alcohol + 1;
                    }
                    else if (numbers == 2)
                    {
                        gasoline = gasoline + 1;
                    }
                    else if (numbers == 3)
                    {
                        diesel = diesel + 1;
                    }
                    else if (numbers == 4)
                    {
                        break;
                    }
                }

            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcohol);
        Console.WriteLine("Gasolina: " + gasoline);
        Console.WriteLine("Diesel: " + diesel);

    }

}