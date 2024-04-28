using System;

class URI
{

    static void Main(string[] args)
    {

        var durationofTime = Convert.ToInt32(Console.ReadLine());
        var years = 0;
        var months = 0;
        var days = 0;

        while (durationofTime > 0 && durationofTime != 0)
        {
            if (durationofTime >= 30 && durationofTime < 365)
            {
                durationofTime = durationofTime - 30;
                months++;
            }
            else if (durationofTime > 365)
            {
                durationofTime = durationofTime - 365;
                years++;
            }
            else if (durationofTime < 30)
            {
                durationofTime = durationofTime - 1;
                days++;
            }

        }
        Console.WriteLine(years + " ano(s)");
        Console.WriteLine(months + " mes(es)");
        Console.WriteLine(days + " dia(s)");

    }

}