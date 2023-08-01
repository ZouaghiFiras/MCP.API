namespace CED.Data.Entities
{
    public class InternationalAssistanceGroup
    {
        public Guid IagId { get; set; }

        public byte[] IagTimeStamp { get; set; } = null!;

        public string? IagExternalCode { get; set; }

        public Guid? IagInternationalAssistanceGroupTypeId { get; set; }

        public string? IagCultureCodePreferredLanguage { get; set; }

        public bool? IagInactive { get; set; }

        public DateTime IagCreatedDate { get; set; }

        public string? IagCreatedBy { get; set; }

        public DateTime IagLastModifiedDate { get; set; }

        public string? IagLastModifiedBy { get; set; }

        public virtual OrganizationUnit Iag { get; set; } = null!;

        public virtual InternationalAssistanceGroupType? IagInternationalAssistanceGroupType { get; set; }
    }
}