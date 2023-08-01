namespace CED.Data.Entities
{
    public class PurchaseAuthorizationLimit
    {
        public Guid PalId { get; set; }

        public byte[] PalTimeStamp { get; set; } = null!;

        public string PalAuthorizationRoleId { get; set; } = null!;

        public Guid? PalLegalEntityId { get; set; }

        public string? PalEntrySystem { get; set; }

        public DateTime PalEffectiveDate { get; set; }

        public DateTime? PalTerminationDate { get; set; }

        public DateTime PalCreatedDate { get; set; }

        public string? PalCreatedBy { get; set; }

        public DateTime PalLastModifiedDate { get; set; }

        public string? PalLastModifiedBy { get; set; }

        public virtual AuthorizationRole PalAuthorizationRole { get; set; } = null!;

        public virtual LegalEntity? PalLegalEntity { get; set; }
    }
}