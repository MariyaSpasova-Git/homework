string season = Console.ReadLine();
string accomodationType = Console.ReadLine();
int daysCount = int.Parse(Console.ReadLine());

//if (accomodationType == "Hotel")
//{
//    if (season == "Spring")
//    {
//        double totalExpenses = daysCount * 30 * 0.8;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//    else if (season == "Summer")
//    {
//        double totalExpenses = daysCount * 50;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//    else if (season == "Autumn")
//    {
//        double totalExpenses = daysCount * 20 * 0.7;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//    else if (season == "Winter")
//    {
//        double totalExpenses = daysCount * 40 * 0.9;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//}
//else if (accomodationType == "Camping")
//{
//    if (season == "Spring")
//    {
//        double totalExpenses = daysCount * 10 * 0.8;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//    else if (season == "Summer")
//    {
//        double totalExpenses = daysCount * 30;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//    else if (season == "Autumn")
//    {
//        double totalExpenses = daysCount * 15 * 0.7;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//    else if (season == "Winter")
//    {
//        double totalExpenses = daysCount * 10 * 0.9;
//        Console.WriteLine($"{totalExpenses:F2}");
//    }
//}

double discount = 0;
double pricePerDay = 0;

if (season == "Spring")
{
    discount = 0.2;

    if (accomodationType == "Hotel")
    {
        pricePerDay = 30;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 10;
    }
}
else if (season == "Summer")
{
    discount = 0;

    if (accomodationType == "Hotel")
    {
        pricePerDay = 50;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 30;
    }
}
else if (season == "Autumn")
{
    discount = 0.3;

    if (accomodationType == "Hotel")
    {
        pricePerDay = 20;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 15;
    }
}
else if (season == "Winter")
{
    discount = 0.1;

    if (accomodationType == "Hotel")
    {
        pricePerDay = 40;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 10;
    }
}

double stayCost = pricePerDay * daysCount;
double discountedCost = stayCost * discount;
double totalCost = stayCost - discountedCost;

Console.WriteLine($"{totalCost:F2}");
