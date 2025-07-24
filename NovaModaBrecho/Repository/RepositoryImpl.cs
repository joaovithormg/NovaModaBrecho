using NovaModaBrecho.Models;
using NovaModaBrecho.Repository.Interfaces;
using NovaModaBrecho.Data; // <-- Import SeedData

namespace NovaModaBrecho.Repository;

public class RepositoryImpl<T> : IRepository<T> where T : Item
{
    // Inject the global, static SeedData.Items list
    // This makes sure all repository instances work with the same data source.
    private readonly List<Item> _globalItems; // Use List<Item> to hold all types

    public RepositoryImpl() // Modify constructor if you don't inject
    {
        _globalItems = SeedData.Items; // Direct access, or inject via DI if you prefer.
        // For static SeedData, direct access is common here.
    }

    // If you were to inject (more complex for static, but good for non-static sources)
    // public RepositoryImpl(List<Item> globalItems) 
    // {
    //     _globalItems = globalItems;
    // }


    public List<T> GetAll() => _globalItems.OfType<T>().ToList();

    public T? GetById(int id) =>
        _globalItems.OfType<T>().FirstOrDefault(x => x.Id == id);

    public void Add(T item)
    {
        // Generate ID using the global list's max ID + 1
        item.Id = _globalItems.Any() ? _globalItems.Max(i => i.Id) + 1 : 1; 
        _globalItems.Add(item); // Add to the global static list
    }

    public void Update(T item)
    {
        var existingItem = _globalItems.OfType<T>().FirstOrDefault(i => i.Id == item.Id);
        if (existingItem != null)
        {
            // Find the index in the global list to replace it
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