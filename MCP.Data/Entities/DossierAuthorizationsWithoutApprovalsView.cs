namespace CED.Data.Entities
{
    public class DossierAuthorizationsWithoutApprovalsView
    {
        public Guid Id { get; set; }

        public Guid DossierId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}