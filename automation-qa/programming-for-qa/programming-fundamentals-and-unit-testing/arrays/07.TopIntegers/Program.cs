int[] sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < sequence.Length; i++)
{
    int currentElement = sequence[i];

    bool isBigger = true;

    for (int j = i + 1; j < sequence.Length; j++)
    {
        int nextRightElement = sequence[j];

        if (currentElement <= nextRightElement)
        {
            isBigger = false;
            break;
        }
    }

    if (isBigger)
    {
        Console.Write(currentElement + " ");
    }
}

