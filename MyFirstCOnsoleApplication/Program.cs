string name = "Red";
string location = "South Africa";
DateTime today = DateTime.UtcNow.Date;
DateTime christmas = new DateTime(today.Year, 12, 25);
double daysToChristmas = (christmas - today).TotalDays;
Console.WriteLine($"My name is {name}, I am from {location}.");
Console.WriteLine(today.ToString("dd/MM/yyyy"));
Console.WriteLine($"There are {daysToChristmas}");

