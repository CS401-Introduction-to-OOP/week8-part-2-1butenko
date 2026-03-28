namespace Variant2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10; // create int a
        Console.WriteLine($"{a} | type={a.GetType()}");

        object b = a; // change it to reference -> boxing
        Console.WriteLine($"{b} | type={b.GetType()}");

        int c = (int)b; // change it back to int -> unboxing
        Console.WriteLine($"{c} | type={c.GetType()}");
    }
}