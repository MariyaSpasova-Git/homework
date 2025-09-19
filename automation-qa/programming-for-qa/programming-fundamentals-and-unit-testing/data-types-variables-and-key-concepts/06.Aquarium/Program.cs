int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double aquariumVolume = length * width * height;
double occupiedVolume = aquariumVolume * percentage / 100;

double waterVolumeInCubicCentimeters = aquariumVolume - occupiedVolume;
double waterVolumeInLiters = waterVolumeInCubicCentimeters / 1000;

Console.WriteLine($"{waterVolumeInLiters:F2}");