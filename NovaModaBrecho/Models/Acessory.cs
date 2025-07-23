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
}