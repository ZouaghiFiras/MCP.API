namespace CED.Data.Entities
{
    public class ProductsView
    {
        public string PrdCode { get; set; } = null!;

        public string? NaamKort { get; set; }

        public string NaamCpl { get; set; } = null!;

        public string? Prdgr { get; set; }

        public string? Bu { get; set; }

        public string? Afd { get; set; }

        public string Actief { get; set; } = null!;
    }
}