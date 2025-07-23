using NovaModaBrecho.Models;
using NovaModaBrecho.Services.Interfaces;

namespace NovaModaBrecho.Services;

public class ItemService<T> : IBaseItemService<T> where T : Item
{
    private readonly List<T> _items = [];
    private int _nextId = 1;
    public List<T> GetAll()
    {
        return _items;
    }

    public T? GetById(int id)
    {
        return _items.FirstOrDefault(x => x.Id == id);
    }

    public void Add(T? item)
    {
        if (item != null)
        {
            item.Id = ++_nextId;
            _items.Add(item);
        }
    }

    public void Update(T item)
    {
        var index = _items.FindIndex(i => i.Id == item.Id);
        if (index != -1)
        {
            _items[index] = item;
        }
    }

    public void Delete(int id)
    {
        _items.RemoveAll(x => x.Id == id);
    }
}