int nNumb = int.Parse(Console.ReadLine());
int startNumber = nNumb;

bool isSpecial = true;

while (nNumb > 0)
{
    int lastDigit = nNumb % 10;

    if (startNumber % lastDigit != 0)
    {
        isSpecial = false;
        break;
    }
    nNumb = nNumb / 10;
}

if (isSpecial == true)
{
    Console.WriteLine(startNumber + " is special");
}
else
{
    Console.WriteLine(startNumber + " is not special");
}
