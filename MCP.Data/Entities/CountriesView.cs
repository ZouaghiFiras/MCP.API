namespace CED.Data.Entities
{
    public class CountriesView
    {
        public string Id { get; set; } = null!;

        public string Iso3Code { get; set; } = null!;

        public string Name { get; set; } = null!;

        public bool Inactive { get; set; }

        public string? CultureCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}