using System;
class GlazerCalc
{
    static void Main()
    {
        string name = "Red";
        string location = "South Africa";
        DateTime today = DateTime.UtcNow.Date;
        DateTime christmas = new DateTime(today.Year, 12, 25);
        double daysToChristmas = (christmas - today).TotalDays;
        Console.WriteLine($"My name is {name}, I am from {location}.");
        Console.WriteLine(today.ToString("dd/MM/yyyy"));
        Console.WriteLine($"There are {daysToChristmas} days until Christmas!");

        Console.WriteLine(3 / 2);



        // Copied from the yellow book, not my code
        double width, height, woodLength, glassArea;
        string widthString, heightString;
        // console.writeline("input the width");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);
        // console.writeline("input the height");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);
        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);
        Console.WriteLine("The length of the wood is " +
        woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
        glassArea + " square metres");

        Console.ReadKey();
    }
}




