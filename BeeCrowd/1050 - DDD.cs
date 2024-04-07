using System;

class URI
{

    static void Main(string[] args)
    {

        var number = Convert.ToInt32(Console.ReadLine());

        if (number / 2 != 0)
        {
            if (number == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if (number == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (number == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (number == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (number == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else if (number == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (number == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (number == 71)
            {
                Console.WriteLine("Salvador");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
        else
        {
            Console.WriteLine("Please Inter Odd Number");
        }

    }

}