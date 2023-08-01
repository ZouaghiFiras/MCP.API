namespace CED.Data.Entities
{
    public class SepaCountriesView
    {
        public string Id { get; set; } = null!;

        public string CurrencyCode { get; set; } = null!;

        public short? Length { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}