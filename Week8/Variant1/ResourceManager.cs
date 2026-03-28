namespace Variant1;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> resources = new();

    public void Add(T resource)
    {
        resources.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var resource in resources)
        {
            resource.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var resource in resources)
        {
            resource.Close();
        }
    }
}
