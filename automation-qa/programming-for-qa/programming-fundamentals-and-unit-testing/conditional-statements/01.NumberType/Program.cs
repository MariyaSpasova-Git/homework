int number = int.Parse(Console.ReadLine());

string numberType;

if (number < 0)
{
    numberType = "negative";
}
else if (number == 0)
{
    numberType = "zero";
}
else
{
    numberType = "positive";
}

Console.WriteLine(numberType);
