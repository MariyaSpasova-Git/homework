int annualFee = int.Parse(Console.ReadLine());

double sneakerCost = annualFee * 0.60;
double uniformCost = sneakerCost * 0.80;
double ballCost = uniformCost / 4;
double accessories = ballCost / 5;

double totalCost = annualFee + sneakerCost + uniformCost + ballCost + accessories;

Console.WriteLine(totalCost);