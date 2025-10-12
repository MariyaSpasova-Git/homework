int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

while (numbers.Length > 1)
{
    int[] condensedNumbers = new int[numbers.Length - 1];

    for (int position = 0; position < numbers.Length - 1; position++)
    {
        condensedNumbers[position] = numbers[position] + numbers[position + 1];
    }

    numbers = condensedNumbers;
}

Console.WriteLine(numbers[0]);