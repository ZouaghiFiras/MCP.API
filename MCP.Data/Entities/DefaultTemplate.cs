namespace CED.Data.Entities
{
    public class DefaultTemplate
    {
        public Guid DtpId { get; set; }

        public byte[] DtpTimeStamp { get; set; } = null!;

        public Guid DtpDepartmentId { get; set; }

        public Guid DtpTemplateId { get; set; }

        public string? DtpBodyEmail { get; set; }

        public string? DtpEntrySystem { get; set; }

        public DateTime DtpEffectiveDate { get; set; }

        public DateTime? DtpTerminationDate { get; set; }

        public DateTime DtpCreatedDate { get; set; }

        public string? DtpCreatedBy { get; set; }

        public DateTime DtpLastModifiedDate { get; set; }

        public string? DtpLastModifiedBy { get; set; }

        public virtual Department DtpDepartment { get; set; } = null!;

        public virtual Template DtpTemplate { get; set; } = null!;
    }
}