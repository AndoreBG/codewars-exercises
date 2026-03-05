static double basicOp(char operation, double value1, double value2)
{
    switch (operation)
    {
        case '+':
            return value1 + value2;
        case '-':
            return value1 - value2;
        case '*':
            return value1 * value2;
        case '/':
            return value1 / value2;
        default:
            return -1;
    }
}

Console.WriteLine("Operações Matemáticas Básicas");

Console.WriteLine("Input: '+', 4, 7");
Console.WriteLine(basicOp('+', 4, 7));

Console.WriteLine("Input: '-', 15, 18");
Console.WriteLine(basicOp('-', 15, 18));

Console.WriteLine("Input: '*', 5, 5");
Console.WriteLine(basicOp('*', 5, 5));

Console.WriteLine("Input: '/', 49, 7");
Console.WriteLine(basicOp('/', 49, 7));
