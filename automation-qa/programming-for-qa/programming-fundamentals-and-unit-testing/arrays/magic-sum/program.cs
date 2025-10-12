int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int controlNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length - 1; i++)
{   
    int array1Element = array[i];

    for (int j = i + 1; j < array.Length; j++)
    {
        int array2Element = array[j];

        if (array1Element + array2Element == controlNumber)
        {
            Console.WriteLine($"{array1Element} {array2Element}");
            break;
        }
    }
}
