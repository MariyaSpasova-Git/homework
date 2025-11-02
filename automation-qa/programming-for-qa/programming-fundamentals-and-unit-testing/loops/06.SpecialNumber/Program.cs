int originalNumber = int.Parse(Console.ReadLine());
int remainder = originalNumber;
bool isSpecial = true;

while (remainder != 0)
{
    int lastDigit = remainder % 10;

    if (originalNumber % lastDigit != 0)
    {
        isSpecial = false;
        break;
    }
    remainder /= 10;
}

if (isSpecial)
{
    Console.WriteLine($"{originalNumber} is special");
}
else
{
    Console.WriteLine($"{originalNumber} is not special");
}
