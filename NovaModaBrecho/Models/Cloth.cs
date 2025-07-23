using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public class Cloth : Item
{
    public ClothesSize ClothesSize { get; set; }
    public ClothesCategory ClothesCategory { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
    }
}