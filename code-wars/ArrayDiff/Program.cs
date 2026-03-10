static int[] ArrayDiff(int[] a, int[] b) => a.Where(x => !b.Contains(x)).ToArray();

Console.WriteLine(ArrayDiff([1, 2, 3, 4, 5], [1, 2, 3, 4, 5, 6]));