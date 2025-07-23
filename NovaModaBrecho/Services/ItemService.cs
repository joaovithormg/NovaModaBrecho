using NovaModaBrecho.Models;
using NovaModaBrecho.Repository.Interfaces;
using NovaModaBrecho.Services.Interfaces;

namespace NovaModaBrecho.Services;

public class ItemService<T>(IRepository<T> repository) : IBaseItemService<T>
    where T : Item
{
    public List<T> GetAll() => repository.GetAll();

    public T? GetById(int id) => repository.GetById(id);

    public void Add(T? item)
    {
        if (item != null)
            repository.Add(item);
    }

    public void Update(T item) => repository.Update(item);

    public void Delete(int id) => repository.Delete(id);
}
