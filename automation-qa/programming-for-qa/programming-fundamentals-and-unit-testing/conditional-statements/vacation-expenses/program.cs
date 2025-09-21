string season = Console.ReadLine();
string accomodationType = Console.ReadLine();
int daysCount = int.Parse(Console.ReadLine());

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
