using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Models;

public class Shoe : Item
{
    public int ShoeSize { get; set; }
    public ShoesCategory ShoesCategory { get; set; }

    public override void DisplayDetails()
    {
        // details
    }
}