int elementsNumber = int.Parse(Console.ReadLine());
int[] firstArray = new int[elementsNumber];
int[] secondArray = new int[elementsNumber];

for (int i = 0; i < elementsNumber; i++)
{
    int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = inputArray[0];
        secondArray[i] = inputArray[1];
    }
    else
    {
        firstArray[i] = inputArray[1];
        secondArray[i] = inputArray[0];
    }
}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));
