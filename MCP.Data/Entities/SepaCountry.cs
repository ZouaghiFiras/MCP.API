namespace CED.Data.Entities
{
    public class SepaCountry
    {
        public string ScoId { get; set; } = null!;

        public byte[] ScoTimeStamp { get; set; } = null!;

        public string ScoCurrencyCode { get; set; } = null!;

        public short? ScoLength { get; set; }

        public DateTime ScoCreatedDate { get; set; }

        public string? ScoCreatedBy { get; set; }

        public DateTime ScoLastModifiedDate { get; set; }

        public string? ScoLastModifiedBy { get; set; }

        public virtual Country Sco { get; set; } = null!;
    }
}