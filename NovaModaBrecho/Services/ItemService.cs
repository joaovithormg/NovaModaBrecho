using NovaModaBrecho.Models;
using NovaModaBrecho.Services.Interfaces;

namespace NovaModaBrecho.Services;

public class ItemService<T> : IBaseItemService<T> where T : Item
{
    public readonly List<T> _items = [];
    
    public List<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Update(T item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}