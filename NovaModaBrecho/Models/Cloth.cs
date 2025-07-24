using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public class Cloth : Item
{
    public ClothesSize ClothesSize { get; set; }
    public ClothesCategory ClothesCategory { get; set; }

    public override void DisplayDetails()
    {
        DisplayCommonDetails(); 
        Console.WriteLine($"Tamanho: {ClothesSize}");
        Console.WriteLine($"Categoria: {ClothesCategory}");
    }


    public Cloth(int id, string url, string name, string description, string brand, string origin, int quantity, Color color, double originalPrice, DateTime receiveDate, Condition condition, ClothesSize clothesSize, ClothesCategory clothesCategory) : base(id, url, name, description, brand, origin, quantity, color, originalPrice, receiveDate, condition)
    {
        ClothesSize = clothesSize;
        ClothesCategory = clothesCategory;
    }
}