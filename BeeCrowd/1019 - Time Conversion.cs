using System;

class URI
{

    static void Main(string[] args)
    {

        var durationofTime = Convert.ToInt32(Console.ReadLine());
        var hours = 0;
        var minutes = 0;
        var seconds = 0;

        while (durationofTime > 0 && durationofTime != 0)
        {
            if (durationofTime >= 60 && durationofTime < 3600)
            {
                durationofTime = durationofTime - 60;
                minutes++;
            }
            else if (durationofTime > 3600)
            {
                durationofTime = durationofTime - 3600;
                hours++;
            }
            else if (durationofTime < 60)
            {
                durationofTime = durationofTime - 1;
                seconds++;
            }

        }
        Console.WriteLine(hours + ":" + minutes + ":" + seconds);

    }

}