
int numberOfPages = int.Parse(Console.ReadLine());
int pagesReadPerHour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());

int totalHours = numberOfPages / pagesReadPerHour;
int hoursPerDayNeeded = totalHours / numberOfDays;

Console.WriteLine(hoursPerDayNeeded);