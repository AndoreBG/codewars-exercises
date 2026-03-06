static int Enough(int cap, int on, int wait) => on + wait <= cap ? 0 : (on + wait) - cap;

Console.WriteLine(Enough(10, 5, 5));

Console.WriteLine(Enough(10, 6, 5));

Console.WriteLine(Enough(10, 5, 6));

Console.WriteLine(Enough(10, 60, 50));