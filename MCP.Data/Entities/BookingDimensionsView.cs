namespace CED.Data.Entities
{
    public class BookingDimensionsView
    {
        public Guid Id { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public Guid? ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string EntrySystem { get; set; } = null!;

        public Guid CostCenterId { get; set; }

        public string CostCenterCode { get; set; } = null!;

        public string CostCenterName { get; set; } = null!;

        public Guid? CostUnitId { get; set; }

        public string? CostUnitCode { get; set; }

        public string? CostUnitName { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime? TerminationDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}