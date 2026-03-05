static int[] minMax(int[] lst) 
{
    return new[] { lst.Min(), lst.Max() };
}

int[] listaPrecos = [1, 2, 3, 4, 5, 6, 7, 8, 9];

Console.WriteLine("O Maior Lucro Vence!");
Console.WriteLine("Aqui está a lista de preços: 1, 2, 3, 4, 5, 6, 7, 8, 9.");
Console.WriteLine("Para obter o maior lucro você deve [comprar por / vender por]: " + minMax(listaPrecos));