using System;

class URI
{

    static void Main(string[] args)
    {
        double[] numbers = new double[4];
        double[] weights = { 2.0, 3.0, 4.0, 1.0 };
        var average = 0.0;
        var average2 = 0.0;
        var line = Console.ReadLine() ?? string.Empty;
        var lineParts = line.Split(' ');
        
        for (int i = 0; i < lineParts.Length; i++)
        {
            numbers[i] = double.Parse(lineParts[i]);
        }
        for (int i = 0; i < 1; i++)
        {
            average = ((numbers[i] * weights[0]) + (numbers[i + 1] * weights[1]) + (numbers[i + 2] * weights[2]) + (numbers[i + 3] * weights[3]))
                / (weights[0] + weights[1] + weights[2] + weights[3]);

            Console.WriteLine("Media: " + average.ToString("f1"));

            if (average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (average < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (average >= 5.0 && average <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                var newScroe = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + newScroe.ToString("f1"));

                average2 = (average + newScroe) / 2.0;

                if (average2 >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if (average2 <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + average2.ToString("f1"));
            }
        }

    }

}