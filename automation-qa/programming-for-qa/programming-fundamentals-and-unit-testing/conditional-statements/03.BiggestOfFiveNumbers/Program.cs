int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int fourthNumber = int.Parse(Console.ReadLine());
int fifthNumber = int.Parse(Console.ReadLine());

int biggestNumber;

if (firstNumber >= secondNumber
    && firstNumber >= thirdNumber
    && firstNumber >= fourthNumber
    && firstNumber >= fifthNumber)
{
    biggestNumber = firstNumber;
}
else if (secondNumber >= firstNumber
    && secondNumber >= thirdNumber
    && secondNumber >= fourthNumber
    && secondNumber >= fifthNumber)
{
    biggestNumber = secondNumber;
}
else if (thirdNumber >= firstNumber
    && thirdNumber >= secondNumber
    && thirdNumber >= fourthNumber
    && thirdNumber >= fifthNumber)
{
    biggestNumber = thirdNumber;
}
else if (fourthNumber >= firstNumber
    && fourthNumber >= secondNumber
    && fourthNumber >= thirdNumber
    && fourthNumber >= fifthNumber)
{
    biggestNumber = fourthNumber;
}
else
{
    biggestNumber = fifthNumber;
}

Console.WriteLine(biggestNumber);