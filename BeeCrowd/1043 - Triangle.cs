var i = 0;
var Perimetro = 0.0;
var area = 0.0;
var line = Console.ReadLine() ?? string.Empty;
string[] lineParts = line.Split(' ');

double[] numbers = new double[lineParts.Length];

foreach (var part in lineParts)
{
    numbers[i] = Convert.ToDouble(part);
    i++;
}
for (int j = 0; j < numbers.Length - 2; j++)
{
    if (numbers[j] + numbers[j + 1] > numbers[j + 2] && numbers[j] + numbers[j + 2] > numbers[j + 1] && numbers[j + 1] + numbers[j + 2] > numbers[j])
    {
        Perimetro = numbers[j] + numbers[j + 1] + numbers[j + 2];
        Console.WriteLine("Perimetro = " + Perimetro.ToString("f1"));
    }
    else
    {
        area = (numbers[j] + numbers[j + 1]) * numbers[j + 2] / 2;
        Console.WriteLine("Area = " + area.ToString("f1"));
    }
}