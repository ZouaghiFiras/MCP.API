namespace CED.Data.Entities
{
    public class OrganizationUnitValidationStatusHistory1
    {
        public Guid Id { get; set; }

        public byte[]? Timestamp { get; set; }

        public Guid OrganizationUnitId { get; set; }

        public Guid ValidationStatusId { get; set; }

        public string? Reason { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}