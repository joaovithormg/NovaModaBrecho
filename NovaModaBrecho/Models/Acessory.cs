using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public class Acessory : Item
{
    public AcessoriesSize AccessoriesSize { get; set; }
    public AcessoriesType AccessoriesType { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public Acessory(int id, string name, string description, string brand, string origin, int quantity, Color color, double originalPrice, DateTime receiveDate, Condition condition, AcessoriesSize accessoriesSize, AcessoriesType accessoriesType) : base(id, name, description, brand, origin, quantity, color, originalPrice, receiveDate, condition)
    {
        AccessoriesSize = accessoriesSize;
        AccessoriesType = accessoriesType;
    }
}