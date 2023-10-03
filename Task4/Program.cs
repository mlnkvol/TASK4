using System;

class Program
{
    static void Main()
    {
        River river = new River
        {
            X = 35.123,
            Y = -120.456,
            Name = "Example River",
            Description = "A beautiful river",
            FlowSpeed = 30.5,
            TotalLength = 200.0
        };

        Mountain mountain = new Mountain
        {
            X = 40.678,
            Y = -110.789,
            Name = "Example Mountain",
            Description = "A majestic mountain",
            HighestPoint = 3500.0
        };

        Console.WriteLine("River Information:\n" + river.GetInformation());
        Console.WriteLine("\nMountain Information:\n" + mountain.GetInformation());

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

