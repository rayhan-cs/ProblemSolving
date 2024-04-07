using System;

class URI
{

    static void Main(string[] args)
    {

        var X = Convert.ToInt32(Console.ReadLine());
        var Y = Convert.ToDouble(Console.ReadLine());

        var average = X / Y;

        Console.WriteLine(average.ToString("F3") + " km/l");

    }

}