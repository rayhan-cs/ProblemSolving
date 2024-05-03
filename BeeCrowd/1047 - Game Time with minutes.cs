var durationsHours = 0;
var durationsMinutes = 0;
var line = Console.ReadLine() ?? string.Empty;
var lineParts = line.Split(' ');

int[] numbers = new int[lineParts.Length];

for (int i = 0; i < lineParts.Length; i++)
{
    numbers[i] = Convert.ToInt32(lineParts[i]);
}

for (int i = 0; numbers.Length - 3 > i; i++)
{
    if (numbers[i] > numbers[i + 2] && numbers[i + 1] > numbers[i + 3])
    {
        durationsHours = (24 - numbers[i] + numbers[i + 2]);
        durationsMinutes = (60 - numbers[i + 1] + numbers[i + 3]);
    }
    if (numbers[i] > numbers[i + 2] && numbers[i + 1] > numbers[i + 3])
    {
        durationsHours = (24 - numbers[i] + numbers[i + 2]);
        durationsMinutes = (60 - numbers[i + 1] + numbers[i + 3]);
    }
    else if (numbers[i] < numbers[i + 2] && numbers[i + 1] < numbers[i + 3])
    {
        durationsHours = (numbers[i + 2] - numbers[i]);
        durationsMinutes = (numbers[i + 3] - numbers[i + 1]);
    }
    else if (numbers[i] < numbers[i + 2] && numbers[i + 1] > numbers[i + 3])
    {
        durationsMinutes = (60 - numbers[i + 1] + numbers[i + 3]);
        durationsHours = (numbers[i + 2] - numbers[i]) - 1;
    }
    else if (numbers[i] == numbers[i + 2] && numbers[i + 1] == numbers[i + 3])
    {
        durationsHours += 24;
        durationsMinutes = 0;
    }

}
Console.WriteLine($"O JOGO DUROU {durationsHours} HORA(S) E {durationsMinutes} MINUTO(S)");