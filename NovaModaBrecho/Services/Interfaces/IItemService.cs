using NovaModaBrecho.Models;

namespace NovaModaBrecho.Services.Interfaces;

public interface IItemService
{
    public interface IItemService
    {
        List<Item> GetAll();
        Item? GetById(int id);
        void Add(Item item);
        void Update(Item item);
        void Delete(int id);
    }
}