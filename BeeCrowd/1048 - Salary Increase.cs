using System;

class URI
{

    static void Main(string[] args)
    {

        var newSalary = 0.0;
        var moneyEarned = 0.0;
        var percentual = 0.0;
        var salary = Convert.ToDouble(Console.ReadLine());

        if (salary > 0 && salary <= 400.00)
        {
            percentual = 15;
            moneyEarned = salary * percentual / 100.00;
            newSalary = (salary + moneyEarned);
            Console.WriteLine("Novo salario: " + newSalary.ToString("f2"));
            Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("f2"));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
        else if (salary >= 400.01 && salary <= 800.00)
        {
            percentual = 12;
            moneyEarned = salary * percentual / 100.00;
            newSalary = (salary + moneyEarned);
            Console.WriteLine("Novo salario: " + newSalary.ToString("f2"));
            Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("f2"));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
        else if (salary >= 800.01 && salary <= 1200.00)
        {
            percentual = 10;
            moneyEarned = salary * percentual / 100.00;
            newSalary = (salary + moneyEarned);
            Console.WriteLine("Novo salario: " + newSalary.ToString("f2"));
            Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("f2"));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
        else if (salary > 1200.01 && salary <= 2000.00)
        {
            percentual = 7;
            moneyEarned = salary * percentual / 100.00;
            newSalary = (salary + moneyEarned);
            Console.WriteLine("Novo salario: " + newSalary.ToString("f2"));
            Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("f2"));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
        else if (salary > 2000.00)
        {
            percentual = 4;
            moneyEarned = salary * percentual / 100.00;
            newSalary = (salary + moneyEarned);
            Console.WriteLine("Novo salario: " + newSalary.ToString("f2"));
            Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("f2"));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }

    }

}