int temperature = int.Parse(Console.ReadLine());
string timeOfTheDay = Console.ReadLine();

string clothing = "";
string shoes = "";

if (timeOfTheDay == "Morning")
{
    if (temperature >=10 && temperature <=18)
    {
        clothing = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (temperature > 18 && temperature <=24)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temperature >= 25)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (timeOfTheDay == "Afternoon")
{
    if (temperature >= 10 && temperature <= 18)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temperature > 18 && temperature <= 24)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }
    else if (temperature >= 25)
    {
        clothing = "Swim Suit";
        shoes = "Barefoot";
    }
}
else if (timeOfTheDay == "Evening")
{
    clothing = "Shirt";
    shoes = "Moccasins";
}

Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");