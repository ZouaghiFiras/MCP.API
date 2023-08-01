namespace CED.Data.Entities
{
    public class ReversedTaxRate
    {
        public Guid RtrId { get; set; }

        public byte[] RtrTimeStamp { get; set; } = null!;

        public string RtrReversedTaxCodeId { get; set; } = null!;

        public string RtrTaxCategoryCodeId { get; set; } = null!;

        public DateTime RtrEffectiveDate { get; set; }

        public DateTime? RtrTerminationDate { get; set; }

        public DateTime RtrCreatedDate { get; set; }

        public string? RtrCreatedBy { get; set; }

        public DateTime RtrLastModifiedDate { get; set; }

        public string? RtrLastModifiedBy { get; set; }
    }
}