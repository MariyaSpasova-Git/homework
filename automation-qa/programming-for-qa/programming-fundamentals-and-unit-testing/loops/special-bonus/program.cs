int stopNumber = int.Parse(Console.ReadLine());
int currentNumber = int.Parse(Console.ReadLine());
int previousNumber = currentNumber;

while (currentNumber != stopNumber)
{
    previousNumber = currentNumber;
    currentNumber = int.Parse(Console.ReadLine());
}

    Console.WriteLine(previousNumber * 1.2);
