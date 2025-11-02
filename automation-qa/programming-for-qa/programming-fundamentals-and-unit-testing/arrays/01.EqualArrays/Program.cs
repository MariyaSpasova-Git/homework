string[] array1 = Console.ReadLine().Split(" ").ToArray();
string[] array2 = Console.ReadLine().Split(" ").ToArray();

bool areIdentical = true;

if (array1.Length == array2.Length)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            areIdentical = false;
            break;
        }
    }
}

else
{
    areIdentical = false;
}

if (areIdentical)
{
    Console.WriteLine("Arrays are identical.");
}

else
{
    Console.WriteLine("Arrays are not identical.");
}