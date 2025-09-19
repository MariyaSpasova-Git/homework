double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;
double deliveryCost = 2.50;

int chickenMenusNumber = int.Parse (Console.ReadLine());
int fishMenusNumber = int.Parse (Console.ReadLine());
int vegetarianMenusNumber = int.Parse (Console.ReadLine());

double chickenMenusCost = chickenMenuPrice * chickenMenusNumber;
double fishMenusCost = fishMenuPrice * fishMenusNumber;
double vegetarianMenusCost = vegetarianMenuPrice * vegetarianMenusNumber;
double menusCost = chickenMenusCost + fishMenusCost + vegetarianMenusCost;
double dessertCost = menusCost * 0.20;
double totalCost = menusCost + dessertCost + deliveryCost;

Console.WriteLine(totalCost);

