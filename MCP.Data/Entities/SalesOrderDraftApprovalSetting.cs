namespace CED.Data.Entities
{
    public class SalesOrderDraftApprovalSetting
    {
        public Guid SdasId { get; set; }

        public byte[] SdasTimeStamp { get; set; } = null!;

        public Guid SdasLegalEntityId { get; set; }

        public Guid? SdasClientId { get; set; }

        public string SdasEntrySystem { get; set; } = null!;

        public bool SdasApprovedBySystem { get; set; }

        public DateTime SdasEffectiveDate { get; set; }

        public DateTime? SdasTerminationDate { get; set; }

        public DateTime SdasCreatedDate { get; set; }

        public string? SdasCreatedBy { get; set; }

        public DateTime SdasLastModifiedDate { get; set; }

        public string? SdasLastModifiedBy { get; set; }

        public virtual Client? SdasClient { get; set; }

        public virtual LegalEntity SdasLegalEntity { get; set; } = null!;
    }
}