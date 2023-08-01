namespace CED.Data.Entities
{
    public class EuropeanUnionCountry
    {
        public string EucId { get; set; } = null!;

        public byte[] EucTimeStamp { get; set; } = null!;

        public string EucCurrencyCode { get; set; } = null!;

        public DateTime EucEffectiveDate { get; set; }

        public DateTime? EucTerminationDate { get; set; }

        public DateTime EucCreatedDate { get; set; }

        public string? EucCreatedBy { get; set; }

        public DateTime EucLastModifiedDate { get; set; }

        public string? EucLastModifiedBy { get; set; }

        public virtual Country Euc { get; set; } = null!;
    }
}