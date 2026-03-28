namespace Variant1;

public static class Variant1Tester
{
    public static void Run()
    {
        Console.WriteLine("Testing Variant1...");
        using (var resource = new FileResource("example.txt"))
        {
            resource.Open();
            Console.WriteLine($"Is Open? {resource.IsOpen}");
        }
        // Dispose should have been called here.
    }
}
