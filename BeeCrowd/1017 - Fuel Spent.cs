using System;

class URI
{

    static void Main(string[] args)
    {

        var time = Convert.ToInt32(Console.ReadLine());
        var speed = Convert.ToInt32(Console.ReadLine());

        double liter = speed / 12.0;

        var FuelSpent = liter * time;

        Console.WriteLine(FuelSpent.ToString("F3"));

    }

}