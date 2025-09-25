string input = Console.ReadLine();
double balance = 0;

while (input != "End")
{
    double transaction = double.Parse(input);
    balance += transaction;

    if (transaction > 0)
    {
        Console.WriteLine($"Increase: {transaction:F2}");
    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(transaction):F2}");
    }
    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {balance:F2}");
