using System;

class URI
{

    static void Main(string[] args)
    {

        for (int i = 0; i < 100; i++)
        {
            var inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber == 2002)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
            {
                Console.WriteLine("Senha Invalida");
            }
        }

    }

}