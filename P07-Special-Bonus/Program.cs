int stopNumb = int.Parse(Console.ReadLine());
int prevNumb = 0;

while (true)
{
    int nNumb = int.Parse(Console.ReadLine());
    if (nNumb == stopNumb)
    {
        Console.WriteLine(prevNumb * 0.2);
        break;
    }

    prevNumb = nNumb;
}