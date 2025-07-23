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

    public Cloth(int id, string name, string description, string brand, string origin, int quantity, Color color, double originalPrice, DateTime receiveDate, Condition condition, ClothesSize clothesSize, ClothesCategory clothesCategory) : base(id, name, description, brand, origin, quantity, color, originalPrice, receiveDate, condition)
    {
        ClothesSize = clothesSize;
        ClothesCategory = clothesCategory;
    }
}