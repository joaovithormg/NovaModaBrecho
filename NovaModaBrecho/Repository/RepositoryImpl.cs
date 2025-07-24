using NovaModaBrecho.Models;
using NovaModaBrecho.Models.Enums;
using NovaModaBrecho.Repository.Interfaces;

namespace NovaModaBrecho.Repository;

public class RepositoryImpl<T> : IRepository<T> where T : Item
{
    private readonly List<T> _items = [];
    private int _nextId = 1;

    public List<T> GetAll() => _items;

    public T? GetById(int id) =>
        _items.FirstOrDefault(x => x.Id == id);

    public void Add(T item)
    {
        item.Id = _nextId++;
        _items.Add(item);
    }

    public void Update(T item)
    {
        var index = _items.FindIndex(i => i.Id == item.Id);
        if (index != -1)
            _items[index] = item;
    }

    public void Delete(int id)
    {
        _items.RemoveAll(x => x.Id == id);
    }
    
}