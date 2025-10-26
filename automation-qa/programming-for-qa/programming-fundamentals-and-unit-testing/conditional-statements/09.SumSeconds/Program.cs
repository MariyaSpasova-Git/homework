int firstAthleteTimeInSeconds = int.Parse(Console.ReadLine());
int secondAthleteTimeInSeconds = int.Parse(Console.ReadLine());
int thirdAthleteTimeInSeconds = int.Parse(Console.ReadLine());

int totalTimeInSeconds = firstAthleteTimeInSeconds + secondAthleteTimeInSeconds + thirdAthleteTimeInSeconds;
int totalMinutes = totalTimeInSeconds / 60;
int totalSeconds = totalTimeInSeconds % 60;
Console.WriteLine($"{totalMinutes}:{totalSeconds:D2}");