using Variant1;
using Variant2;
using Variant3;

class Program
{
    static void Main(string[] args)
    {
        // Variant 1
        Variant1Tester.Run();
        Console.WriteLine();

        // Variant 2
        ProgramVariant2.Run();
        Console.WriteLine();

        // Variant 3
        Variant3Tester.Run();
    }
}
