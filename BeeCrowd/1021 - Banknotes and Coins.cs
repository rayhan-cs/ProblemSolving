using System;

class URI
{

    static void Main(string[] args)
    {

        var ammount = Convert.ToDouble(Console.ReadLine());
        var tenhundredFound = 0;
        var fiftyFound = 0;
        var twentyFound = 0;
        var tenFound = 0;
        var fiveFound = 0;
        var twoFound = 0;
        var OneFound = 0;
        var fiftyCoins = 0;
        var twentyfiveCoins = 0;
        var tenCoins = 0;
        var fiveCoins = 0;
        var oneCoins = 0;

        while (ammount > 0.0 && ammount != 0.0)
        {
            if (ammount > 0 && ammount <= 0.04)
            {

                ammount = ammount - 0.01;
                oneCoins++;
            }
            else if (ammount >= 0.05 && ammount < 0.10)
            {
                ammount = ammount - 0.05;
                fiveCoins++;
            }
            else if (ammount >= 0.10 && ammount < 0.25)
            {
                ammount = ammount - 0.10;
                tenCoins++;
            }
            else if (ammount >= 0.25 && ammount < 0.50)
            {
                ammount = ammount - 0.25;
                twentyfiveCoins++;
            }
            else if (ammount >= 0.50 && ammount < 1)
            {
                ammount = ammount - 0.50;
                fiftyCoins++;
            }
            else if (ammount >= 1 && ammount < 2)
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
        Console.WriteLine("NOTAS:");
        Console.WriteLine(tenhundredFound + " nota(s) de R$ 100.00");
        Console.WriteLine(fiftyFound + " nota(s) de R$ 50.00");
        Console.WriteLine(twentyFound + " nota(s) de R$ 20.00");
        Console.WriteLine(tenFound + " nota(s) de R$ 10.00");
        Console.WriteLine(fiveFound + " nota(s) de R$ 5.00");
        Console.WriteLine(twoFound + " nota(s) de R$ 2.00");


        Console.WriteLine("MOEDAS:");
        Console.WriteLine(OneFound + " moeda(s) de R$ 1.00");
        Console.WriteLine(fiftyCoins + " moeda(s) de R$ 0.50");
        Console.WriteLine(twentyfiveCoins + " moeda(s) de R$ 0.25");
        Console.WriteLine(tenCoins + " moeda(s) de R$ 0.10");
        Console.WriteLine(fiveCoins + " moeda(s) de R$ 0.05");
        Console.WriteLine(oneCoins - 1 + " moeda(s) de R$ 0.01");

    }

}