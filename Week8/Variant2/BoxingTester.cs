namespace Variant2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        Console.WriteLine($"{a} | type={a.GetType()}");

        object b = a;
        Console.WriteLine($"{b} | type={b.GetType()}");

        int c = (int)b;
        Console.WriteLine($"{c} | type={c.GetType()}");
    }
}