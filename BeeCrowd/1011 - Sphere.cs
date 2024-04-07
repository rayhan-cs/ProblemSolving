using System;

class URI
{

    static void Main(string[] args)
    {

        double pi = 3.14159;
        double r = Convert.ToDouble(Console.ReadLine());
        double rrr = r * r * r;
        double VOLUME = (4 / 3.0) * pi * rrr;

        Console.WriteLine("VOLUME = " + VOLUME.ToString("F3"));

    }

}