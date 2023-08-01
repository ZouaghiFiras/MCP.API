namespace CED.Data.Entities
{
    public class SalesOrderApprovalSetting
    {
        public Guid SoasId { get; set; }

        public byte[] SoasTimeStamp { get; set; } = null!;

        public Guid SoasLegalEntityId { get; set; }

        public Guid? SoasClientId { get; set; }

        public string SoasEntrySystem { get; set; } = null!;

        public bool SoasApprovedBySystem { get; set; }

        public DateTime SoasEffectiveDate { get; set; }

        public DateTime? SoasTerminationDate { get; set; }

        public DateTime SoasCreatedDate { get; set; }

        public string? SoasCreatedBy { get; set; }

        public DateTime SoasLastModifiedDate { get; set; }

        public string? SoasLastModifiedBy { get; set; }

        public virtual Client? SoasClient { get; set; }

        public virtual LegalEntity SoasLegalEntity { get; set; } = null!;
    }
}