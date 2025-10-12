int[] array1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (var item in array1)
{
	if (array2.Contains(item))
	{
		Console.Write(item + " "); 
	}
}



