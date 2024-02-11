int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int multiplicationResult = 1;

for (int i = 0; i < p; i++)
{
    multiplicationResult *= n;
}

Console.WriteLine(multiplicationResult);
