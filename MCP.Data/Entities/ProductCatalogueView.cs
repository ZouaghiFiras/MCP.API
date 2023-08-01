namespace CED.Data.Entities
{
    public class ProductCatalogueView
    {
        public string Product { get; set; } = null!;

        public string? Afdeling { get; set; }

        public string? Werkzaamheid { get; set; }

        public string? Object { get; set; }

        public string? Oorzaak { get; set; }

        public string? Dekking { get; set; }
    }
}