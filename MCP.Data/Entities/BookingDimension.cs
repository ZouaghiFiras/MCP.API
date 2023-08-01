namespace CED.Data.Entities
{
    public class BookingDimension
    {
        public Guid BkdId { get; set; }

        public byte[] BkdTimeStamp { get; set; } = null!;

        public Guid BkdLegalEntityId { get; set; }

        public Guid? BkdProductId { get; set; }

        public string BkdEntrySystem { get; set; } = null!;

        public Guid BkdCostCenterId { get; set; }

        public Guid? BkdCostUnitId { get; set; }

        public DateTime BkdEffectiveDate { get; set; }

        public DateTime? BkdTerminationDate { get; set; }

        public DateTime BkdCreatedDate { get; set; }

        public string? BkdCreatedBy { get; set; }

        public DateTime BkdLastModifiedDate { get; set; }

        public string? BkdLastModifiedBy { get; set; }

        public Guid? BkdDepartmentId { get; set; }

        public virtual CostCenter BkdCostCenter { get; set; } = null!;

        public virtual CostUnit? BkdCostUnit { get; set; }

        public virtual Department? BkdDepartment { get; set; }

        public virtual LegalEntity BkdLegalEntity { get; set; } = null!;

        public virtual Product? BkdProduct { get; set; }
    }
}