int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rotationsNumber = int.Parse(Console.ReadLine());

int rotations = rotationsNumber % array.Length;

for (int i = 0; i < rotations; i++)
{
    int firstElement = array[0];
   
    for (int j = 1; j < array.Length; j++)
    {
        array[j - 1] = array[j];
    }

    array[array.Length - 1] = firstElement;
}

Console.WriteLine(string.Join(" ", array));