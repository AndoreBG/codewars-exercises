static string OddOrEven(int[] array)
{
    return array.Sum() % 2 == 0 ? "even" : "odd";
}

Console.WriteLine("\nInput: [0]");
Console.WriteLine(OddOrEven([0]));

Console.WriteLine("\nInput: [0, 1, 4]");
Console.WriteLine(OddOrEven([0, 1, 4]));

Console.WriteLine("\nInput: [0, -1, -5]");
Console.WriteLine(OddOrEven([0, -1, -5]));