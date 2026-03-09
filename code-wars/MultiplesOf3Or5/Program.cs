static int Solution(int value)
{
    if (value < 0) return 0;

    int r = 0;

    for (int i = 0; i < value; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            r += i;
        }
    }

    return r;
}

static int Solution2(int value) => value < 0 ? 0 : Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();

Console.WriteLine(Solution(10));
Console.WriteLine(Solution(-1));
Console.WriteLine(Solution2(10));
Console.WriteLine(Solution2(-1));