using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public class Acessorie : Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public string Origin { get; set; }
    public int Quantity { get; set; }
    public Color Color { get; set; }
    public double OriginalPrice { get; set; }
    public DateTime ReceiveDate { get; set; }
    public Condition Condition { get; set; }
    
    // public AccessoriesSize AccessoriesSize { get; set; }
    // public AccessoriesType AccessoriesType { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
    }
}