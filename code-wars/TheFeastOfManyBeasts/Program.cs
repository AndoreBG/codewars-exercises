using System.Diagnostics.Contracts;

static bool Feast(string beast, string dish) => beast.First() == dish.First() && beast.Last() == dish.Last() ;

Console.WriteLine(Feast("cavalo", "chocolate"));

Console.WriteLine(Feast("pescada", "paçoca"));

Console.WriteLine(Feast("brown bear", "bear claw"));

