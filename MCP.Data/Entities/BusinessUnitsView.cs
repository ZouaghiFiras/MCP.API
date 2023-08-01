namespace CED.Data.Entities
{
    public class BusinessUnitsView
    {
        public Guid Id { get; set; }

        public string BusinessUnitCode { get; set; } = null!;

        public string? BusinessUnitAbbreviation { get; set; }

        public string BusinessUnitName { get; set; } = null!;

        public Guid? CostCenterId { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public bool Inactive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}