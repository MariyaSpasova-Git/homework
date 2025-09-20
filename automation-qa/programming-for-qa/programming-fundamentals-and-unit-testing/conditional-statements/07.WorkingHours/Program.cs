int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

string officeWorkingStatus;

//if (dayOfTheWeek == "Monday"
//    || dayOfTheWeek == "Tuesday"
//    || dayOfTheWeek == "Wednesday"
//    || dayOfTheWeek == "Thursday"
//    || dayOfTheWeek == "Friday"
//    || dayOfTheWeek == "Saturday")
//{
//    if (hourOfTheDay >= 10 && hourOfTheDay <= 18)
//    {
//        officeWorkingStatus = "open";
//    }
//    else
//    {
//        officeWorkingStatus = "closed";
//    }
//}
//else
//{
//    officeWorkingStatus = "closed";
//}

//Console.WriteLine(officeWorkingStatus);

if (dayOfTheWeek == "Sunday")
{
    officeWorkingStatus = "closed";
}
else
{
    if (hourOfTheDay >= 10 && hourOfTheDay <= 18)
    {
        officeWorkingStatus = "open";
    }
    else
    {
        officeWorkingStatus = "closed";
    }
}

Console.WriteLine(officeWorkingStatus);