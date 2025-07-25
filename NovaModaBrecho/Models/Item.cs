using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public abstract class Item
{
    public int Id { get; set; }
    
    public string Url {get; set;}
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
    public void DisplayCommonDetails()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Descrição: {Description}");
        Console.WriteLine($"Marca: {Brand}");
        Console.WriteLine($"Origem: {Origin}");
        Console.WriteLine($"Quantidade: {Quantity}");
        Console.WriteLine($"Cor: {Color}");
        Console.WriteLine($"Preço original: {OriginalPrice:C}");
        Console.WriteLine($"Data de recebimento: {ReceiveDate:d}");
        Console.WriteLine($"Condição: {Condition}");
    }
    
    public double SalePrice()
    {
        return Condition switch
        {
            Condition.New => OriginalPrice * 0.7,
            Condition.Good => OriginalPrice * 0.6,
            Condition.Fair => OriginalPrice * 0.5,
            _ => OriginalPrice * 0.5
        };
    }

    public double CalculateDiscountedSalePrice()
    {
        double salePrice = SalePrice();
        
        bool inStockOverAYear = (DateTime.Now - ReceiveDate).TotalDays > 365;

        if (inStockOverAYear)
        {
            return salePrice * 0.5;
        }
        else return salePrice;
    }

    protected Item(int id, string url, string name, string description, string brand, string origin, int quantity, Color color, double originalPrice, DateTime receiveDate, Condition condition)
    {
        Id = id;
        Url = url;
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