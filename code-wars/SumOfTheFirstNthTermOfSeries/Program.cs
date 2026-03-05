static string seriesSum (int n) {
    double result = Enumerable
        .Range(0, n)
        .Sum(i => 1.0 / (1 + 3 * i));

    return result.ToString("0.00");
}

Console.WriteLine("Soma do Primeiro Termo de Ordem 'n' da Série");

Console.WriteLine("Termo n: 1");
Console.WriteLine(seriesSum(1));

Console.WriteLine("Termo n: 2");
Console.WriteLine(seriesSum(2));

Console.WriteLine("Termo n: 5");
Console.WriteLine(seriesSum(5));