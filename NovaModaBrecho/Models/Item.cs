using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public abstract class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public string Origin { get; set; }
    public int Quantity { get; set; }
    public Color Color { get; set; }
    
    
    public double OriginalPrice { get; set; }
    public DateTime ReceiveDate { get; set; }
    public Condition Condition { get; set; }

    public abstract void DisplayDetails();

    public virtual double SellingPrice()
    {
        return OriginalPrice;
    }

    protected Item(int id, string name, string description, string brand, string origin, int quantity, Color color, double originalPrice, DateTime receiveDate, Condition condition)
    {
        Id = id;
        Name = name;
        Description = description;
        Brand = brand;
        Origin = origin;
        Quantity = quantity;
        Color = color;
        OriginalPrice = originalPrice;
        ReceiveDate = receiveDate;
        Condition = condition;
    }
}