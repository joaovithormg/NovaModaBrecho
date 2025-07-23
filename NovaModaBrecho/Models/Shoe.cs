using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public class Shoe : Item
{
    public int ShoeSize { get; set; }
    public ShoesCategory ShoesCategory { get; set; }

    public override void DisplayDetails()
    {
        DisplayCommonDetails(); 
        Console.WriteLine($"Tamanho: {ShoeSize}");
        Console.WriteLine($"Categoria: {ShoesCategory}");
    }


    public Shoe(int id, string name, string description, string brand, string origin, int quantity, Color color, double originalPrice, DateTime receiveDate, Condition condition, int shoeSize, ShoesCategory shoesCategory) : base(id, name, description, brand, origin, quantity, color, originalPrice, receiveDate, condition)
    {
        ShoeSize = shoeSize;
        ShoesCategory = shoesCategory;
    }
}