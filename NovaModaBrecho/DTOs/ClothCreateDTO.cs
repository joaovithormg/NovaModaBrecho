using NovaModaBrecho.Models.Enums;

namespace NovaModaBrecho.DTOs;


    public class ClothCreateDto
    {
        public string Url { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public Color Color { get; set; }
        public double OriginalPrice { get; set; }
        public DateTime ReceiveDate { get; set; }
        public Condition Condition { get; set; }
        public ClothesSize ClothesSize { get; set; }
        public ClothesCategory ClothesCategory { get; set; }
}