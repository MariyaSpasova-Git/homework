int[] array1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int itemArray1 in array1)
{
	foreach (int itemArray2 in array2)
	{
		if (itemArray1 == itemArray2)
		{
			Console.Write(itemArray1 + " "); 
		}
	}
}


