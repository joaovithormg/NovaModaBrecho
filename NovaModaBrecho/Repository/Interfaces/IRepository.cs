using NovaModaBrecho.Models;

namespace NovaModaBrecho.Repository.Interfaces;

public interface IRepository<T> where T : Item
{
    List<T> GetAll();
    T? GetById(int id);
    void Add(T item);
    void Update(T item);
    void Delete(int id);
}
