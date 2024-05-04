var taxToPay = 0.0;
var salaryPartOne = 0.0;
var salaryPartTwo = 0.0;
var taxToPayOne = 0.0;
var taxToPayTwo = 0.0;
var salary = Convert.ToDouble(Console.ReadLine());

if (salary > 2000.00 && salary < 4500.00)
{
    salary = salary - 2000.00;
    salaryPartTwo = salary - 1000;
    salaryPartOne = salary - salaryPartTwo;
    if (salaryPartTwo > 0.00 && salaryPartTwo <= 1000.00)
    {
        taxToPayTwo = (salaryPartTwo * 18) / 100;
        taxToPayOne = (salaryPartOne * 8) / 100;
        taxToPay = taxToPayOne + taxToPayTwo;
        Console.WriteLine("R$ " + taxToPay.ToString("f2"));
    }
}
else if (salary > 4500.00)
{
    salary = salary - 2000.00;
    salaryPartTwo = salary - 1000;
    salaryPartOne = salary - salaryPartTwo;
    if (salaryPartOne >= 1000.00)
    {
        taxToPayOne = salaryPartOne * 8 / 100;
        taxToPayTwo = salaryPartTwo * 18 / 100;

        taxToPay = taxToPayOne + taxToPayTwo;
        Console.WriteLine("R$ " + taxToPay.ToString("F2"));
    }

}
else if (salary < 2000)
{
    Console.WriteLine("Isento");
}