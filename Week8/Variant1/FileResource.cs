namespace Variant1;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"File opened: {Name}");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"File closed: {Name}");
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"[FileResource] Disposed: {Name}");
    }
}
