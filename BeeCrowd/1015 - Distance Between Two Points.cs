using System;

class URI
{

    static void Main(string[] args)
    {

        var i = 0;
        var j = 0;
        int p = 0;
        var DistanceX = 0.0;
        var DistanceY = 0.0;
        var totalDistance = 0.0;
        var input1 = Console.ReadLine() ?? String.Empty;
        string[] inputParts1 = input1.Split(' ');

        var input2 = Console.ReadLine() ?? String.Empty;
        string[] inputParts2 = input2.Split(' ');

        double[] line1 = new double[inputParts1.Length];
        double[] line2 = new double[inputParts1.Length];

        foreach (var item1 in inputParts1)
        {
            line1[i] = Convert.ToDouble(item1);
            i++;
        }
        foreach (var item2 in inputParts2)
        {
            line2[j] = Convert.ToDouble(item2);
            j++;
        }

        DistanceX = line2[p] - line1[p];
        DistanceY = line1[p + 1] - line2[p + 1];

        totalDistance = ((DistanceX * DistanceX) + (DistanceY * DistanceY));

        Console.WriteLine(Math.Sqrt(totalDistance).ToString("F4"));

    }

}