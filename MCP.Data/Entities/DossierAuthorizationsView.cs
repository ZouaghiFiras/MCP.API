namespace CED.Data.Entities
{
    public class DossierAuthorizationsView
    {
        public Guid Id { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? EntrySystem { get; set; }

        public Guid? LegalEntityId { get; set; }

        public Guid ClientId { get; set; }

        public Guid ProductId { get; set; }

        public bool IsSelected { get; set; }

        public bool IsApproved { get; set; }

        public bool IsRejected { get; set; }

        public string? ApprovalComment { get; set; }

        public string? SelectedBy { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}