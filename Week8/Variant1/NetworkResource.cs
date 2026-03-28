namespace Variant1;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"Network connection opened: {Name}");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"Network connection closed: {Name}");
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"[NetworkResource] Disposed: {Name}");
    }
}
