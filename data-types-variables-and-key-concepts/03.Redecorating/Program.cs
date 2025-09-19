double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;
double bagsCost = 0.40;

int nylonAmount = int.Parse(Console.ReadLine());
int paintAmount = int.Parse(Console.ReadLine());
int thinnerQuantity = int.Parse(Console.ReadLine());
int neededWorkingHours = int.Parse(Console.ReadLine());

double nylonCost = nylonPrice * (nylonAmount + 2);
double paintCost = paintPrice * paintAmount * 1.1;
double thinnerCost = thinnerPrice * thinnerQuantity;
double materialsCost = nylonCost + paintCost + thinnerCost + bagsCost;
double workCost = materialsCost * neededWorkingHours * 0.3;
double totalCost = materialsCost + workCost;

Console.WriteLine(totalCost);



