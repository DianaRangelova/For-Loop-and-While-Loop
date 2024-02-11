int nNumb = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= nNumb; i++)
{
    char nChar = char.Parse(Console.ReadLine());

    if (nChar == 'a')
    {
        sum += 1;
    }
    else if (nChar == 'e')
    {
        sum += 2;
    }
    else if (nChar == 'i')
    {
        sum += 3;
    }
    else if (nChar == 'o')
    {
        sum += 4;
    }
    else if (nChar == 'u')
    {
        sum += 5;
    }
}

Console.WriteLine(sum);

// With switch-case:

int number = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number; i++)
{
    char character = char.Parse(Console.ReadLine());

    switch (character)
    {
        case 'a':
            sum += 1;
            break;
        case 'e':
            sum += 2;
            break;
        case 'i':
            sum += 3;
            break;
        case 'o':
            sum += 4;
            break;
        case 'u':
            sum += 5;
            break;
    }
}
Console.WriteLine(sum);