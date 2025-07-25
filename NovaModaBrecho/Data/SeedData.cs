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
            condition: Condition.New,
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
            condition: Condition.Fair,
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
            condition: Condition.New,
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
        ),
        
                   new Cloth(
        id: 5,
        url: "https://shopxtabay.com/cdn/shop/files/05-01-2024-25_467x700.jpg?v=1714602361",
        name: "Vestido Cupcake",
        description: "Vestido com estética docinha.",
        brand: "Zara",
        origin: "Xangai",
        quantity: 2,
        color: Color.White,
        originalPrice: 180.00,
        receiveDate: DateTime.Now.AddDays(-3),
        condition: Condition.New,
        clothesSize: ClothesSize.S,
        clothesCategory: ClothesCategory.Jacket
    ),
    new Shoe(
        id: 6,
        url: "https://photos.enjoei.com.br/sapato-maryjane-vinho-doll-coquette-plataforma-salto-baixo-soft-99710951/800x800/czM6Ly9waG90b3MuZW5qb2VpLmNvbS5ici9wcm9kdWN0cy8xNTEwOTAyMC81NmQxNDc5ZGE4NGE0NTQ5ZTAyYzVmYzY1ODcyMDNkMy5qcGc",
        name: "Plataforma Baixo Soft",
        description: "Salto plataforma inspirado na estética 'Star Idol'. Fashion, fierce e imbatível.",
        brand: "MaryJane",
        origin: "Seul",
        quantity: 1,
        color: Color.Red,
        originalPrice: 420.00,
        receiveDate: DateTime.Now.AddDays(-7),
        condition: Condition.Fair,
        shoeSize: 38,
        shoesCategory: ShoesCategory.Heels
    ),
    new Accessory(
        id: 7,
        url: "https://m.media-amazon.com/images/I/514hOrD6jXL._UY1000_.jpg",
        name: "Bolsinha Sweet Honey",
        description: "Bolsinha para usar como moedeira. Tão fofa que tenho vergonha de pegar as moedas!!",
        brand: "Kawaii Sugar",
        origin: "Tokyo",
        quantity: 6,
        color: Color.White,
        originalPrice: 35.00,
        receiveDate: DateTime.Now.AddDays(-5),
        condition: Condition.Fair,
        accessoriesSize: AcessoriesSize.Small,
        accessoriesType: AcessoriesType.Bag
    ),
    new Cloth(
        id: 8,
        url: "https://storage.ko-fi.com/cdn/useruploads/display/f2c25d2a-083b-4ffa-9875-b32dfb677e21_img_1972.jpg",
        name: "Saia Nana",
        description: "Saia plissada em renda bege, com babados e laço de cetim.",
        brand: "Desconhecida",
        origin: "Caribe",
        quantity: 3,
        color: Color.Other,
        originalPrice: 210.00,
        receiveDate: DateTime.Now.AddDays(-8),
        condition: Condition.Fair,
        clothesSize: ClothesSize.XS,
        clothesCategory: ClothesCategory.Skirt
    )
    };
}
