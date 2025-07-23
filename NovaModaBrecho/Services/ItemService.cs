using NovaModaBrecho.Models;
using NovaModaBrecho.Models.Enums;
using NovaModaBrecho.Services.Interfaces;

namespace NovaModaBrecho.Services;

public class ItemService : IItemService
{
    public double SellingPrice(Item item)
    {
        switch (item.Condition)
        {
            case Condition.New:
                return item.OriginalPrice * 0.7;
            case Condition.Good:
                return item.OriginalPrice * 0.6;
            default: //case fair
                return item.OriginalPrice * 0.5;
        }
        return 0;
    }
}