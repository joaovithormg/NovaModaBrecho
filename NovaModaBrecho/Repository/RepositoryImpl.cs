using NovaModaBrecho.Models;
using NovaModaBrecho.Repository.Interfaces;
using NovaModaBrecho.Data; 

namespace NovaModaBrecho.Repository;

public class RepositoryImpl<T> : IRepository<T> where T : Item
{
   
    private readonly List<Item> _globalItems; 

    public RepositoryImpl() 
    {
        _globalItems = SeedData.Items; 
    }

    public List<T> GetAll() => _globalItems.OfType<T>().ToList();

    public T? GetById(int id) =>
        _globalItems.OfType<T>().FirstOrDefault(x => x.Id == id);

    public void Add(T item)
    {
        item.Id = _globalItems.Any() ? _globalItems.Max(i => i.Id) + 1 : 1; 
        _globalItems.Add(item);
    }

    public void Update(T item)
    {
        var existingItem = _globalItems.OfType<T>().FirstOrDefault(i => i.Id == item.Id);
        if (existingItem != null)
        {
            var index = _globalItems.IndexOf(existingItem);
            if (index != -1)
            {
                _globalItems[index] = item;
            }
        }
    }

    public void Delete(int id)
    {
        _globalItems.RemoveAll(x => x.Id == id);
    }
}