using System.Linq;

static int FindSmallestInt(int[] args) => args.Min();

Console.WriteLine(FindSmallestInt([0, 2, -15, 11, -5, -11]));