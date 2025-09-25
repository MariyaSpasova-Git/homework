int count = int.Parse(Console.ReadLine());
int biggestNumber = int.MinValue;

for (int i = 1; i <= count; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number > biggestNumber)
    {
        biggestNumber = number;
    }
}

Console.WriteLine(biggestNumber);
