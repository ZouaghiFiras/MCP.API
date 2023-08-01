namespace CED.Data.Entities
{
    public class OrganizationPaymentCondition
    {
        public Guid OpcId { get; set; }

        public byte[] OpcTimeStamp { get; set; } = null!;

        public Guid OpcOrganizationUnitId { get; set; }

        public Guid OpcPaymentConditionId { get; set; }

        public DateTime OpcEffectiveDate { get; set; }

        public DateTime? OpcTerminationDate { get; set; }

        public DateTime OpcCreatedDate { get; set; }

        public string? OpcCreatedBy { get; set; }

        public DateTime OpcLastModifiedDate { get; set; }

        public string? OpcLastModifiedBy { get; set; }

        public virtual OrganizationUnit OpcOrganizationUnit { get; set; } = null!;

        public virtual PaymentCondition OpcPaymentCondition { get; set; } = null!;
    }
}