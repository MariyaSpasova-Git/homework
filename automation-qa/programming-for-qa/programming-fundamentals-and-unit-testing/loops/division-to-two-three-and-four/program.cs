int numbersCount = int.Parse(Console.ReadLine());

double divisibleBy2Count = 0;
double divisibleBy3Count = 0;
double divisibleBy4Count = 0;

for (int i = 1; i <= numbersCount; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        divisibleBy2Count++;
    }
    if (number % 3 == 0)
    {
        divisibleBy3Count++;
    }
    if ((number % 4) == 0)
    {
        divisibleBy4Count++; 
    }
}

double divisibleBy2Percentage = divisibleBy2Count * 100 / numbersCount;
double divisibleBy3Percentage = divisibleBy3Count * 100 / numbersCount;
double divisibleBy4Percentage = divisibleBy4Count * 100 / numbersCount;

Console.WriteLine($"{divisibleBy2Percentage:F2}%");
Console.WriteLine($"{divisibleBy3Percentage:F2}%");
Console.WriteLine($"{divisibleBy4Percentage:F2}%");
