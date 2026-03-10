static int[] ReverseSeq(int n) => Enumerable.Range(1, n).Reverse().ToArray();

Console.WriteLine(ReverseSeq(5)[0]);
Console.WriteLine(ReverseSeq(5)[1]);
Console.WriteLine(ReverseSeq(5)[2]);
Console.WriteLine(ReverseSeq(5)[3]);
Console.WriteLine(ReverseSeq(5)[4]);