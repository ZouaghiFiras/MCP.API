namespace CED.Data.Entities
{
    public class ClientTemplate
    {
        public Guid CtpId { get; set; }

        public byte[] CtpTimeStamp { get; set; } = null!;

        public Guid CtpClientId { get; set; }

        public Guid CtpLegalEntityId { get; set; }

        public Guid CtpTemplateId { get; set; }

        public string? CtpBodyEmail { get; set; }

        public string? CtpEntrySystem { get; set; }

        public DateTime CtpEffectiveDate { get; set; }

        public DateTime? CtpTerminationDate { get; set; }

        public DateTime CtpCreatedDate { get; set; }

        public string? CtpCreatedBy { get; set; }

        public DateTime CtpLastModifiedDate { get; set; }

        public string? CtpLastModifiedBy { get; set; }

        public virtual Client CtpClient { get; set; } = null!;

        public virtual LegalEntity CtpLegalEntity { get; set; } = null!;

        public virtual Template CtpTemplate { get; set; } = null!;
    }
}