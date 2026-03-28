using System.Collections.Generic;
using System.Linq;

namespace Variant3;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public long GetTotalSize()
    {
        return _items.Sum(i => i.GetSize());
    }
}
