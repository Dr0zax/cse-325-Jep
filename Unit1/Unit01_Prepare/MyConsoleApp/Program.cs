DateTime now = DateTime.Now;
DateTime christmas = DateTime.Parse("12/25/2026");
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {now}");
Console.WriteLine($"There are {(christmas - now).Days} day(s) left until Christmas!");