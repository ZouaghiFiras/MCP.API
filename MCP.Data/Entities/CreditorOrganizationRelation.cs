namespace CED.Data.Entities
{
    public class CreditorOrganizationRelation
    {
        public Guid CorId { get; set; }

        public byte[] CorTimeStamp { get; set; } = null!;

        public Guid CorCreditorId { get; set; }

        public Guid CorOrganizationUnitId { get; set; }

        public DateTime CorEffectiveDate { get; set; }

        public DateTime? CorTerminationDate { get; set; }

        public DateTime CorCreatedDate { get; set; }

        public string? CorCreatedBy { get; set; }

        public DateTime CorLastModifiedDate { get; set; }

        public string? CorLastModifiedBy { get; set; }

        public virtual Creditor CorCreditor { get; set; } = null!;

        public virtual OrganizationUnit CorOrganizationUnit { get; set; } = null!;
    }
}