using System;

class URI
{

    static void Main(string[] args)
    {

        var line = Console.ReadLine();
        string[] lineParts = line.Split(' ');

        double[] codeQty = new double[lineParts.Length];
        var ammountOfPay = 0.0;

        for (int i = 0; i  lineParts.Length; i++)
{
            codeQty[i] = Convert.ToDouble(lineParts[i]);
        }

        for (int i = 0; i  codeQty.Length - 1; i++)
{
            if (codeQty[i] == 1)
            {
                ammountOfPay = codeQty[i + 1]  4.00;
                Console.WriteLine(Total R$  +ammountOfPay.ToString(f2));
            }
            else if (codeQty[i] == 2)
            {
                ammountOfPay = codeQty[i + 1]  4.50;
                Console.WriteLine(Total R$  +ammountOfPay.ToString(f2));
            }
            else if (codeQty[i] == 3)
            {
                ammountOfPay = codeQty[i + 1]  5.00;
                Console.WriteLine(Total R$  +ammountOfPay.ToString(f2));
            }
            else if (codeQty[i] == 4)
            {
                ammountOfPay = codeQty[i + 1]  2.00;
                Console.WriteLine(Total R$  +ammountOfPay.ToString(f2));
            }
            else if (codeQty[i] == 5)
            {
                ammountOfPay = codeQty[i + 1]  1.50;
                Console.WriteLine(Total R$  +ammountOfPay.ToString(f2));
            }
        }

    }

}