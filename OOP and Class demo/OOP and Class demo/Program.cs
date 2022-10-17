using OOP_and_Class_demo;

Car honda = new Car();

honda.Make = "Honda Civic";
honda.Color = "Grey";

Car ford = new Car();
ford.Make = "Ford Focus";
ford.Color = "Scorpio";

Console.WriteLine($"Andreas drives a {honda.Make}, and it's color is {honda.Color}.");
Console.WriteLine($"Andreas family drove a {ford.Make} back in the days. That {ford.Make} was {ford.Color}." );
