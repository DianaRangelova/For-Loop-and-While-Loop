int nNumb = int.Parse(Console.ReadLine());
int numbDividedBy2 = 0;
int numbDividedBy3 = 0;
int numbDividedBy4 = 0;

for (int i = 1; i <= nNumb; i++)
{
    int value = int.Parse(Console.ReadLine());
    if (value % 2 == 0)
    {
        numbDividedBy2++;
    }

    if (value % 3 == 0)
    {
        numbDividedBy3++;
    }

    if (value % 4 == 0)
    {
        numbDividedBy4++;
    }
}
double valueNumbDivBy2 = numbDividedBy2 * 1.0 / nNumb * 100;
double valueNumbDivBy3 = numbDividedBy3 * 1.0 / nNumb * 100;
double valueNumbDivBy4 = numbDividedBy4 * 1.0 / nNumb * 100;

Console.WriteLine($"{valueNumbDivBy2:f2}%");
Console.WriteLine($"{valueNumbDivBy3:f2}%");
Console.WriteLine($"{valueNumbDivBy4:f2}%");

