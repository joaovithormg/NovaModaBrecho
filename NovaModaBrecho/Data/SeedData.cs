using NovaModaBrecho.Models;
using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.Data;

public static class SeedData
{
    public static List<Item> Items { get; } = new List<Item>
    {
        new Cloth(
            id: 1,
            url: "https://i.ebayimg.com/images/g/K9EAAOSwsVVe~I8V/s-l1200.jpg",
            name: "Vestido Morango",
            description: "Vestido midi com estampa de morangos, estilo cottagecore delicado.",
            brand: "Moranguinho Atelier",
            origin: "Gramado",
            quantity: 3,
            color: Color.Red,
            originalPrice: 140.00,
            receiveDate: DateTime.Now.AddDays(-2),
            condition: Condition.Good,
            clothesSize: ClothesSize.M,
            clothesCategory: ClothesCategory.Dress
        ),
        new Accessory(
            id: 2,
            url: "https://juneptune.com/cdn/shop/files/S8453aab16eca41b7822fbd03c921c3cbm.jpg?v=1693019762",
            name: "Bolsa Lacinho",
            description: "Bolsa rosa com laço frontal. Inspiração Y2K meets hello kitty vibes.",
            brand: "LuxeDoll",
            origin: "Curitiba",
            quantity: 1,
            color: Color.Pink,
            originalPrice: 370.00,
            receiveDate: DateTime.Now.AddDays(-4),
            condition: Condition.Poor,
            accessoriesSize: AcessoriesSize.Medium,
            accessoriesType: AcessoriesType.Bag
        ),
        new Accessory(
            id: 3,
            url: "https://www.viblok.com/cdn/shop/articles/Coquette_Poster_02_jpg_png.jpg?v=1705604758",
            name: "Pingente Queen",
            description: "Pingente dourado com coroa em relevo. Perfeito para as suas selfies no espelho.",
            brand: "Royal Drops",
            origin: "Londres",
            quantity: 4,
            color: Color.Yellow,
            originalPrice: 50.00,
            receiveDate: DateTime.Now.AddDays(-10),
            condition: Condition.Fair,
            accessoriesSize: AcessoriesSize.Small,
            accessoriesType: AcessoriesType.Necklace
        ),
        new Shoe(
            id: 4,
            url: "https://thekawaiifactory.com/cdn/shop/files/IMG_5096.jpg?v=1712047612",
            name: "Sapatilhas Ballet",
            description: "Sapatilhas rosa bebê com fita de amarração — ready for your next TikTok balletcore look.",
            brand: "Petite Pointe",
            origin: "Paris",
            quantity: 2,
            color: Color.Pink,
            originalPrice: 240.00,
            receiveDate: DateTime.Now.AddYears(-1).AddDays(-20),
            condition: Condition.Good,
            shoeSize: 36,
            shoesCategory: ShoesCategory.Flats
        )
    };
}
