using System;

class URI
{

    static void Main(string[] args)
    {

        var ammount = Convert.ToInt32(Console.ReadLine());
        var tenhundredFound = 0;
        var fiftyFound = 0;
        var twentyFound = 0;
        var tenFound = 0;
        var fiveFound = 0;
        var twoFound = 0;
        var OneFound = 0;
        Console.WriteLine(ammount);

        while (ammount > 0 && ammount != 0)
        {
            if (ammount >= 1 && ammount < 2)
            {
                ammount = ammount - 1;
                OneFound++;
            }
            else if (ammount >= 2 && ammount < 5)
            {
                ammount = ammount - 2;
                twoFound++;
            }
            else if (ammount >= 5 && ammount < 10)
            {
                ammount = ammount - 5;
                fiveFound++;
            }
            else if (ammount >= 10 && ammount < 20)
            {
                ammount = ammount - 10;
                tenFound++;
            }
            else if (ammount >= 20 && ammount < 50)
            {
                ammount = ammount - 20;
                twentyFound++;
            }
            else if (ammount >= 50 && ammount < 100)
            {
                ammount = ammount - 50;
                fiftyFound++;
            }
            else if (ammount >= 100)
            {
                ammount = ammount - 100;
                tenhundredFound++;
            }
        }

        Console.WriteLine(tenhundredFound + " nota(s) de R$ 100,00");
        Console.WriteLine(fiftyFound + " nota(s) de R$ 50,00");
        Console.WriteLine(twentyFound + " nota(s) de R$ 20,00");
        Console.WriteLine(tenFound + " nota(s) de R$ 10,00");
        Console.WriteLine(fiveFound + " nota(s) de R$ 5,00");
        Console.WriteLine(twoFound + " nota(s) de R$ 2,00");
        Console.WriteLine(OneFound + " nota(s) de R$ 1,00");

    }

}