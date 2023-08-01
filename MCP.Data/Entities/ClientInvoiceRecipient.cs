namespace CED.Data.Entities
{
    public class ClientInvoiceRecipient
    {
        public Guid CirId { get; set; }

        public byte[] CirTimeStamp { get; set; } = null!;

        public Guid CirClientId { get; set; }

        public Guid CirOrganizationUnitId { get; set; }

        public DateTime CirEffectiveDate { get; set; }

        public DateTime? CirTerminationDate { get; set; }

        public DateTime CirCreatedDate { get; set; }

        public string? CirCreatedBy { get; set; }

        public DateTime CirLastModifiedDate { get; set; }

        public string? CirLastModifiedBy { get; set; }

        public virtual Client CirClient { get; set; } = null!;

        public virtual OrganizationUnit CirOrganizationUnit { get; set; } = null!;
    }
}