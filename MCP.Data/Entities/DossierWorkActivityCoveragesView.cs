namespace CED.Data.Entities
{
    public class DossierWorkActivityCoveragesView
    {
        public Guid Id { get; set; }

        public Guid DossierId { get; set; }

        public Guid? InvolvedObjectId { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public Guid WorkActivitityId { get; set; }

        public string WorkActivityName { get; set; } = null!;

        public string WorkActivityCode { get; set; } = null!;

        public string? LicensePlate { get; set; }

        public string? LicenseCountryCode { get; set; }

        public Guid? InsurerId { get; set; }

        public Guid? ServiceId { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}